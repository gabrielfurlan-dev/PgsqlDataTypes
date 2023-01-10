# PgsqlDataTypes
A POWERFUL Enum tool to make PostgreSQL developers life easier. 

## Use Guide
Just need to import the Enum in your workspace:
```csharp
using PgsqlDataTypes;
```

Useful when you have to use Entity Framework and have to set the data types when mapping your models.
Example: 
```csharp
 builder.Property(x => x.HumorStatus)
                    .IsRequired()
                    .HasColumnName("ColumnName")
                    .HasColumnType(EPgsqlDataTypes.BigInt.ToString()) //PostgreSQL Data Type
                    .HasMaxLength(1);
```
