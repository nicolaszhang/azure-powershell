---
external help file: Microsoft.Azure.Commands.DataFactories.dll-Help.xml
online version: 
schema: 2.0.0
---

# Set-AzureRmDataFactoryGatewayExtendedNode

## SYNOPSIS
Sets the limit of concurrent jobs for the specified gateway node in Azure Data Factory.

## SYNTAX

### ByFactoryName (Default)
```
Set-AzureRmDataFactoryGatewayExtendedNode [-DataFactoryName] <String> [-GatewayName] <String> [-Name] <String>
 [-LimitConcurrentJobs] <Int32> [-ResourceGroupName] <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByFactoryObject
```
Set-AzureRmDataFactoryGatewayExtendedNode [-InputObject] <PSDataFactory> [-GatewayName] <String>
 [-Name] <String> [-LimitConcurrentJobs] <Int32> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The **Set-AzureRmDataFactoryGatewayExtendedNode** cmdlet sets the limit of concurrent jobs for the specified gateway node in Azure Data Factory.

## EXAMPLES

### Example 1
```
PS C:\> Set-AzureRmDataFactoryGatewayExtendedNode -ResourceGroupName ADFResource -DataFactoryName TestADF -GatewayName Gateway1 -Name Node1 -LimitConcurrentJobs 19
True
```

This command sets the limit of concurrent jobs to 19 for Node1 of the logical gateway named Gateway1 in the data factory named TestADF in the resource group named ADFResource.

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

### -LimitConcurrentJobs
The limit concurrent jobs to set.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases: 

Required: True
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the gateway node to update.

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

[Remove-AzureRmDataFactoryGatewayExtendedNode](./Remove-AzureRmDataFactoryGatewayExtendedNode.md)

[Set-AzureRmDataFactoryGatewayExtended](./Set-AzureRmDataFactoryGatewayExtended.md)

[Set-AzureRmDataFactoryGatewayExtendedCredentials](./Set-AzureRmDataFactoryGatewayExtendedCredentials.md)
