// ***********************************************************************
// Assembly         : FCS.Lib.Virk
// Author           : FH
// Created          : 02-21-2022
//
// Last Modified By : FH
// Last Modified On : 04-06-2022
// ***********************************************************************
// <copyright file="BrVatInfoMapper.cs" company="FCS">
//    Copyright (C) 2022 FCS Frede's Computer Services.
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Affero General Public License as
//    published by the Free Software Foundation, either version 3 of the
//    License, or (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Affero General Public License for more details.
//
//    You should have received a copy of the GNU Affero General Public License
//    along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using FCS.Lib.BrReg.Models;
using FCS.Lib.Common;

namespace FCS.Lib.BrReg
{
    public class BrVatInfoMapper
    {
        public VatStateInfo MapBrToCrm(BrCompanyModel brCompany)
        {
            if (brCompany == null)
            {
                return new VatStateInfo
                {
                    RequestDate = DateTime.Now
                };
            }

            var c = new VatStateInfo
            {
                Name = brCompany.Navn,
                VatNumber = brCompany.Organisasjonsnummer,
                RequestDate = DateTime.Now,
                VatNumberValid = true
            };

            if (brCompany.Konkurs == "true")
                c.HasFolded = true;

            if (brCompany.UnderAvvikling == "true")
                c.HasFolded = true;

            if (brCompany.UnderTvangsavviklingEllerTvangsopplosning == "true")
                c.HasFolded = true;

            if(!string.IsNullOrWhiteSpace(brCompany.Organisasjonsform.Utgaatt))
                c.HasFolded = true;

            if (!string.IsNullOrWhiteSpace(brCompany.Slettedato))
                c.HasFolded = true;

            if (c.HasFolded)
                c.VatNumberValid = false;

            return c;
        }
    }
}