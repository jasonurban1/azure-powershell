// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>Represents an accepted audience trusted by the cluster.</summary>
    public partial class AcceptedAudiences :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IAcceptedAudiences,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IAcceptedAudiencesInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>GUID or valid URL representing an accepted audience.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AcceptedAudiences" /> instance.</summary>
        public AcceptedAudiences()
        {

        }
    }
    /// Represents an accepted audience trusted by the cluster.
    public partial interface IAcceptedAudiences :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>GUID or valid URL representing an accepted audience.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GUID or valid URL representing an accepted audience.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Represents an accepted audience trusted by the cluster.
    internal partial interface IAcceptedAudiencesInternal

    {
        /// <summary>GUID or valid URL representing an accepted audience.</summary>
        string Value { get; set; }

    }
}