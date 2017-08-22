---
external help file: Microsoft.Azure.Commands.DataFactories.dll-Help.xml
online version: 
schema: 2.0.0
---

# Set-AzureRmDataFactoryGatewayExtended

## SYNOPSIS
Sets the description or scheduled upgrade time for a gateway in Azure Data Factory.

## SYNTAX

### ByFactoryName (Default)
```
Set-AzureRmDataFactoryGatewayExtended [-DataFactoryName] <String> [-Name] <String> [[-Description] <String>]
 [[-ScheduledUpgradeTime] <String>] [-ResourceGroupName] <String> [-WhatIf] [-Confirm]
```

### ByFactoryObject
```
Set-AzureRmDataFactoryGatewayExtended [-InputObject] <PSDataFactory> [-Name] <String> [[-Description] <String>]
 [[-ScheduledUpgradeTime] <String>] [-WhatIf] [-Confirm]
```

## DESCRIPTION
{{Fill in the Description}}

## EXAMPLES

### Example 1 Sets the scheduled upgrade time
```
PS C:\> Set-AzureRmDataFactoryGatewayExtended -ResourceGroupName ADFResource -DataFactoryName TestADF -Name Gateway1 -ScheduledUpgradeTime "09:19:29"

Name                                   : Gateway1
Description                            : ddde
Version                                : 2.12.6414.2
Status                                 : Online
VersionStatus                          : UpToDate
CreateTime                             : 8/8/2017 3:33:42 AM
RegisterTime                           : 8/8/2017 3:35:04 AM
LastConnectTime                        : 8/21/2017 8:51:54 AM
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
ScheduledUpgradeTime                   : 09:19:29
ScheduledUpgradeDate                   :
IsAutoUpdateOff                        :
MultiNodeSupportEnabled                : True
DataFactoryName                        : TestADF
NodeCommunicationChannelEncryptionMode : NonEncryption
Nodes                                  : {Node1, Node2}
Id                                     : /subscriptions/41fcbc45-c594-4152-a8f1-fcbcd6452aea/resourcegroups/ADFResource
                                         /providers/Microsoft.DataFactory/datafactories/TestADF/gateways/Gateway1

```

This command sets the scheduled upgrade time to "09:19:29" for the gateway named "Gateway1" in the data factory named "TestADF".

## PARAMETERS

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Description
The description to update.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
Position: 3
Default value: None
Accept pipeline input: False
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

Required: True
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

### -ScheduledUpgradeTime
Time of automatical upgrade  to update.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## INPUTS

### Microsoft.Azure.Commands.DataFactories.Models.PSDataFactory
System.String


## OUTPUTS

### Microsoft.Azure.Commands.DataFactories.Models.PSDataFactoryGatewayExtended


## NOTES
* Keywords: azure, azurerm, arm, resource, management, manager, data, factories

## RELATED LINKS

[New-AzureRmDataFactoryGateway](./New-AzureRmDataFactoryGateway.md)

[Get-AzureRmDataFactoryGatewayExtended](./Get-AzureRmDataFactoryGatewayExtended.md)

[Set-AzureRmDataFactoryGatewayExtendedNode](./Set-AzureRmDataFactoryGatewayExtendedNode.md)

[Remove-AzureRmDataFactoryGatewayExtendedNode](./Remove-AzureRmDataFactoryGatewayExtendedNode.md)

[Set-AzureRmDataFactoryGatewayExtendedCredentials](./Set-AzureRmDataFactoryGatewayExtendedCredentials.md)
