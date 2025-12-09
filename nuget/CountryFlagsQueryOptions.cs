using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.CountryFlags
{
    /// <summary>
    /// Query options for the Country Flags API
    /// </summary>
    public class CountryFlagsQueryOptions
    {
        /// <summary>
        /// The 2 letter ISO Country Code (e.g. ZW)
        /// Example: ZW
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The format of the flag to get (png or svg)
        /// Example: png
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// The shape of the flag to get (circle or square)
        /// Example: circle
        /// </summary>
        [JsonProperty("shape")]
        public string Shape { get; set; }
    }
}
