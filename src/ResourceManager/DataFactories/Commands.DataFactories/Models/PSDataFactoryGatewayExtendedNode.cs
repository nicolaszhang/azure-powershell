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

namespace Microsoft.Azure.Commands.DataFactories.Models
{
    public class PSDataFactoryGatewayExtendedNode
    {
        private readonly GatewayNode _node;

        public PSDataFactoryGatewayExtendedNode()
        {
            _node = new GatewayNode();
        }

        public PSDataFactoryGatewayExtendedNode(GatewayNode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            _node = node;
        }

        public string Name
        {
            get { return _node.NodeName; }
            set { _node.NodeName = value; }
        }

        public string Description
        {
            get { return _node.Description; }
            set { _node.Description = value; }
        }

        public bool? IsActiveDispatcher
        {
            get { return _node.IsActiveDispatcher; }
        }

        public string Version
        {
            get { return _node.Version; }
        }

        public string Status
        {
            get { return _node.Status; }
        }

        public string VersionStatus
        {
            get { return _node.VersionStatus; }
        }

        public DateTime? CreateTime
        {
            get { return _node.CreateTime; }
        }

        public DateTime? RegisterTime
        {
            get { return _node.RegisterTime; }
        }

        public DateTime? LastConnectTime
        {
            get { return _node.LastConnectTime; }
        }

        public DateTime? ExpiryTime
        {
            get { return _node.ExpiryTime; }
        }

        public string ProvisioningState
        {
            get { return _node == null ? string.Empty : _node.ProvisioningState; }
        }

        public IDictionary<string, string> Capabilities
        {
            get { return _node.Capabilities; }
        }

        public string HostServiceUrl
        {
            get { return _node.HostServiceUri; }
        }

        public string LastUpgradeResult
        {
            get { return _node.LastUpgradeResult; }
        }

        public DateTime? LastStartUpgradeTime
        {
            get { return _node.LastStartUpgradeTime; }
        }

        public DateTime? LastEndUpgradeTime
        {
            get { return _node.LastEndUpgradeTime; }
        }

        public string MaxConcurrentJobs
        {
            get { return _node.MaxConcurrentJobs; }
        }

        public string LimitConcurrentJobs
        {
            get { return _node.LimitConcurrentJobs; }
        }

        public string RunningConcurrentJobs
        {
            get { return _node.RunningConcurrentJobs; }
        }

        public string Network
        {
            get { return _node.Network; }
        }

        public string CpuUtilization
        {
            get { return _node.CpuUtilization; }
        }

        public string AvailableMemory
        {
            get { return _node.AvailableMemory; }
        }

        public GatewayNode ToGatewayNode()
        {
            return _node;
        }
    }
}
