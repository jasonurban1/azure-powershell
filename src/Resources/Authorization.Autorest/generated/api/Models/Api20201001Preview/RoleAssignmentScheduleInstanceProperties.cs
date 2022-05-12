// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Extensions;

    /// <summary>Role assignment schedule properties with scope.</summary>
    public partial class RoleAssignmentScheduleInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleInstancePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AssignmentType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.AssignmentType? _assignmentType;

        /// <summary>Assignment type of the role assignment schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.AssignmentType? AssignmentType { get => this._assignmentType; set => this._assignmentType = value; }

        /// <summary>Backing field for <see cref="Condition" /> property.</summary>
        private string _condition;

        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string Condition { get => this._condition; set => this._condition = value; }

        /// <summary>Backing field for <see cref="ConditionVersion" /> property.</summary>
        private string _conditionVersion;

        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string ConditionVersion { get => this._conditionVersion; set => this._conditionVersion = value; }

        /// <summary>Backing field for <see cref="CreatedOn" /> property.</summary>
        private global::System.DateTime? _createdOn;

        /// <summary>DateTime when role assignment schedule was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedOn { get => this._createdOn; set => this._createdOn = value; }

        /// <summary>Backing field for <see cref="EndDateTime" /> property.</summary>
        private global::System.DateTime? _endDateTime;

        /// <summary>The endDateTime of the role assignment schedule instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? EndDateTime { get => this._endDateTime; set => this._endDateTime = value; }

        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalId = value ?? null; }

        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalType = value ?? null; }

        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionId = value ?? null; }

        /// <summary>Backing field for <see cref="ExpandedProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedProperties _expandedProperty;

        /// <summary>Additional properties of principal, scope and role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedProperties ExpandedProperty { get => (this._expandedProperty = this._expandedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedProperties()); set => this._expandedProperty = value; }

        /// <summary>Backing field for <see cref="LinkedRoleEligibilityScheduleId" /> property.</summary>
        private string _linkedRoleEligibilityScheduleId;

        /// <summary>roleEligibilityScheduleId used to activate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string LinkedRoleEligibilityScheduleId { get => this._linkedRoleEligibilityScheduleId; set => this._linkedRoleEligibilityScheduleId = value; }

        /// <summary>
        /// Backing field for <see cref="LinkedRoleEligibilityScheduleInstanceId" /> property.
        /// </summary>
        private string _linkedRoleEligibilityScheduleInstanceId;

        /// <summary>roleEligibilityScheduleInstanceId linked to this roleAssignmentScheduleInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string LinkedRoleEligibilityScheduleInstanceId { get => this._linkedRoleEligibilityScheduleInstanceId; set => this._linkedRoleEligibilityScheduleInstanceId = value; }

        /// <summary>Backing field for <see cref="MemberType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType? _memberType;

        /// <summary>Membership type of the role assignment schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType? MemberType { get => this._memberType; set => this._memberType = value; }

        /// <summary>Internal Acessors for ExpandedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedProperties Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleInstancePropertiesInternal.ExpandedProperty { get => (this._expandedProperty = this._expandedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedProperties()); set { {_expandedProperty = value;} } }

        /// <summary>Internal Acessors for ExpandedPropertyPrincipal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleInstancePropertiesInternal.ExpandedPropertyPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Principal; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Principal = value; }

        /// <summary>Internal Acessors for ExpandedPropertyRoleDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleInstancePropertiesInternal.ExpandedPropertyRoleDefinition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinition = value; }

        /// <summary>Internal Acessors for ExpandedPropertyScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleInstancePropertiesInternal.ExpandedPropertyScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Scope = value; }

        /// <summary>Backing field for <see cref="OriginRoleAssignmentId" /> property.</summary>
        private string _originRoleAssignmentId;

        /// <summary>Role Assignment Id in external system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string OriginRoleAssignmentId { get => this._originRoleAssignmentId; set => this._originRoleAssignmentId = value; }

        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalDisplayName = value ?? null; }

        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalEmail = value ?? null; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType? _principalType;

        /// <summary>The principal type of the assigned principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType? PrincipalType { get => this._principalType; set => this._principalType = value; }

        /// <summary>Backing field for <see cref="RoleAssignmentScheduleId" /> property.</summary>
        private string _roleAssignmentScheduleId;

        /// <summary>Id of the master role assignment schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string RoleAssignmentScheduleId { get => this._roleAssignmentScheduleId; set => this._roleAssignmentScheduleId = value; }

        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionDisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="RoleDefinitionId" /> property.</summary>
        private string _roleDefinitionId;

        /// <summary>The role definition ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string RoleDefinitionId { get => this._roleDefinitionId; set => this._roleDefinitionId = value; }

        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionType = value ?? null; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The role assignment schedule scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeDisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeId = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeType = value ?? null; }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        /// <summary>The startDateTime of the role assignment schedule instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDateTime { get => this._startDateTime; set => this._startDateTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status? _status;

        /// <summary>The status of the role assignment schedule instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status? Status { get => this._status; set => this._status = value; }

        /// <summary>
        /// Creates an new <see cref="RoleAssignmentScheduleInstanceProperties" /> instance.
        /// </summary>
        public RoleAssignmentScheduleInstanceProperties()
        {

        }
    }
    /// Role assignment schedule properties with scope.
    public partial interface IRoleAssignmentScheduleInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Assignment type of the role assignment schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Assignment type of the role assignment schedule",
        SerializedName = @"assignmentType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.AssignmentType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.AssignmentType? AssignmentType { get; set; }
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'",
        SerializedName = @"condition",
        PossibleTypes = new [] { typeof(string) })]
        string Condition { get; set; }
        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the condition. Currently accepted value is '2.0'",
        SerializedName = @"conditionVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ConditionVersion { get; set; }
        /// <summary>DateTime when role assignment schedule was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DateTime when role assignment schedule was created",
        SerializedName = @"createdOn",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedOn { get; set; }
        /// <summary>The endDateTime of the role assignment schedule instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endDateTime of the role assignment schedule instance",
        SerializedName = @"endDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the principal",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ExpandedPropertiesPrincipalId { get; set; }
        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the principal",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ExpandedPropertiesPrincipalType { get; set; }
        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the role definition",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ExpandedPropertiesRoleDefinitionId { get; set; }
        /// <summary>roleEligibilityScheduleId used to activate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"roleEligibilityScheduleId used to activate",
        SerializedName = @"linkedRoleEligibilityScheduleId",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedRoleEligibilityScheduleId { get; set; }
        /// <summary>roleEligibilityScheduleInstanceId linked to this roleAssignmentScheduleInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"roleEligibilityScheduleInstanceId linked to this roleAssignmentScheduleInstance",
        SerializedName = @"linkedRoleEligibilityScheduleInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedRoleEligibilityScheduleInstanceId { get; set; }
        /// <summary>Membership type of the role assignment schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Membership type of the role assignment schedule",
        SerializedName = @"memberType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType? MemberType { get; set; }
        /// <summary>Role Assignment Id in external system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Role Assignment Id in external system",
        SerializedName = @"originRoleAssignmentId",
        PossibleTypes = new [] { typeof(string) })]
        string OriginRoleAssignmentId { get; set; }
        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the principal",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email id of the principal",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalEmail { get; set; }
        /// <summary>The principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The principal ID.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>The principal type of the assigned principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The principal type of the assigned principal ID.",
        SerializedName = @"principalType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType? PrincipalType { get; set; }
        /// <summary>Id of the master role assignment schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the master role assignment schedule",
        SerializedName = @"roleAssignmentScheduleId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleAssignmentScheduleId { get; set; }
        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the role definition",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>The role definition ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role definition ID.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the role definition",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionType { get; set; }
        /// <summary>The role assignment schedule scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role assignment schedule scope.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the resource",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scope id of the resource",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeType { get; set; }
        /// <summary>The startDateTime of the role assignment schedule instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The startDateTime of the role assignment schedule instance",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>The status of the role assignment schedule instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the role assignment schedule instance.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status? Status { get; set; }

    }
    /// Role assignment schedule properties with scope.
    internal partial interface IRoleAssignmentScheduleInstancePropertiesInternal

    {
        /// <summary>Assignment type of the role assignment schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.AssignmentType? AssignmentType { get; set; }
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        string Condition { get; set; }
        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        string ConditionVersion { get; set; }
        /// <summary>DateTime when role assignment schedule was created</summary>
        global::System.DateTime? CreatedOn { get; set; }
        /// <summary>The endDateTime of the role assignment schedule instance</summary>
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>Id of the principal</summary>
        string ExpandedPropertiesPrincipalId { get; set; }
        /// <summary>Type of the principal</summary>
        string ExpandedPropertiesPrincipalType { get; set; }
        /// <summary>Id of the role definition</summary>
        string ExpandedPropertiesRoleDefinitionId { get; set; }
        /// <summary>Additional properties of principal, scope and role definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedProperties ExpandedProperty { get; set; }
        /// <summary>Details of the principal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal ExpandedPropertyPrincipal { get; set; }
        /// <summary>Details of role definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition ExpandedPropertyRoleDefinition { get; set; }
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope ExpandedPropertyScope { get; set; }
        /// <summary>roleEligibilityScheduleId used to activate</summary>
        string LinkedRoleEligibilityScheduleId { get; set; }
        /// <summary>roleEligibilityScheduleInstanceId linked to this roleAssignmentScheduleInstance</summary>
        string LinkedRoleEligibilityScheduleInstanceId { get; set; }
        /// <summary>Membership type of the role assignment schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType? MemberType { get; set; }
        /// <summary>Role Assignment Id in external system</summary>
        string OriginRoleAssignmentId { get; set; }
        /// <summary>Display name of the principal</summary>
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        string PrincipalEmail { get; set; }
        /// <summary>The principal ID.</summary>
        string PrincipalId { get; set; }
        /// <summary>The principal type of the assigned principal ID.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType? PrincipalType { get; set; }
        /// <summary>Id of the master role assignment schedule</summary>
        string RoleAssignmentScheduleId { get; set; }
        /// <summary>Display name of the role definition</summary>
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>The role definition ID.</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        string RoleDefinitionType { get; set; }
        /// <summary>The role assignment schedule scope.</summary>
        string Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }
        /// <summary>The startDateTime of the role assignment schedule instance</summary>
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>The status of the role assignment schedule instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status? Status { get; set; }

    }
}