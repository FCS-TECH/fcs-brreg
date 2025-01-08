// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.BrReg
// // Filename         : BrRegAddress.cs
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

using System.Collections.Generic;

namespace FCS.Lib.BrReg;

/// <summary>
///     Represents an address in the Brønnøysund Register Center (Brønnøysundregistrene).
///     This class contains details such as country, postal code, municipality, and address lines.
/// </summary>
public class BrRegAddress
{
    /// <summary>
    /// </summary>
    public string Land { get; set; } = "";

    /// <summary>
    ///     Gets or sets the country code associated with the address.
    /// </summary>
    /// <remarks>
    ///     The country code is typically represented as a two-letter ISO 3166-1 alpha-2 code.
    /// </remarks>
    public string Landkode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the postal code associated with the address.
    /// </summary>
    /// <remarks>
    ///     The postal code is used to identify the specific geographic area of the address.
    /// </remarks>
    public string Postnummer { get; set; } = "";

    /// <summary>
    /// </summary>
    public string Poststed { get; set; } = "";

    /// <summary>
    ///     Gets or sets the address lines of the Brønnøysund Register Center (Brønnøysundregistrene).
    ///     Each element in the list represents a single line of the address.
    /// </summary>
    public List<string> Adresse { get; set; } = [];

    /// <summary>
    ///     Gets or sets the name of the municipality (kommune) associated with the address.
    /// </summary>
    /// <remarks>
    ///     The municipality provides additional geographical context for the address
    ///     and is typically used in conjunction with the postal code and country.
    /// </remarks>
    public string Kommune { get; set; } = "";

    /// <summary>
    ///     Gets or sets the municipality number (kommunenummer) associated with the address.
    ///     The municipality number is a unique identifier for municipalities in Norway.
    /// </summary>
    public string Kommunenummer { get; set; } = "";
}