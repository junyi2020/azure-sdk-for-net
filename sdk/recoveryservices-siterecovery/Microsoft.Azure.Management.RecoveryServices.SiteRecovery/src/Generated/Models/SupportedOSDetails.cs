// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Supported Operating system details.
    /// </summary>
    public partial class SupportedOSDetails
    {
        /// <summary>
        /// Initializes a new instance of the SupportedOSDetails class.
        /// </summary>
        public SupportedOSDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupportedOSDetails class.
        /// </summary>
        /// <param name="osName">The name.</param>
        /// <param name="osType">The type.</param>
        /// <param name="osVersions">List of version for OS.</param>
        public SupportedOSDetails(string osName = default(string), string osType = default(string), IList<OSVersionWrapper> osVersions = default(IList<OSVersionWrapper>))
        {
            OsName = osName;
            OsType = osType;
            OsVersions = osVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "osName")]
        public string OsName { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets list of version for OS.
        /// </summary>
        [JsonProperty(PropertyName = "osVersions")]
        public IList<OSVersionWrapper> OsVersions { get; set; }

    }
}