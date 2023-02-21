// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>a dryrun job resource</summary>
    public partial class DryrunResource :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResource,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for OperationPreview</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunOperationPreview[] Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal.OperationPreview { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).OperationPreview; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).OperationPreview = value; }

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunParameters Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal.Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).Parameter = value; }

        /// <summary>Internal Acessors for ParameterActionName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal.ParameterActionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).ParameterActionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).ParameterActionName = value; }

        /// <summary>Internal Acessors for PrerequisiteResult</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPrerequisiteResult[] Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal.PrerequisiteResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).PrerequisiteResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).PrerequisiteResult = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunProperties Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.DryrunProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>the preview of the operations for creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunOperationPreview[] OperationPreview { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).OperationPreview; }

        /// <summary>The name of action for you dryrun job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inlined)]
        public string ParameterActionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).ParameterActionName; }

        /// <summary>the result of the dryrun</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPrerequisiteResult[] PrerequisiteResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).PrerequisiteResult; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunProperties _property;

        /// <summary>The properties of the dryrun job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.DryrunProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="DryrunResource" /> instance.</summary>
        public DryrunResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// a dryrun job resource
    public partial interface IDryrunResource :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResource
    {
        /// <summary>the preview of the operations for creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"the preview of the operations for creation",
        SerializedName = @"operationPreviews",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunOperationPreview) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunOperationPreview[] OperationPreview { get;  }
        /// <summary>The name of action for you dryrun job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of action for you dryrun job.",
        SerializedName = @"actionName",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterActionName { get;  }
        /// <summary>the result of the dryrun</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"the result of the dryrun",
        SerializedName = @"prerequisiteResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPrerequisiteResult) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPrerequisiteResult[] PrerequisiteResult { get;  }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state. ",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// a dryrun job resource
    internal partial interface IDryrunResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api30.IResourceInternal
    {
        /// <summary>the preview of the operations for creation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunOperationPreview[] OperationPreview { get; set; }
        /// <summary>The parameters of the dryrun</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunParameters Parameter { get; set; }
        /// <summary>The name of action for you dryrun job.</summary>
        string ParameterActionName { get; set; }
        /// <summary>the result of the dryrun</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunPrerequisiteResult[] PrerequisiteResult { get; set; }
        /// <summary>The properties of the dryrun job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        string ProvisioningState { get; set; }

    }
}