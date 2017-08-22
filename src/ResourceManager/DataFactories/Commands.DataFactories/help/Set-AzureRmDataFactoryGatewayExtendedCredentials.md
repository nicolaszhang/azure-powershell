---
external help file: Microsoft.Azure.Commands.DataFactories.dll-Help.xml
online version: 
schema: 2.0.0
---

# Set-AzureRmDataFactoryGatewayExtendedCredentials

## SYNOPSIS
Sets credentials to synced state for specified gateway in Azure Data Factory.

## SYNTAX

### ByFactoryName (Default)
```
Set-AzureRmDataFactoryGatewayExtendedCredentials [-DataFactoryName] <String> [-Name] <String> [-Force]
 [-ResourceGroupName] <String> [-WhatIf] [-Confirm]
```

### ByFactoryObject
```
Set-AzureRmDataFactoryGatewayExtendedCredentials [-InputObject] <PSDataFactory> [-Name] <String> [-Force]
 [-WhatIf] [-Confirm]
```

## DESCRIPTION
The **Set-AzureRmDataFactoryGatewayExtendedCredentials** cmdlet sets credentials to synced state for specified gateway in Azure Data Factory.

## EXAMPLES

### Example 1 Force sync credentials of a gateway
```
PS C:\> Set-AzureRmDataFactoryGatewayExtendedCredentials -ResourceGroupName ADFResource -DataFactoryName TestADF -Name Gateway1

Sync credentials of the gateway 'Gateway1' in the data factory 'TestADF'.
There might be credential loss with this command, are you sure you want to force sync credentials of the gateway
'Gateway1' in the data factory 'TestADF'?
[Y] Yes  [N] No  [S] Suspend  [?] Help (default is "Y"): y
True
```

This command sets the credentials to synced state for gateway named Gateway1 in the data factory named TestADF.

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

### -Force
Don't ask for confirmation.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: 

Required: False
Position: Named
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

### System.Boolean


## NOTES
* Keywords: azure, azurerm, arm, resource, management, manager, data, factories

## RELATED LINKS

[New-AzureRmDataFactoryGateway](./New-AzureRmDataFactoryGateway.md)

[Get-AzureRmDataFactoryGatewayExtended](./Get-AzureRmDataFactoryGatewayExtended.md)

[Set-AzureRmDataFactoryGatewayExtendedNode](./Set-AzureRmDataFactoryGatewayExtendedNode.md)

[Remove-AzureRmDataFactoryGatewayExtendedNode](./Remove-AzureRmDataFactoryGatewayExtendedNode.md)

[Set-AzureRmDataFactoryGatewayExtended](./Set-AzureRmDataFactoryGatewayExtended.md)