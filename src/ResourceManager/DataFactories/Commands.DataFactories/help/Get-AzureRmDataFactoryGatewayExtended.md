---
external help file: Microsoft.Azure.Commands.DataFactories.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmDataFactoryGatewayExtended

## SYNOPSIS
Gets information about logical (multi-nodes) gateways in Azure Data Factory.

## SYNTAX

### ByFactoryName (Default)
```
Get-AzureRmDataFactoryGatewayExtended [-DataFactoryName] <String> [[-Name] <String>]
 [-ResourceGroupName] <String>
```

### ByFactoryObject
```
Get-AzureRmDataFactoryGatewayExtended [-InputObject] <PSDataFactory> [[-Name] <String>]
```

## DESCRIPTION
The **Get-AzureRmDataFactoryGatewayExtended** cmdlet gets information about logical gateways in Azure Data Factory.
If you specify the name of a gateway, this cmdlet gets information about that gateway.
If you do not specify a name, this cmdlet gets information about all gateways for a data factory.

If you want to add an on-premises Microsoft SQL Server as a linked service to a data factory, you must install a gateway on your on-premises computer.

This cmdlet gets more multi-nodes gateway related information besides **Get-AzureRmDataFactoryGateway** cmdlet.

## EXAMPLES

### Example 1 Get all logical gateways in a data factory
```
PS C:\> Get-AzureRmDataFactoryGatewayExtended -ResourceGroupName ADFResource -DataFactoryName TestADF
Name                                   : Gateway1
Description                            : 
Version                                : 2.12.6414.2
Status                                 : Online
VersionStatus                          : UpToDate
CreateTime                             : 8/8/2017 3:33:42 AM
RegisterTime                           : 8/8/2017 3:35:04 AM
LastConnectTime                        : 8/21/2017 7:57:03 AM
ExpiryTime                             :
ProvisioningState                      : Succeeded
Key                                    :
IsOnPremCredentialEnabled              : True
Capabilities                           : {[serviceBusConnected, True], [httpsPortEnabled, True], [credentialInSync,
                                         True], [connectedToResourceManager, True]...}
ServiceUrls                            : {wu.frontend.clouddatahub.net, *.servicebus.windows.net}
HostServiceUrl                         : https://somemachine.com:8050/HostServiceRemote.svc/
LastUpgradeResult                      : Succeeded
LastStartUpgradeTime                   : 8/18/2017 3:31:10 AM
LastEndUpgradeTime                     : 8/18/2017 3:33:58 AM
ScheduledUpgradeStartTime              :
ScheduledUpgradeTime                   : 08:08:18
ScheduledUpgradeDate                   :
IsAutoUpdateOff                        :
MultiNodeSupportEnabled                : True
DataFactoryName                        : TestADF
NodeCommunicationChannelEncryptionMode : NonEncryption
Nodes                                  : {Node_1}
Id                                     : /subscriptions/41fcbc45-c594-4152-a8f1-fcbcd6452aea/resourcegroups/ADFResource/providers/Microsoft.DataFactory/datafactories/TestADF/gateways/Gateway1

Name                                   : Gateway2
Description                            : abc
Version                                :
Status                                 : NeedRegistration
VersionStatus                          : None
CreateTime                             : 8/8/2017 9:58:39 AM
RegisterTime                           :
LastConnectTime                        :
ExpiryTime                             :
ProvisioningState                      : Succeeded
Key                                    :
IsOnPremCredentialEnabled              : True
Capabilities                           : {}
ServiceUrls                            : {wu.frontend.clouddatahub.net, *.servicebus.windows.net}
HostServiceUrl                         :
LastUpgradeResult                      :
LastStartUpgradeTime                   :
LastEndUpgradeTime                     :
ScheduledUpgradeStartTime              :
ScheduledUpgradeTime                   : 05:08:08
ScheduledUpgradeDate                   :
IsAutoUpdateOff                        :
MultiNodeSupportEnabled                : True
DataFactoryName                        : TestADF
NodeCommunicationChannelEncryptionMode :
Nodes                                  : {}
Id                                     : /subscriptions/41fcbc45-c594-4152-a8f1-fcbcd6452aea/resourcegroups/ADFResource/providers/Microsoft.DataFactory/datafactories/TestADF/gateways/Gateway2
```

This command gets information about all logical gateways for the data factory named TestADF in the resource group named ADFResource.

### Example 2: Get a specific logical gateway in a data factory
```
PS C:\>Get-AzureRmDataFactoryGatewayExtended -ResourceGroupName ADFResource -DataFactoryName TestADF -Name Gateway1
Name                                   : Gateway1
Description                            : ddde
Version                                : 2.12.6414.2
Status                                 : Online
VersionStatus                          : UpToDate
CreateTime                             : 8/8/2017 3:33:42 AM
RegisterTime                           : 8/8/2017 3:35:04 AM
LastConnectTime                        : 8/21/2017 7:57:03 AM
ExpiryTime                             :
ProvisioningState                      : Succeeded
Key                                    :
IsOnPremCredentialEnabled              : True
Capabilities                           : {[serviceBusConnected, True], [httpsPortEnabled, True], [credentialInSync,
                                         True], [connectedToResourceManager, True]...}
ServiceUrls                            : {wu.frontend.int.clouddatahub-int.net, *.servicebus.windows.net}
HostServiceUrl                         : https://somemachine.corp.com:8050/HostServiceRemote.svc/
LastUpgradeResult                      : Succeeded
LastStartUpgradeTime                   : 8/18/2017 3:31:10 AM
LastEndUpgradeTime                     : 8/18/2017 3:33:58 AM
ScheduledUpgradeStartTime              :
ScheduledUpgradeTime                   : 08:08:18
ScheduledUpgradeDate                   :
IsAutoUpdateOff                        :
MultiNodeSupportEnabled                : True
DataFactoryName                        : TestADF
NodeCommunicationChannelEncryptionMode : NonEncryption
Nodes                                  : {Node1}
Id                                     : /subscriptions/41fcbc45-c594-4152-a8f1-fcbcd6452aea/resourcegroups/ADFResource
                                         /providers/Microsoft.DataFactory/datafactories/TestADF/gateways/Gateway1

This command gets information about the logical gateway named Gateway1 in the data factory named TestADF in the resource group named ADFResource.

## PARAMETERS

### -DataFactoryName
The data factory name.

```yaml
Type: String
Parameter Sets: ByFactoryName
Aliases: 

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -InputObject
The data factory object.

```yaml
Type: PSDataFactory
Parameter Sets: ByFactoryObject
Aliases: DataFactory

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The data factory gateway name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceGroupName
The resource group name.

```yaml
Type: String
Parameter Sets: ByFactoryName
Aliases: 

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

## INPUTS

### Microsoft.Azure.Commands.DataFactories.Models.PSDataFactory
System.String


## OUTPUTS

### System.Collections.Generic.List`1[[Microsoft.Azure.Commands.DataFactories.Models.PSDataFactoryGatewayExtended, Microsoft.Azure.Commands.DataFactories, Version=3.2.1.0, Culture=neutral, PublicKeyToken=null]]
Microsoft.Azure.Commands.DataFactories.Models.PSDataFactoryGatewayExtended


## NOTES
* Keywords: azure, azurerm, arm, resource, management, manager, data, factories

## RELATED LINKS

[New-AzureRmDataFactoryGateway](./New-AzureRmDataFactoryGateway.md)

[Remove-AzureRmDataFactoryGateway](./Remove-AzureRmDataFactoryGateway.md)

[Set-AzureRmDataFactoryGatewayExtendedNode](./Set-AzureRmDataFactoryGatewayExtendedNode.md)

[Remove-AzureRmDataFactoryGatewayExtendedNode](./Remove-AzureRmDataFactoryGatewayExtendedNode.md)

[Set-AzureRmDataFactoryGatewayExtended](./Set-AzureRmDataFactoryGatewayExtended.md)

[Set-AzureRmDataFactoryGatewayExtendedCredentials](./Set-AzureRmDataFactoryGatewayExtendedCredentials.md)

