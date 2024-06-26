// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Xml read settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("XmlReadSettings")]
    public partial class XmlReadSettings : FormatReadSettings
    {
        /// <summary>
        /// Initializes a new instance of the XmlReadSettings class.
        /// </summary>
        public XmlReadSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XmlReadSettings class.
        /// </summary>

        /// <param name="additionalProperties">Format read settings.
        /// </param>

        /// <param name="compressionProperties">Compression settings.
        /// </param>

        /// <param name="validationMode">Indicates what validation method is used when reading the xml files.
        /// Allowed values: &#39;none&#39;, &#39;xsd&#39;, or &#39;dtd&#39;. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="detectDataType">Indicates whether type detection is enabled when reading the xml files.
        /// Type: boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="namespaces">Indicates whether namespace is enabled when reading the xml files. Type:
        /// boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="namespacePrefixes">Namespace uri to prefix mappings to override the prefixes in column names
        /// when namespace is enabled, if no prefix is defined for a namespace uri, the
        /// prefix of xml element/attribute name in the xml data file will be used.
        /// Example: &#34;{&#34;http://www.example.com/xml&#34;:&#34;prefix&#34;}&#34; Type: object (or
        /// Expression with resultType object).
        /// </param>
        public XmlReadSettings(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), CompressionReadSettings compressionProperties = default(CompressionReadSettings), object validationMode = default(object), object detectDataType = default(object), object namespaces = default(object), object namespacePrefixes = default(object))

        : base(additionalProperties)
        {
            this.CompressionProperties = compressionProperties;
            this.ValidationMode = validationMode;
            this.DetectDataType = detectDataType;
            this.Namespaces = namespaces;
            this.NamespacePrefixes = namespacePrefixes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets compression settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "compressionProperties")]
        public CompressionReadSettings CompressionProperties {get; set; }

        /// <summary>
        /// Gets or sets indicates what validation method is used when reading the xml
        /// files. Allowed values: &#39;none&#39;, &#39;xsd&#39;, or &#39;dtd&#39;. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "validationMode")]
        public object ValidationMode {get; set; }

        /// <summary>
        /// Gets or sets indicates whether type detection is enabled when reading the
        /// xml files. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "detectDataType")]
        public object DetectDataType {get; set; }

        /// <summary>
        /// Gets or sets indicates whether namespace is enabled when reading the xml
        /// files. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "namespaces")]
        public object Namespaces {get; set; }

        /// <summary>
        /// Gets or sets namespace uri to prefix mappings to override the prefixes in
        /// column names when namespace is enabled, if no prefix is defined for a
        /// namespace uri, the prefix of xml element/attribute name in the xml data
        /// file will be used. Example: &#34;{&#34;http://www.example.com/xml&#34;:&#34;prefix&#34;}&#34; Type:
        /// object (or Expression with resultType object).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "namespacePrefixes")]
        public object NamespacePrefixes {get; set; }
    }
}