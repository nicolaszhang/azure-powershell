---
external help file: Microsoft.Azure.Commands.DataFactories.dll-Help.xml
online version: 
schema: 2.0.0
---

# Remove-AzureRmDataFactoryGatewayExtendedNode

## SYNOPSIS
Removes specified node from the gateway in the Azure Data Factory.

## SYNTAX

### ByFactoryName (Default)
```
Remove-AzureRmDataFactoryGatewayExtendedNode [-DataFactoryName] <String> [-GatewayName] <String>
 [-Name] <String> [-Force] [-ResourceGroupName] <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByFactoryObject
```
Remove-AzureRmDataFactoryGatewayExtendedNode [-InputObject] <PSDataFactory> [-GatewayName] <String>
 [-Name] <String> [-Force] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The **Remove-AzureRmDataFactoryGatewayExtendedNode** cmdlet removes the specified node from the gateway in the Azure Data Factory.

## EXAMPLES

### Example 1
```
PS C:\>  Remove-AzureRmDataF
actoryGatewayExtendedNode -ResourceGroupName ADFResource -DataFactoryName TestADF -GatewayName Gateway1 -Name Node1

Removing the node 'Node1' of gateway 'Gateway1' in the data factory 'TestADF'.
Are you sure you want to remove the node 'Node1' of gateway 'Gateway1' in the data factory
'TestADF'?
[Y] Yes  [N] No  [S] Suspend  [?] Help (default is "Y"): y
True
```

This command removes the node named "Node1" from the gateway named "Gateway1" in the data factory named "TestADF".

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

### -GatewayName
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
The data factory gateway node name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: True
Position: 3
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

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

[Set-AzureRmDataFactoryGatewayExtended](./Set-AzureRmDataFactoryGatewayExtended.md)

[Set-AzureRmDataFactoryGatewayExtendedNode](./Set-AzureRmDataFactoryGatewayExtendedNode.md)

[Set-AzureRmDataFactoryGatewayExtendedCredentials](./Set-AzureRmDataFactoryGatewayExtendedCredentials.md)