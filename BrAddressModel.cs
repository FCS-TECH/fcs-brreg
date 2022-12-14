// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Author           : FH
// Created          : 04-06-2022
//
// Last Modified By : FH
// Last Modified On : 04-06-2022
// ***********************************************************************
// <copyright file="BrAddressModel.cs" company="">
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

using System.Collections.Generic;

namespace FCS.Lib.BrReg;

/// <summary>
/// 
/// </summary>
public class BrAddressModel
{
    /// <summary>
    /// entity country
    /// </summary>
    public string Land { get; set; } = "";
    /// <summary>
    /// entity country code
    /// </summary>
    public string Landkode { get; set; } = "";
    /// <summary>
    /// entity zip code
    /// </summary>
    public string Postnummer { get; set; } = "";
    /// <summary>
    /// entity postal name
    /// </summary>
    public string Poststed { get; set; } = "";
    /// <summary>
    /// entity address
    /// </summary>
    public List<string> Adresse { get; set; } = new();
    /// <summary>
    /// entity municipal
    /// </summary>
    public string Kommune { get; set; } = "";
    /// <summary>
    /// entity municipal identification
    /// </summary>
    public string Kommunenummer { get; set; } = "";
}