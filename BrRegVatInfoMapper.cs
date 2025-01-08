// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.BrReg
// // Filename         : BrRegVatInfoMapper.cs
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

using System;
using System.Collections.Generic;
using FCS.Lib.Common;

namespace FCS.Lib.BrReg;

/// <summary>
///     Provides functionality to map Brønnøysund Register Center (BrReg) company data
///     to VAT-related data transfer objects (DTOs) and states.
/// </summary>
/// <remarks>
///     This class is responsible for transforming data from BrRegCompany models into
///     VAT-specific representations such as <see cref="VatInfoDto" /> and <see cref="TaxIdInfo" />.
///     It is utilized in services that interact with Brønnøysund Register Center data.
/// </remarks>
public class BrRegVatInfoMapper
{
    /// <summary>
    ///     Maps a <see cref="BrRegCompany" /> object to a <see cref="VatInfoDto" /> object.
    /// </summary>
    /// <param name="brCompany">The <see cref="BrRegCompany" /> instance containing the source data.</param>
    /// <returns>A <see cref="VatInfoDto" /> instance populated with the mapped data.</returns>
    public VatInfoDto MapBrToCrm(BrRegCompany brCompany)
    {
        return new VatInfoDto
        {
            Name = brCompany.Navn,
            Address = string.Join(", ", brCompany.Forretningsadresse.Adresse),
            City = brCompany.Forretningsadresse.Poststed,
            RequestDate = $"{DateTime.Now:yyyy-MM-dd}",
            ZipCode = brCompany.Forretningsadresse.Postnummer,
            VatNumber = brCompany.Organisasjonsnummer,
            States = new List<VatState>
            {
                new()
                {
                    LastUpdate = "",
                    State = MapBrVatState(brCompany).HasFolded ? "LUKKET" : "NORMAL",
                    TimeFrame = new TimeFrame
                    {
                        StartDate = "",
                        EndDate = ""
                    }
                }
            },
            LifeCycles = new List<LifeCycle>
            {
                new()
                {
                    TimeFrame = new TimeFrame
                    {
                        EndDate = "NN",
                        StartDate = "NN"
                    }
                }
            }
        };
    }


    /// <summary>
    ///     Maps the VAT-related state of a Brønnøysund Register Center (BrReg) company
    ///     to a <see cref="TaxIdInfo" /> object.
    /// </summary>
    /// <param name="brCompany">
    ///     The <see cref="BrRegCompany" /> instance containing the company data to be mapped.
    /// </param>
    /// <returns>
    ///     A <see cref="TaxIdInfo" /> object representing the VAT-related state of the company.
    /// </returns>
    /// <remarks>
    ///     This method evaluates the company's status based on various properties, such as
    ///     bankruptcy, liquidation, or dissolution, and determines whether the VAT number
    ///     is valid or if the company has folded.
    /// </remarks>
    public TaxIdInfo MapBrVatState(BrRegCompany brCompany)
    {
        if (brCompany == null)
            return new TaxIdInfo
            {
                RequestDate = DateTime.Now
            };

        var c = new TaxIdInfo
        {
            Name = brCompany.Navn,
            VatNumber = brCompany.Organisasjonsnummer,
            RequestDate = DateTime.Now,
            VatNumberValid = true
        };

        if (brCompany.Konkurs || brCompany.UnderAvvikling || brCompany.UnderTvangsavviklingEllerTvangsopplosning)
            c.HasFolded = true;

        if (!string.IsNullOrWhiteSpace(brCompany.Organisasjonsform.Utgaatt))
            c.HasFolded = true;

        if (!string.IsNullOrWhiteSpace(brCompany.Slettedato))
            c.HasFolded = true;

        if (c.HasFolded)
            c.VatNumberValid = false;

        return c;
    }
}