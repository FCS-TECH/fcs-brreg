// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.BrReg
// // Filename         : BrRegHttpRequest.cs
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

using System.Net.Http;
using System.Threading.Tasks;
using FCS.Lib.Common;

namespace FCS.Lib.BrReg;

/// <summary>
///     Represents an HTTP request handler for interacting with the Brønnøysund Register Center (BrReg) services.
/// </summary>
/// <remarks>
///     This class provides functionality to send HTTP requests to BrReg endpoints and retrieve responses.
///     It is designed to be used for querying information from the BrReg service.
/// </remarks>
public class BrRegHttpRequest
{
    /// <summary>
    ///     Sends an asynchronous HTTP GET request to the specified endpoint with the provided user agent
    ///     and retrieves the response as an <see cref="HttpResponseView" />.
    /// </summary>
    /// <param name="endpoint">
    ///     The URL of the endpoint to which the HTTP GET request will be sent.
    /// </param>
    /// <param name="userAgent">
    ///     The user agent string to include in the HTTP request headers.
    /// </param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains an
    ///     <see cref="HttpResponseView" /> object with the HTTP response details, including the status code,
    ///     success status, and response message.
    /// </returns>
    /// <exception cref="HttpRequestException">
    ///     Thrown if the HTTP request fails.
    /// </exception>
    /// <remarks>
    ///     This method is designed to interact with Brønnøysund Register Center (BrReg) services.
    ///     It constructs an HTTP GET request, adds the user agent header, sends the request, and processes
    ///     the response to return a structured view of the HTTP response.
    /// </remarks>
    public async Task<HttpResponseView> GetResponseAsync(string endpoint, string userAgent)
    {
        using var client = new HttpClient();
        using var brRequest = new HttpRequestMessage(HttpMethod.Get, endpoint);

        brRequest.Headers.Add("User-Agent", userAgent);

        var response = await client.SendAsync(brRequest).ConfigureAwait(true);
        var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

        return new HttpResponseView
        {
            Code = response.StatusCode,
            IsSuccessStatusCode = response.IsSuccessStatusCode,
            Message = jsonResult
        };
    }
}