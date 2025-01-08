// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.BrReg
// // Filename         : BrRegCompany.cs
// // Created          : 2025-01-03 14:01
// // Last Modified By : dev
// // Last Modified On : 2025-01-04 11:01
// // ***********************************************************************
// // <copyright company="Frede Hundewadt">
// //     Copyright (C) 2010-2025 Frede Hundewadt
// //     This program is free software: you can redistribute it and/or modify
// //     it under the terms of the GNU Affero General Public License as
// //     published by the Free Software Foundation, either version 3 of the
// //     License, or (at your option) any later version.
// //
// //     This program is distributed in the hope that it will be useful,
// //     but WITHOUT ANY WARRANTY; without even the implied warranty of
// //     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// //     GNU Affero General Public License for more details.
// //
// //     You should have received a copy of the GNU Affero General Public License
// //     along with this program.  If not, see [https://www.gnu.org/licenses]
// // </copyright>
// // <summary></summary>
// // ***********************************************************************

namespace FCS.Lib.BrReg;

/// <summary>
/// </summary>
public class BrRegCompany
{
    /// <summary>
    ///     Gets or sets the organization's unique identifier, known as the organization number.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the unique organization number.
    /// </value>
    public string Organisasjonsnummer { get; set; } = "";

    /// <summary>
    ///     Gets or sets the name of the company.
    /// </summary>
    /// <value>
    ///     The name of the company as registered in the Brønnøysund Register.
    /// </value>
    public string Navn { get; set; } = "";

    /// <summary>
    ///     Gets or sets the deletion date of the company.
    ///     This property indicates the date on which the company was deleted
    ///     from the Brønnøysund Register Center (Brønnøysundregistrene).
    /// </summary>
    public string Slettedato { get; set; } = "";

    /// <summary>
    ///     Gets or sets the organizational form of the company.
    /// </summary>
    /// <value>
    ///     An instance of <see cref="BrRegCompanyType" /> representing the type of organization.
    /// </value>
    public BrRegCompanyType Organisasjonsform { get; set; } = new();

    /// <summary>
    ///     Gets or sets the postal address of the company as registered in the Brønnøysund Register Center.
    /// </summary>
    /// <value>
    ///     An instance of <see cref="BrRegAddress" /> containing details such as country, postal code, municipality, and
    ///     address lines.
    /// </value>
    public BrRegAddress Postadresse { get; set; } = new();

    /// <summary>
    ///     Gets or sets the business address of the company as registered in the Brønnøysund Register Center.
    /// </summary>
    /// <remarks>
    ///     This property provides detailed information about the company's business address,
    ///     including country, postal code, municipality, and address lines.
    /// </remarks>
    public BrRegAddress Forretningsadresse { get; set; } = new();

    /// <summary>
    ///     Gets or sets a value indicating whether the company is declared bankrupt.
    /// </summary>
    /// <value>
    ///     <c>true</c> if the company is bankrupt; otherwise, <c>false</c>.
    /// </value>
    public bool Konkurs { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the company is under liquidation.
    /// </summary>
    /// <value>
    ///     <c>true</c> if the company is under liquidation; otherwise, <c>false</c>.
    /// </value>
    public bool UnderAvvikling { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the company is under forced liquidation or forced dissolution.
    /// </summary>
    /// <value>
    ///     <c>true</c> if the company is under forced liquidation or forced dissolution; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    ///     This property is used to determine if the company is in a state of mandatory closure,
    ///     which may affect its operational status and validity.
    /// </remarks>
    public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }
}