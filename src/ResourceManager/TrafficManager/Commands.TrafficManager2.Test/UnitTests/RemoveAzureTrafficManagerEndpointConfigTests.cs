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

namespace Microsoft.Azure.Commands.TrafficManager.Test.UnitTests
{
    using System.Collections.Generic;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.TrafficManager;
    using Microsoft.Azure.Commands.TrafficManager.Models;
    using Microsoft.WindowsAzure.Commands.ScenarioTest;
    using Xunit;

    public class RemoveAzureTrafficManagerEndpointConfigTests
    {
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void RemoveAzureTrafficManagerEndpointConfig_ThrowsExceptionWhenNullEndpoints()
        {
            var cmdlet = new RemoveAzureTrafficManagerEndpointConfig
            {
                TrafficManagerProfile = new TrafficManagerProfile(),
                EndpointName = "Name"
            };

            var exception = Assert.Throws<PSArgumentException>(() => cmdlet.ExecuteCmdlet());
            Assert.Equal("The profile provided does not have any endpoints with name 'Name'.", exception.Message);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void RemoveAzureTrafficManagerEndpointConfig_ThrowsExceptionWhenNoEndpointWithName()
        {
            var cmdlet = new RemoveAzureTrafficManagerEndpointConfig
            {
                TrafficManagerProfile = new TrafficManagerProfile
                {
                    Endpoints = new List<TrafficManagerEndpoint>
                    {
                        new TrafficManagerEndpoint
                        {
                            Name = "My external endpoint"
                        }
                    }
                },
                EndpointName = "Name"
            };

            var exception = Assert.Throws<PSArgumentException>(() => cmdlet.ExecuteCmdlet());
            Assert.Equal("The profile provided does not have any endpoints with name 'Name'.", exception.Message);
        }
    }
}
