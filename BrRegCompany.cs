// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrRegCompany.cs
// Author           : Frede Hundewadt
// Created          : 2023 12 31 16:24
// 
// Last Modified By : root
// Last Modified On : 2024 03 29 12:37
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2023-2024 FCS Frede's Computer Service.
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

namespace FCS.Lib.BrReg;

/// <summary>
/// </summary>
public class BrRegCompany
{
    /// <summary>
    ///     Entity vat number
    /// </summary>
    public string Organisasjonsnummer { get; set; } = "";

    /// <summary>
    ///     Entity name
    /// </summary>
    public string Navn { get; set; } = "";

    /// <summary>
    ///     Entity deletion date
    /// </summary>
    public string Slettedato { get; set; } = "";

    /// <summary>
    ///     Entity business type
    /// </summary>
    public BrRegCompanyType Organisasjonsform { get; set; } = new();

    /// <summary>
    ///     entity postal address
    /// </summary>
    public BrRegAddress Postadresse { get; set; } = new();

    /// <summary>
    ///     entity business address
    /// </summary>
    public BrRegAddress Forretningsadresse { get; set; } = new();

    /// <summary>
    ///     entity out-of-business flag
    /// </summary>
    public bool Konkurs { get; set; }

    /// <summary>
    ///     entity to be closed flag
    /// </summary>
    public bool UnderAvvikling { get; set; }

    /// <summary>
    ///     entity to be force closed
    /// </summary>
    public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }
}