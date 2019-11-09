// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// institutionData
    /// </summary>
    public partial class MicrosoftgraphinstitutionData
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphinstitutionData
        /// class.
        /// </summary>
        public MicrosoftgraphinstitutionData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphinstitutionData
        /// class.
        /// </summary>
        public MicrosoftgraphinstitutionData(string description = default(string), string displayName = default(string), MicrosoftgraphphysicalAddress location = default(MicrosoftgraphphysicalAddress), string webUrl = default(string))
        {
            Description = description;
            DisplayName = displayName;
            Location = location;
            WebUrl = webUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public MicrosoftgraphphysicalAddress Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

    }
}