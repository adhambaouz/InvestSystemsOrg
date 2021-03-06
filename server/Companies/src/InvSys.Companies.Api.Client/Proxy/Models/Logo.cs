// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace InvSys.Companies.Api.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Logo
    {
        /// <summary>
        /// Initializes a new instance of the Logo class.
        /// </summary>
        public Logo() { }

        /// <summary>
        /// Initializes a new instance of the Logo class.
        /// </summary>
        public Logo(int? id = default(int?), string defaultProperty = default(string), string logomark = default(string), string logotype = default(string), string square = default(string))
        {
            Id = id;
            DefaultProperty = defaultProperty;
            Logomark = logomark;
            Logotype = logotype;
            Square = square;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public string DefaultProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logomark")]
        public string Logomark { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logotype")]
        public string Logotype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "square")]
        public string Square { get; set; }

    }
}
