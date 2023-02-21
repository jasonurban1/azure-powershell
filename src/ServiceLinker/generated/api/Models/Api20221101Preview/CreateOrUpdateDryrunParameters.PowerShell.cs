// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.PowerShell;

    /// <summary>The dryrun parameters for creation or update a linker</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateOrUpdateDryrunParametersTypeConverter))]
    public partial class CreateOrUpdateDryrunParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.CreateOrUpdateDryrunParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateOrUpdateDryrunParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ActionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunParametersInternal)this).ActionName = (string) content.GetValueForProperty("ActionName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunParametersInternal)this).ActionName, global::System.Convert.ToString);
            }
            if (content.Contains("VNetSolutionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionType = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.VNetSolutionType?) content.GetValueForProperty("VNetSolutionType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionType, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.VNetSolutionType.CreateFrom);
            }
            if (content.Contains("PublicNetworkSolutionFirewallRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionFirewallRule = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IFirewallRules) content.GetValueForProperty("PublicNetworkSolutionFirewallRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionFirewallRule, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.FirewallRulesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationInfoCustomizedKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoCustomizedKey = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfoCustomizedKeys) content.GetValueForProperty("ConfigurationInfoCustomizedKey",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoCustomizedKey, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoCustomizedKeysTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationInfoAdditionalConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAdditionalConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfoAdditionalConfigurations) content.GetValueForProperty("ConfigurationInfoAdditionalConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAdditionalConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoAdditionalConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("VNetSolutionDeleteOrUpdateBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionDeleteOrUpdateBehavior = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior?) content.GetValueForProperty("VNetSolutionDeleteOrUpdateBehavior",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionDeleteOrUpdateBehavior, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior.CreateFrom);
            }
            if (content.Contains("SecretStoreKeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultId = (string) content.GetValueForProperty("SecretStoreKeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("SecretStoreKeyVaultSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultSecretName = (string) content.GetValueForProperty("SecretStoreKeyVaultSecretName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkSolutionDeleteOrUpdateBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionDeleteOrUpdateBehavior = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior?) content.GetValueForProperty("PublicNetworkSolutionDeleteOrUpdateBehavior",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionDeleteOrUpdateBehavior, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior.CreateFrom);
            }
            if (content.Contains("PublicNetworkSolutionAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionAction = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType?) content.GetValueForProperty("PublicNetworkSolutionAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionAction, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType.CreateFrom);
            }
            if (content.Contains("FirewallRuleIPRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleIPRange = (string[]) content.GetValueForProperty("FirewallRuleIPRange",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleIPRange, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ConfigurationInfoDeleteOrUpdateBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoDeleteOrUpdateBehavior = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior?) content.GetValueForProperty("ConfigurationInfoDeleteOrUpdateBehavior",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoDeleteOrUpdateBehavior, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior.CreateFrom);
            }
            if (content.Contains("ConfigurationInfoAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAction = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType?) content.GetValueForProperty("ConfigurationInfoAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAction, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType.CreateFrom);
            }
            if (content.Contains("FirewallRuleAzureService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleAzureService = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType?) content.GetValueForProperty("FirewallRuleAzureService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleAzureService, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType.CreateFrom);
            }
            if (content.Contains("FirewallRuleCallerClientIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleCallerClientIP = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType?) content.GetValueForProperty("FirewallRuleCallerClientIP",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleCallerClientIP, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType.CreateFrom);
            }
            if (content.Contains("VNetSolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolution = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IVNetSolution) content.GetValueForProperty("VNetSolution",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolution, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.VNetSolutionTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecretStore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStore = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ISecretStore) content.GetValueForProperty("SecretStore",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStore, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.SecretStoreTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicNetworkSolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolution = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IPublicNetworkSolution) content.GetValueForProperty("PublicNetworkSolution",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolution, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.PublicNetworkSolutionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfo = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfo) content.GetValueForProperty("ConfigurationInfo",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfo, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).TargetService = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBase) content.GetValueForProperty("TargetService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).TargetService, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.TargetServiceBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).AuthInfo = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IAuthInfoBase) content.GetValueForProperty("AuthInfo",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).AuthInfo, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.AuthInfoBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClientType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ClientType = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ClientType?) content.GetValueForProperty("ClientType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ClientType, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ClientType.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.CreateOrUpdateDryrunParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateOrUpdateDryrunParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ActionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunParametersInternal)this).ActionName = (string) content.GetValueForProperty("ActionName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IDryrunParametersInternal)this).ActionName, global::System.Convert.ToString);
            }
            if (content.Contains("VNetSolutionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionType = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.VNetSolutionType?) content.GetValueForProperty("VNetSolutionType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionType, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.VNetSolutionType.CreateFrom);
            }
            if (content.Contains("PublicNetworkSolutionFirewallRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionFirewallRule = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IFirewallRules) content.GetValueForProperty("PublicNetworkSolutionFirewallRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionFirewallRule, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.FirewallRulesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationInfoCustomizedKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoCustomizedKey = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfoCustomizedKeys) content.GetValueForProperty("ConfigurationInfoCustomizedKey",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoCustomizedKey, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoCustomizedKeysTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationInfoAdditionalConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAdditionalConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfoAdditionalConfigurations) content.GetValueForProperty("ConfigurationInfoAdditionalConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAdditionalConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoAdditionalConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("VNetSolutionDeleteOrUpdateBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionDeleteOrUpdateBehavior = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior?) content.GetValueForProperty("VNetSolutionDeleteOrUpdateBehavior",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolutionDeleteOrUpdateBehavior, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior.CreateFrom);
            }
            if (content.Contains("SecretStoreKeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultId = (string) content.GetValueForProperty("SecretStoreKeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("SecretStoreKeyVaultSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultSecretName = (string) content.GetValueForProperty("SecretStoreKeyVaultSecretName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStoreKeyVaultSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkSolutionDeleteOrUpdateBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionDeleteOrUpdateBehavior = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior?) content.GetValueForProperty("PublicNetworkSolutionDeleteOrUpdateBehavior",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionDeleteOrUpdateBehavior, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior.CreateFrom);
            }
            if (content.Contains("PublicNetworkSolutionAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionAction = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType?) content.GetValueForProperty("PublicNetworkSolutionAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolutionAction, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType.CreateFrom);
            }
            if (content.Contains("FirewallRuleIPRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleIPRange = (string[]) content.GetValueForProperty("FirewallRuleIPRange",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleIPRange, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ConfigurationInfoDeleteOrUpdateBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoDeleteOrUpdateBehavior = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior?) content.GetValueForProperty("ConfigurationInfoDeleteOrUpdateBehavior",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoDeleteOrUpdateBehavior, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.DeleteOrUpdateBehavior.CreateFrom);
            }
            if (content.Contains("ConfigurationInfoAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAction = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType?) content.GetValueForProperty("ConfigurationInfoAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfoAction, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType.CreateFrom);
            }
            if (content.Contains("FirewallRuleAzureService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleAzureService = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType?) content.GetValueForProperty("FirewallRuleAzureService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleAzureService, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType.CreateFrom);
            }
            if (content.Contains("FirewallRuleCallerClientIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleCallerClientIP = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType?) content.GetValueForProperty("FirewallRuleCallerClientIP",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).FirewallRuleCallerClientIP, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType.CreateFrom);
            }
            if (content.Contains("VNetSolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolution = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IVNetSolution) content.GetValueForProperty("VNetSolution",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).VNetSolution, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.VNetSolutionTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecretStore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStore = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ISecretStore) content.GetValueForProperty("SecretStore",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).SecretStore, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.SecretStoreTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicNetworkSolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolution = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IPublicNetworkSolution) content.GetValueForProperty("PublicNetworkSolution",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).PublicNetworkSolution, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.PublicNetworkSolutionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfo = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfo) content.GetValueForProperty("ConfigurationInfo",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ConfigurationInfo, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).TargetService = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBase) content.GetValueForProperty("TargetService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).TargetService, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.TargetServiceBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).AuthInfo = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IAuthInfoBase) content.GetValueForProperty("AuthInfo",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).AuthInfo, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.AuthInfoBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClientType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ClientType = (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ClientType?) content.GetValueForProperty("ClientType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ClientType, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ClientType.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerPropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.CreateOrUpdateDryrunParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ICreateOrUpdateDryrunParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ICreateOrUpdateDryrunParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateOrUpdateDryrunParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.CreateOrUpdateDryrunParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ICreateOrUpdateDryrunParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ICreateOrUpdateDryrunParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateOrUpdateDryrunParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateOrUpdateDryrunParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CreateOrUpdateDryrunParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ICreateOrUpdateDryrunParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The dryrun parameters for creation or update a linker
    [System.ComponentModel.TypeConverter(typeof(CreateOrUpdateDryrunParametersTypeConverter))]
    public partial interface ICreateOrUpdateDryrunParameters

    {

    }
}