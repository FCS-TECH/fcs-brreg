// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Author          : fhdk
// Created          : 2022 12 17 13:33
// 
// Last Modified By: fhdk
// Last Modified On : 2023 03 14 09:16
// ***********************************************************************
// <copyright file="BrResponseParser.cs" company="FCS">
//     Copyright (C) 2022-2023 FCS Frede's Computer Services.
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

using Newtonsoft.Json;

namespace FCS.Lib.BrReg;

/// <summary>
/// Class BrResponseParser
/// </summary>
public class BrResponseParser
{
    /// <summary>
    /// Parse response to BrCompanyModel
    /// </summary>
    /// <param name="responseData"></param>
    /// <returns><see cref="BrCompanyModel"/></returns>
    public BrCompanyModel ParseBrResponse(string responseData)
    {
        return JsonConvert.DeserializeObject<BrCompanyModel>(responseData);
    }
}