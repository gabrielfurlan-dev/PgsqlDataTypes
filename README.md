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

Enums also have descriptions in case you prefer uppercase text.

## DataTypes
```markdown
## TEXT
VARCHAR
TEXT

## NUMERIC
INT
SMALLINT
BIGINT
FLOAT
BOOLEAN
DECIMAL
NUMERIC
MONEY
REAL
SMALLSERIAL
SERIAL
BIGSERIAL

## DATE
TIME
DATE
TIMESTAMP
TIMESTAMPTZ
```
