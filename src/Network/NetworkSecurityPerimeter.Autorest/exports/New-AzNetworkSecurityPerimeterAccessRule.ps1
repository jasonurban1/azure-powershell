
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates a network access rule.
.Description
Creates or updates a network access rule.
.Example

 New-AzNetworkSecurityPerimeterAccessRule -Name accessRule1 -ProfileName profile2 -ResourceGroupName ResourceGroup-1 -SecurityPerimeterName nsp3 -AddressPrefix '10.10.0.0/16' -Direction 'Inbound' -Location eastus2euap

.Example

$perimeter1 = @{
  id='/subscriptions/<SubscriptionId>/resourceGroups/ResourceGroup-1/providers/Microsoft.Network/networkSecurityPerimeters/kaushal-nsp1'
  perimeterGuid=''
  location='eastus2euap'
}

$perimeter2 = @{
  id='/subscriptions/<SubscriptionId>/resourceGroups/ResourceGroup-1/providers/Microsoft.Network/networkSecurityPerimeters/kk-nsp4'
  perimeterGuid='bcf8bf02-8b8a-4bcb-933d-2b575d94ec8f'
  location='eastus2euap'
}

$networkSecurityPerimeters  =  @($perimeter1,$perimeter2)

New-AzNetworkSecurityPerimeterAccessRule -Name 'perimeter-ar' -SecurityPerimeterName 'testt-nsp1'  -ProfileName 't-profile2'  -ResourceGroupName 'ResourceGroup-1'  -Direction 'Inbound' -Location 'eastus2euap' -NetworkSecurityPerimeters $networkSecurityPerimeters


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAccessRule
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAccessRule
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <INetworkSecurityPerimeterIdentity>: Identity Parameter
  [AccessRuleName <String>]: The name of the NSP access rule.
  [AssociationName <String>]: The name of the NSP association.
  [Id <String>]: Resource identity path
  [NetworkSecurityPerimeterName <String>]: The name of the network security perimeter.
  [ProfileName <String>]: The name of the NSP profile.
  [ResourceGroupName <String>]: The name of the resource group.
  [SubscriptionId <String>]: The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

PARAMETER <INspAccessRule>: The NSP access rule resource
  [Id <String>]: Resource ID.
  [Location <String>]: Resource location.
  [Tag <IResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AddressPrefix <String[]>]: Inbound address prefixes (IPv4/IPv6)
  [Direction <AccessRuleDirection?>]: Direction that specifies whether the access rules is inbound/outbound.
  [FullyQualifiedDomainName <String[]>]: Outbound rules fully qualified domain name format.
  [NetworkSecurityPerimeter <IPerimeterBasedAccessRule[]>]: Inbound rule specified by the perimeter id.
    [Id <String>]: NSP id in the ARM id format.
  [Subscription <ISubscriptionId[]>]: List of subscription ids
    [Id <String>]: Subscription id in the ARM id format.

PERIMETER <IPerimeterBasedAccessRule[]>: Inbound rule specified by the perimeter id.
  [Id <String>]: NSP id in the ARM id format.

SUBSCRIPTION <ISubscriptionId[]>: List of subscription ids
  [Id <String>]: Subscription id in the ARM id format.
.Link
https://docs.microsoft.com/powershell/module/az.networksecurityperimeter/new-aznetworksecurityperimeteraccessrule
#>
function New-AzNetworkSecurityPerimeterAccessRule {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAccessRule])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Alias('AccessRuleName')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [System.String]
    # The name of the NSP access rule.
    ${Name},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Alias('SecurityPerimeterProfileName', 'NSPProfileName')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [System.String]
    # The name of the NSP profile.
    ${ProfileName},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Alias('NetworkSecurityPerimeterName', 'NSPName')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [System.String]
    # The name of the network security perimeter.
    ${SecurityPerimeterName},

    [Parameter(ParameterSetName='Create')]
    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAccessRule]
    # The NSP access rule resource
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Alias('Id')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [System.String]
    # Resource ID.
    ${AccessRuleId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [System.String[]]
    # Inbound address prefixes (IPv4/IPv6)
    ${AddressPrefix},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.AccessRuleDirection])]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.AccessRuleDirection]
    # Direction that specifies whether the access rules is inbound/outbound.
    ${Direction},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [System.String[]]
    # Outbound rules fully qualified domain name format.
    ${FullyQualifiedDomainName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IPerimeterBasedAccessRule[]]
    # Inbound rule specified by the perimeter id.
    # To construct, see NOTES section for PERIMETER properties and create a hash table.
    ${Perimeter},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.ISubscriptionId[]]
    # List of subscription ids
    # To construct, see NOTES section for SUBSCRIPTION properties and create a hash table.
    ${Subscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            Create = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeterAccessRule_Create';
            CreateExpanded = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeterAccessRule_CreateExpanded';
            CreateViaIdentityExpanded = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeterAccessRule_CreateViaIdentityExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
