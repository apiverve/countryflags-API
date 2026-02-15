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
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The format of the flag image
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// The shape of the flag image
        /// </summary>
        [JsonProperty("shape")]
        public string Shape { get; set; }
    }
}
