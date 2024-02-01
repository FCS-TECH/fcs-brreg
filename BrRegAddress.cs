// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Author           : 
// Created          : 2023-10-02
// 
// Last Modified By : root
// Last Modified On : 2023-10-13 07:33
// ***********************************************************************
// <copyright file="BrRegAddress.cs" company="FCS">
//     Copyright (C) 2015 - 2023 FCS Frede's Computer Service.
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

using System.Collections.Generic;

namespace FCS.Lib.BrReg;

/// <summary>
/// </summary>
public class BrRegAddress
{
    /// <summary>
    ///     entity country
    /// </summary>
    public string Land { get; set; } = "";

    /// <summary>
    ///     entity country code
    /// </summary>
    public string Landkode { get; set; } = "";

    /// <summary>
    ///     entity zip code
    /// </summary>
    public string Postnummer { get; set; } = "";

    /// <summary>
    ///     entity postal name
    /// </summary>
    public string Poststed { get; set; } = "";

    /// <summary>
    ///     entity address
    /// </summary>
    public List<string> Adresse { get; set; } = new();

    /// <summary>
    ///     entity municipal
    /// </summary>
    public string Kommune { get; set; } = "";

    /// <summary>
    ///     entity municipal identification
    /// </summary>
    public string Kommunenummer { get; set; } = "";
}