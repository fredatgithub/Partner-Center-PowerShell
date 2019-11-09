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
    /// outlookGeoCoordinates
    /// </summary>
    public partial class MicrosoftgraphoutlookGeoCoordinates
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphoutlookGeoCoordinates class.
        /// </summary>
        public MicrosoftgraphoutlookGeoCoordinates()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphoutlookGeoCoordinates class.
        /// </summary>
        public MicrosoftgraphoutlookGeoCoordinates(double? altitude = default(double?), double? latitude = default(double?), double? longitude = default(double?), double? accuracy = default(double?), double? altitudeAccuracy = default(double?))
        {
            Altitude = altitude;
            Latitude = latitude;
            Longitude = longitude;
            Accuracy = accuracy;
            AltitudeAccuracy = altitudeAccuracy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "altitude")]
        public double? Altitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accuracy")]
        public double? Accuracy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "altitudeAccuracy")]
        public double? AltitudeAccuracy { get; set; }

    }
}