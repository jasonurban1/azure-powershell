
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
Lists entities from applications or get entity from applications by key
.Description
Lists entities from applications or get entity from applications by key
.Example
Get-AzADApplication -DisplayName $appname
.Example
Get-AzADApplication -First 10
.Example
Get-AzADApplication -DisplayNameStartsWith $prefix
.Example
Get-AzADapplication -ObjectId $id -Select Tags -AppendSelected
.Example
Get-AzADapplication -OwnedApplication

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphApplication
.Link
https://docs.microsoft.com/powershell/module/az.resources/get-azadapplication
#>
function Get-AzADApplication {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphApplication])]
[CmdletBinding(DefaultParameterSetName='EmptyParameterSet', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='ApplicationObjectIdParameterSet', Mandatory)]
    [Alias('Id')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [System.String]
    # key: id of application
    ${ObjectId},

    [Parameter(ParameterSetName='OwnedApplicationParameterSet', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [System.Management.Automation.SwitchParameter]
    # get owned application
    ${OwnedApplication},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String[]]
    # Select properties to be returned
    ${Select},

    [Parameter(ParameterSetName='EmptyParameterSet')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String]
    # Filter items by property values
    ${Filter},

    [Parameter(ParameterSetName='EmptyParameterSet')]
    [Parameter(ParameterSetName='OwnedApplicationParameterSet')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String[]]
    # Order items by property values
    ${Orderby},

    [Parameter(ParameterSetName='EmptyParameterSet')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String]
    # Search items by search phrases
    ${Search},

    [Parameter(ParameterSetName='SearchStringParameterSet', Mandatory)]
    [Alias('DisplayNameStartsWith')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String]
    # application display name starts with
    ${DisplayNameStartWith},

    [Parameter(ParameterSetName='DisplayNameParameterSet', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String]
    # application display name
    ${DisplayName},

    [Parameter(ParameterSetName='ApplicationIdParameterSet', Mandatory)]
    [Alias('AppId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.Guid]
    # application id
    ${ApplicationId},

    [Parameter(ParameterSetName='ApplicationIdentifierUriParameterSet', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Query')]
    [System.String]
    # application identifier uri
    ${IdentifierUri},

    [Parameter(ParameterSetName='EmptyParameterSet')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Header')]
    [System.String]
    # Indicates the requested consistency level.
    # Documentation URL: https://developer.microsoft.com/en-us/office/blogs/microsoft-graph-advanced-queries-for-directory-objects-are-now-generally-available/
    ${ConsistencyLevel},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.UInt64]
    # Gets only the first 'n' objects.
    ${First},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.UInt64]
    # Ignores the first 'n' objects and then gets the remaining objects.
    ${Skip},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Append properties selected with default properties when this switch is on, only works with parameter '-Select'.
    ${AppendSelected},

    [Parameter()]
    [Alias('AzContext', 'AzureRmContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
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
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Runspace.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            EmptyParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
            ApplicationObjectIdParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
            SearchStringParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
            DisplayNameParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
            ApplicationIdParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
            ApplicationIdentifierUriParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
            OwnedApplicationParameterSet = 'Az.MSGraph.custom\Get-AzADApplication';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
