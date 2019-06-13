// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights_2018_04.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Query results.
    /// </summary>
    public partial class PolicyStatesQueryResults
    {
        /// <summary>
        /// Initializes a new instance of the PolicyStatesQueryResults class.
        /// </summary>
        public PolicyStatesQueryResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyStatesQueryResults class.
        /// </summary>
        /// <param name="odatacontext">OData context string; used by OData
        /// clients to resolve type information based on metadata.</param>
        /// <param name="odatacount">OData entity count; represents the number
        /// of policy state records returned.</param>
        /// <param name="value">Query results.</param>
        public PolicyStatesQueryResults(string odatacontext = default(string), int? odatacount = default(int?), IList<PolicyState> value = default(IList<PolicyState>))
        {
            Odatacontext = odatacontext;
            Odatacount = odatacount;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context string; used by OData clients to resolve
        /// type information based on metadata.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets oData entity count; represents the number of policy
        /// state records returned.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.count")]
        public int? Odatacount { get; set; }

        /// <summary>
        /// Gets or sets query results.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PolicyState> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Odatacount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Odatacount", 0);
            }
        }
    }
}
