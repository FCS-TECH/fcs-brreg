// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.BrReg
// // Filename         : BrRegQuery.cs
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
///     Represents a query to the Brønnøysund Register Centre (Brønnøysundregistrene) for retrieving information related to
///     a specific VAT number.
/// </summary>
/// <remarks>
///     This class is part of the FCS.Lib.BrReg namespace and is designed to facilitate communication with the Brønnøysund
///     Register Centre.
/// </remarks>
public class BrRegQuery
{
    /// <summary>
    ///     Gets or sets the VAT number associated with the query.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the VAT (Value Added Tax) number.
    /// </value>
    /// <remarks>
    ///     The VAT number is used to identify a specific entity in the Brønnøysund Register Centre.
    ///     Ensure the VAT number is valid and correctly formatted before setting this property.
    /// </remarks>
    public string VatNumber { get; set; }
}