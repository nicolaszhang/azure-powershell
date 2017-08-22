// ----------------------------------------------------------------------------------
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation;
using System.Security.Permissions;

namespace Microsoft.Azure.Commands.DataFactories
{
    [Cmdlet(VerbsCommon.Get, Constants.GatewayExtended, DefaultParameterSetName = ByFactoryName), OutputType(typeof(List<PSDataFactoryGatewayExtended>), typeof(PSDataFactoryGatewayExtended))]
    public class GetAzureDataFactoryGatewayExtendedCommand : DataFactoryBaseCmdlet
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

        [Parameter(Position = 2, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The data factory gateway name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
        public override void ExecuteCmdlet()
        {
            if (ParameterSetName == ByFactoryObject)
            {
                DataFactoryName = InputObject.DataFactoryName;
                ResourceGroupName = InputObject.ResourceGroupName;
            }

            if (String.IsNullOrWhiteSpace(Name))
            {
                IEnumerable<PSDataFactoryGatewayExtended> gateways = DataFactoryClient.ListGatewaysExtended(ResourceGroupName, DataFactoryName);
                WriteObject(gateways, true);
            }
            else
            {
                PSDataFactoryGatewayExtended gateway = DataFactoryClient.GetGatewayExtended(ResourceGroupName, DataFactoryName, Name);
                WriteObject(gateway);
            }
        }
    }
}