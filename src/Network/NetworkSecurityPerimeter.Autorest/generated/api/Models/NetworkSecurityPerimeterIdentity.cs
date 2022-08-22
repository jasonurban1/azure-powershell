// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Extensions;

    public partial class NetworkSecurityPerimeterIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentityInternal
    {

        /// <summary>Backing field for <see cref="AccessRuleName" /> property.</summary>
        private string _accessRuleName;

        /// <summary>The name of the NSP access rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string AccessRuleName { get => this._accessRuleName; set => this._accessRuleName = value; }

        /// <summary>Backing field for <see cref="AssociationName" /> property.</summary>
        private string _associationName;

        /// <summary>The name of the NSP association.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string AssociationName { get => this._associationName; set => this._associationName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="NetworkSecurityPerimeterName" /> property.</summary>
        private string _networkSecurityPerimeterName;

        /// <summary>The name of the network security perimeter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string NetworkSecurityPerimeterName { get => this._networkSecurityPerimeterName; set => this._networkSecurityPerimeterName = value; }

        /// <summary>Backing field for <see cref="ProfileName" /> property.</summary>
        private string _profileName;

        /// <summary>The name of the NSP profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string ProfileName { get => this._profileName; set => this._profileName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part
        /// of the URI for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="NetworkSecurityPerimeterIdentity" /> instance.</summary>
        public NetworkSecurityPerimeterIdentity()
        {

        }
    }
    public partial interface INetworkSecurityPerimeterIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IJsonSerializable
    {
        /// <summary>The name of the NSP access rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NSP access rule.",
        SerializedName = @"accessRuleName",
        PossibleTypes = new [] { typeof(string) })]
        string AccessRuleName { get; set; }
        /// <summary>The name of the NSP association.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NSP association.",
        SerializedName = @"associationName",
        PossibleTypes = new [] { typeof(string) })]
        string AssociationName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the network security perimeter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the network security perimeter.",
        SerializedName = @"networkSecurityPerimeterName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterName { get; set; }
        /// <summary>The name of the NSP profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NSP profile.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get; set; }
        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part
        /// of the URI for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface INetworkSecurityPerimeterIdentityInternal

    {
        /// <summary>The name of the NSP access rule.</summary>
        string AccessRuleName { get; set; }
        /// <summary>The name of the NSP association.</summary>
        string AssociationName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the network security perimeter.</summary>
        string NetworkSecurityPerimeterName { get; set; }
        /// <summary>The name of the NSP profile.</summary>
        string ProfileName { get; set; }
        /// <summary>The name of the resource group.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part
        /// of the URI for every service call.
        /// </summary>
        string SubscriptionId { get; set; }

    }
}