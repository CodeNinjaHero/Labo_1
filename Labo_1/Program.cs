using System;
using Labo_1;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- Conversiones -----");
        var conversions = new Conversions();

        int.TryParse(args[0], out int intToShort);
        conversions.IntToShort(intToShort);

        int.TryParse(args[1], out int intToLong);
        conversions.IntToLong(intToLong);

        float.TryParse(args[2], out float floatToInt);
        conversions.FloatToInt(floatToInt);

        int.TryParse(args[3], out int intToFloat);
        conversions.IntToFloat(intToFloat);

        int.TryParse(args[4], out int intToDouble);
        conversions.IntToDouble(intToDouble);

        bool boolToString = bool.Parse(args[5]);
        conversions.BoolToString(boolToString);

        int intToString = int.Parse(args[6]);
        conversions.IntToString(intToString);

        DateTime.TryParse(args[7], out DateTime boxingValue);
        object boxed = conversions.DateTimeToObject(boxingValue);

        DateTime.TryParse(args[8], out DateTime parsedDateTime);
        object objectToUnbox = parsedDateTime;
        conversions.ObjectToDateTime(objectToUnbox);
        
       

    }
    
}
//dotnet run 123 456 789.12 12345 67890 true 42 "2025-01-09T10:30:00" "2025-01-09T15:45:00"
