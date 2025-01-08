// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.BrReg
// // Filename         : BrRegResponseParser.cs
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

using Newtonsoft.Json;

namespace FCS.Lib.BrReg;

/// <summary>
///     Provides functionality to parse responses from the Brønnøysund Register Center (BrReg) into domain-specific models.
/// </summary>
public class BrRegResponseParser
{
    /// <summary>
    ///     Parses a JSON response from the Brønnøysund Register Center (BrReg) and converts it into a
    ///     <see cref="BrRegCompany" /> object.
    /// </summary>
    /// <param name="responseData">The JSON response data as a string.</param>
    /// <returns>A <see cref="BrRegCompany" /> object representing the parsed data.</returns>
    /// <exception cref="JsonSerializationException">
    ///     Thrown if the JSON response cannot be deserialized into a
    ///     <see cref="BrRegCompany" /> object.
    /// </exception>
    public BrRegCompany ParseBrResponse(string responseData)
    {
        return JsonConvert.DeserializeObject<BrRegCompany>(responseData);
    }
}