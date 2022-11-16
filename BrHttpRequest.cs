// ***********************************************************************
// Assembly         : FCS.Lib.Virk
// Author           : FH
// Created          : 02-21-2022
//
// Last Modified By : FH
// Last Modified On : 04-06-2022
// ***********************************************************************
// <copyright file="BrHttpRequest.cs" company="FCS">
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

using System.Net.Http;
using System.Threading.Tasks;

namespace FCS.Lib.BrReg
{
    /// <summary>
    /// Class BrHttpRequest
    /// </summary>
    public class BrHttpRequest
    {
        /// <summary>
        /// Async http request
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="userAgent"></param>
        /// <returns><see cref="BrResponseView"/></returns>
        public async Task<BrResponseView> GetResponseAsync(string endpoint, string userAgent)
        {
            using var client = new HttpClient();
            using var brRequest = new HttpRequestMessage(HttpMethod.Get, endpoint);

            brRequest.Headers.Add("User-Agent", userAgent);

            var response = await client.SendAsync(brRequest).ConfigureAwait(true);
            var jsonResult = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

            return new BrResponseView
            {
                Code = response.StatusCode,
                IsSuccessStatusCode = response.IsSuccessStatusCode,
                Message = jsonResult
            };
        }
    }
}

