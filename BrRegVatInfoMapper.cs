// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Author           : 
// Created          : 2023 10 01 11:03
// 
// Last Modified By : root
// Last Modified On : 2023 10 02 15:23
// ***********************************************************************
// <copyright file="BrRegVatInfoMapper.cs" company="FCS">
//     Copyright (C) 2023-2023 FCS Frede's Computer Services.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using FCS.Lib.Common;

namespace FCS.Lib.BrReg;

/// <summary>
///     Class BrVatInfoMapper
/// </summary>
public class BrRegVatInfoMapper
{
    /// <summary>
    ///     Map BrCompanyModel to CRM
    /// </summary>
    /// <param name="brCompany"></param>
    /// <returns>
    ///     <see cref="VatInfoDto" />
    /// </returns>
    /// <see cref="BrRegCompany" />
    /// <see cref="VatState" />
    /// <see cref="LifeCycle" />
    /// <see cref="TimeFrame" />
    public VatInfoDto MapBrToCrm(BrRegCompany brCompany)
    {
        return new VatInfoDto
        {
            Name = brCompany.Navn,
            Address = string.Join(", ", brCompany.Forretningsadresse.Adresse),
            City = brCompany.Forretningsadresse.Poststed,
            RequestDate = $"{DateTime.Now:yyyy-MM-dd}",
            ZipCode = brCompany.Forretningsadresse.Postnummer,
            VatNumber = brCompany.Organisasjonsnummer,
            States = new List<VatState>
            {
                new()
                {
                    LastUpdate = "",
                    State = MapBrVatState(brCompany).HasFolded ? "LUKKET" : "NORMAL",
                    TimeFrame = new TimeFrame
                    {
                        StartDate = "",
                        EndDate = ""
                    }
                }
            },
            LifeCycles = new List<LifeCycle>
            {
                new()
                {
                    TimeFrame = new TimeFrame
                    {
                        EndDate = "NN",
                        StartDate = "NN"
                    }
                }
            }
        };
    }

    /// <summary>
    ///     Map BrCompanyModel to VatStateInfo
    /// </summary>
    /// <param name="brCompany"></param>
    /// <returns>
    ///     <see cref="TaxIdInfo" />
    /// </returns>
    public TaxIdInfo MapBrVatState(BrRegCompany brCompany)
    {
        if (brCompany == null)
            return new TaxIdInfo
            {
                RequestDate = DateTime.Now
            };

        var c = new TaxIdInfo
        {
            Name = brCompany.Navn,
            VatNumber = brCompany.Organisasjonsnummer,
            RequestDate = DateTime.Now,
            VatNumberValid = true
        };

        if (brCompany.Konkurs || brCompany.UnderAvvikling || brCompany.UnderTvangsavviklingEllerTvangsopplosning)
            c.HasFolded = true;

        if (!string.IsNullOrWhiteSpace(brCompany.Organisasjonsform.Utgaatt))
            c.HasFolded = true;

        if (!string.IsNullOrWhiteSpace(brCompany.Slettedato))
            c.HasFolded = true;

        if (c.HasFolded)
            c.VatNumberValid = false;

        return c;
    }
}