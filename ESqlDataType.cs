using System.ComponentModel;

namespace PgsqlDataTypes
{
    public enum EPgsqlDataTypes
    {
        //TEXT
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=--=-=-=-=-=-=-=-=-=-=
        [Description("VARCHAR")]
        Varchar,

        [Description("TEXT")]
        Text,

        //NUMERIC
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=--=-=-=-=-=-=-=-=-=-=
        [Description("INT")]
        Int, //4 bytes	typical choice for integer	-2147483648 to +2147483647

        [Description("SMALLINT")]
        SmallInt, //2 bytes	small-range integer	-32768 to +32767

        [Description("BIGINT")]
        BigInt, //8 bytes	large-range integer	-9223372036854775808 to 9223372036854775807

        [Description("FLOAT")]
        Float,

        [Description("BOOLEAN")]
        Boolean, //1 byte	state of true or false

        [Description("DECIMAL")]
        Decimal, //	Up to 131072 digits before the decimal // 

        [Description("NUMERIC")]
        Numeric, //Up to 131072 digits before the decimal, 

        [Description("MONEY")]
        Money,  //8 bytes	currency amount	-92233720368547758.08 to +92233720368547758.07
        
        [Description("REAL")]
        Real, //4 bytes	variable-precision,inexact	6 decimal digits precision

        [Description("SMALLSERIAL")]
        Smallserial, //2 bytes	small autoincrementing integer	1 to 32767

        [Description("SERIAL")]
        Serial, //4 bytes	autoincrementing integer	1 to 2147483647

        [Description("BIGSERIAL")]
        Bigserial,

        //DATE
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=--=-=-=-=-=-=-=-=-=-=
        [Description("TIME")]
        Time,

        [Description("DATE")]
        Date, //4 bytes	date (no time of day)	4713 BC	5874897 AD

        [Description("TIMESTAMP")]
        Timestamp, //Storages Date and Time

        [Description("TIMESTAMPTZ")]
        Timestamptz, //Storages also timeszone
    }
}