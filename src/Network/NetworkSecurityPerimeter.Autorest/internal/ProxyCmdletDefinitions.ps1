
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
.Link
https://docs.microsoft.com/powershell/module/az.networksecurityperimeter/new-aznetworksecurityperimeteraccessrule
#>
function New-AzNetworkSecurityPerimeterAccessRule {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAccessRule])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAccessRule]
    # The NSP access rule resource
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

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

        $mapping = @{
            CreateViaIdentity = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeterAccessRule_CreateViaIdentity';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}

<#
.Synopsis
Creates or updates a NSP resource association.
.Description
Creates or updates a NSP resource association.
.Example

 $profileId = '/subscriptions/<SubscriptionId>/resourceGroups/ResourceGroup-1/providers/Microsoft.Network/networkSecurityPerimeters/nsp3/profiles/profile2'
 $privateLinkResourceId = '/subscriptions/<SubscriptionId>/resourceGroups/ResourceGroup-1/providers/Microsoft.KeyVault/vaults/rp4'
 New-AzNetworkSecurityPerimeterAssociation -Name association1 -SecurityPerimeterName nsp3 -ResourceGroupName ResourceGroup-1 -Location eastus2euap -AccessMode Learning -ProfileId $profileId -PrivateLinkResourceId $privateLinkResourceId


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAssociation
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAssociation
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

PARAMETER <INspAssociation>: The NSP resource association resource
  [Id <String>]: Resource ID.
  [Location <String>]: Resource location.
  [Tag <IResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AccessMode <AssociationAccessMode?>]: Access mode on the association.
  [PrivateLinkResourceId <String>]: Resource ID.
  [ProfileId <String>]: Resource ID.
.Link
https://docs.microsoft.com/powershell/module/az.networksecurityperimeter/new-aznetworksecurityperimeterassociation
#>
function New-AzNetworkSecurityPerimeterAssociation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAssociation])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspAssociation]
    # The NSP resource association resource
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

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

        $mapping = @{
            CreateViaIdentity = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeterAssociation_CreateViaIdentity';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}

<#
.Synopsis
Creates or updates a network profile.
.Description
Creates or updates a network profile.
.Example

 New-AzNetworkSecurityPerimeterProfile -Name profile1 -ResourceGroupName ResourceGroup-1 -SecurityPerimeterName nsp3

.Example

 New-AzNetworkSecurityPerimeterProfile -Name profile2 -ResourceGroupName ResourceGroup-1 -SecurityPerimeterName nsp3


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfile
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfile
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

PARAMETER <INspProfile>: The network security perimeter profile resource
  [Id <String>]: Resource ID.
  [Location <String>]: Resource location.
  [Tag <IResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
.Link
https://docs.microsoft.com/powershell/module/az.networksecurityperimeter/new-aznetworksecurityperimeterprofile
#>
function New-AzNetworkSecurityPerimeterProfile {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfile])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfile]
    # The network security perimeter profile resource
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

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

        $mapping = @{
            CreateViaIdentity = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeterProfile_CreateViaIdentity';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}

<#
.Synopsis
Creates or updates a Network Security Perimeter.
.Description
Creates or updates a Network Security Perimeter.
.Example

 New-AzNetworkSecurityPerimeter -ResourceGroupName ResourceGroup-1 -Name nsp1 -Location eastus2euap

.Example

 New-AzNetworkSecurityPerimeter -ResourceGroupName ResourceGroup-1 -Name nsp2 -Location eastus2euap


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INetworkSecurityPerimeter
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INetworkSecurityPerimeter
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

PARAMETER <INetworkSecurityPerimeter>: The Network Security Perimeter resource
  [Id <String>]: Resource ID.
  [Location <String>]: Resource location.
  [Tag <IResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
.Link
https://docs.microsoft.com/powershell/module/az.networksecurityperimeter/new-aznetworksecurityperimeter
#>
function New-AzNetworkSecurityPerimeter {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INetworkSecurityPerimeter])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INetworkSecurityPerimeter]
    # The Network Security Perimeter resource
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

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

        $mapping = @{
            CreateViaIdentity = 'Az.NetworkSecurityPerimeter.private\New-AzNetworkSecurityPerimeter_CreateViaIdentity';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
