﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.DataFactories.Models;
using Microsoft.Azure.Commands.DataFactories.Properties;
using System.Globalization;
using System.Management.Automation;
using System.Security.Permissions;

namespace Microsoft.Azure.Commands.DataFactories
{
    [Cmdlet(VerbsCommon.Set, Constants.GatewayExtended, DefaultParameterSetName = ByFactoryName, SupportsShouldProcess = true), OutputType(typeof(PSDataFactoryGatewayExtended))]
    public class SetAzureDataFactoryGatewayExtendedCommand : DataFactoryBaseCmdlet
    {
        [Parameter(ParameterSetName = ByFactoryObject, Position = 0, Mandatory = true, ValueFromPipeline = true,
            HelpMessage = "The data factory object.")]
        [Alias("DataFactory")]
        [ValidateNotNull]
        public PSDataFactory InputObject { get; set; }

        [Parameter(ParameterSetName = ByFactoryName, Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The data factory name.")]
        [ValidateNotNullOrEmpty]
        public string DataFactoryName { get; set; }

        [Parameter(Position = 2, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The data factory gateway name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 3, Mandatory = false, HelpMessage = "The description to update.")]
        [ValidateNotNullOrEmpty]
        public string Description { get; set; }

        [Parameter(Position = 4, Mandatory = false, HelpMessage = "Time of automatical upgrade  to update.")]
        [ValidateNotNullOrEmpty]
        public string ScheduledUpgradeTime { get; set; }

        [EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
        public override void ExecuteCmdlet()
        {
            if (ParameterSetName == ByFactoryObject)
            {
                DataFactoryName = InputObject.DataFactoryName;
                ResourceGroupName = InputObject.ResourceGroupName;
            }

            if (string.IsNullOrEmpty(Description) && string.IsNullOrEmpty(ScheduledUpgradeTime))
            {
                throw new PSArgumentNullException("Description, ScheduledUpgradeTime");
            }

            PSDataFactoryGatewayExtended gateway = new PSDataFactoryGatewayExtended
            {
                Description = Description,
                Name = Name,
                ScheduledUpgradeTime = ScheduledUpgradeTime
            };

            if (ShouldProcess(this.Name, "Set data factory gateway"))
            {
                PSDataFactoryGatewayExtended response = DataFactoryClient.UpdateGatewayExtended(ResourceGroupName, DataFactoryName, Name, gateway);
                WriteObject(response);
            }
        }
    }
}
