// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Author           : FH
// Created          : 04-06-2022
//
// Last Modified By : FH
// Last Modified On : 04-06-2022
// ***********************************************************************
// <copyright file="BrCompanyModel.cs" company="">
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

namespace FCS.Lib.BrReg
{
    /// <summary>
    /// 
    /// </summary>
    public class BrCompanyModel
    {
        /// <summary>
        /// Entity vat number
        /// </summary>
        public string Organisasjonsnummer { get; set; } = "";
        /// <summary>
        /// Entity name
        /// </summary>
        public string Navn { get; set; } = "";
        /// <summary>
        /// Entity deletion date
        /// </summary>
        public string Slettedato { get; set; } = "";
        /// <summary>
        /// Entity business type
        /// </summary>
        public BrCompanyTypeModel Organisasjonsform { get; set; } = new();
        /// <summary>
        /// entity postal address
        /// </summary>
        public BrAddressModel Postadresse { get; set; } = new();
        /// <summary>
        /// entity business address
        /// </summary>
        public BrAddressModel Forretningsadresse { get; set; } = new();
        /// <summary>
        /// entity out-of-business flag
        /// </summary>
        public bool Konkurs { get; set; }
        /// <summary>
        /// entity to be closed flag
        /// </summary>
        public bool UnderAvvikling { get; set; }
        /// <summary>
        /// entity to be force closed
        /// </summary>
        public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }

    }
}
