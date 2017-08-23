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

using Microsoft.Azure.Management.DataFactories.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.DataFactories.Models
{
    public class PSDataFactoryGatewayExtended
    {
        private readonly GatewayExtended _gateway;

        public PSDataFactoryGatewayExtended()
        {
            _gateway = new GatewayExtended { Properties = new GatewayExtendedProperties() };
        }

        public PSDataFactoryGatewayExtended(GatewayExtended gateway)
        {
            if (gateway == null)
            {
                throw new ArgumentNullException("gateway");
            }

            _gateway = gateway;
        }

        public string Name
        {
            get { return _gateway.Name; }
            set { _gateway.Name = value; }
        }

        public string Description
        {
            get { return _gateway.Properties.Description; }
            set { _gateway.Properties.Description = value; }
        }

        public string Version
        {
            get { return _gateway.Properties.Version; }            
        }

        public string Status
        {
            get { return _gateway.Properties.Status; }
        }

        public string VersionStatus
        {
            get { return _gateway.Properties.VersionStatus; }
        }

        public DateTime? CreateTime
        {
            get { return _gateway.Properties.CreateTime; }
        }

        public DateTime? RegisterTime
        {
            get { return _gateway.Properties.RegisterTime; }
        }

        public DateTime? LastConnectTime
        {
            get { return _gateway.Properties.LastConnectTime; }
        }

        public DateTime? ExpiryTime
        {
            get { return _gateway.Properties.ExpiryTime; }
        }

        public string ProvisioningState
        {
            get { return _gateway.Properties == null ? string.Empty : _gateway.Properties.ProvisioningState; }
        }

        public string Key
        {
            get { return _gateway.Properties.Key; }
        }

        public bool? IsOnPremCredentialEnabled
        {
            get { return _gateway.Properties.IsOnPremCredentialEnabled; }
        }

        public IDictionary<string, string> Capabilities
        {
            get { return _gateway.Properties.Capabilities; }
        }

        public IList<string> ServiceUrls
        {
            get { return _gateway.Properties.ServiceUrls; }
        }

        public string HostServiceUrl
        {
            get { return _gateway.Properties.HostServiceUri; }
        }

        public string LastUpgradeResult
        {
            get { return _gateway.Properties.LastUpgradeResult; }
        }

        public DateTime? LastStartUpgradeTime
        {
            get { return _gateway.Properties.LastStartUpgradeTime; }
        }

        public DateTime? LastEndUpgradeTime
        {
            get { return _gateway.Properties.LastEndUpgradeTime; }
        }

        public DateTime? ScheduledUpgradeStartTime
        {
            get { return _gateway.Properties.ScheduledUpgradeStartTime; }
        }

        public string ScheduledUpgradeTime
        {
            get { return _gateway.Properties.ScheduledUpgradeTime; }
            set { _gateway.Properties.ScheduledUpgradeTime = value; }
        }

        public DateTime? ScheduledUpgradeDate
        {
            get { return _gateway.Properties.ScheduledUpgradeDate; }
        }

        public bool? IsAutoUpdateOff
        {
            get { return _gateway.Properties.IsAutoUpdateOff; }
        }

        public bool MultiNodeSupportEnabled
        {
            get { return _gateway.Properties.MultiNodeSupportEnabled; }
            set { _gateway.Properties.MultiNodeSupportEnabled = value; }
        }

        public string DataFactoryName
        {
            get { return _gateway.Properties.DataFactoryName; }
        }

        public string NodeCommunicationChannelEncryptionMode
        {
            get { return _gateway.Properties.NodeCommunicationChannelEncryptionMode; }
        }

        public IList<PSDataFactoryGatewayExtendedNode> Nodes
        {
            get { return _gateway.Properties.Nodes == null ? new List<PSDataFactoryGatewayExtendedNode>() : _gateway.Properties.Nodes.Select(n => new PSDataFactoryGatewayExtendedNode(n)).ToList(); }
        }

        public string Id
        {
            get { return _gateway.Id; }
        }

        public GatewayExtended ToGatewayDefinition()
        {
            return _gateway;
        }        
    }
}
