using System;
using Labo_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" -------- Conversiones -------");
        var conversions = new Conversions();
        Action print = () => Console.WriteLine(" ");

        conversions.IntToShort(int.TryParse(args[0], out var intToShort) ? intToShort : 0);
        print();
        conversions.IntToLong(int.TryParse(args[1], out var intToLong) ? intToLong : 0);
        print();
        conversions.FloatToInt(float.TryParse(args[2], out var floatToInt) ? floatToInt : 0f);
        print(); 
        conversions.IntToFloat(int.TryParse(args[3], out var intToFloat) ? intToFloat : 0);
        print(); 
        conversions.IntToDouble(int.TryParse(args[4], out var intToDouble) ? intToDouble : 0);
        print(); 
        conversions.BoolToString(bool.TryParse(args[5], out var boolToString) ? boolToString : false);
        print(); 
        conversions.IntToString(int.TryParse(args[6], out var intToString) ? intToString : 0);
        print(); 
        conversions.DateTimeToObject(DateTime.TryParse(args[7], out var boxingValue) ? boxingValue : default);
        print();
        DateTime.TryParse(args[8], out DateTime parsedDateTime);
        object objectToUnbox = parsedDateTime;
        conversions.ObjectToDateTime(objectToUnbox);

         
    }
}
// dotnet run 123 456 789,12 12345 67890 true 42 "2025-01-09T10:30:00" "2025-01-09T15:45:00"