using System;

namespace Labo_1
{
    internal class Conversions
    {
        public short IntToShort(int value)
        {
            if (value < short.MinValue || value > short.MaxValue)
            {
                Console.WriteLine($"Error to convert {value} to short. Value is out of range.");
                return 0;
            }

            short shortValue = (short)value;
            Console.WriteLine($"{value} -> {shortValue} \n{value.GetType()} -> {shortValue.GetType()}");
            return shortValue;
        }

        public long IntToLong(int value)
        {
            long longValue = value;
            Console.WriteLine($"{value} -> {longValue} \n{value.GetType()} -> {longValue.GetType()}");
            return longValue;
        }

        public int FloatToInt(float value)
        {
            if (value < int.MinValue || value > int.MaxValue)
            {
                Console.WriteLine($"Error to convert {value:F3} to int. Value is out of range.");
                return 0;
            }

            int intValue = (int)value;
            Console.WriteLine($"{value:F2} -> {intValue} \n{value.GetType()} -> {intValue.GetType()}");
            return intValue;
        }

        public float IntToFloat(int value)
        {
            float floatValue = value;
            Console.WriteLine($"{value} -> {floatValue:F2} \n{value.GetType()} -> {floatValue.GetType()}");
            return floatValue;
        }

        public double IntToDouble(int value)
        {
            double doubleValue = value;
            Console.WriteLine($"{value} -> {doubleValue:F3} \n{value.GetType()} -> {doubleValue.GetType()}");
            return doubleValue;
        }

        public string BoolToString(bool value)
        {
            string strValue = value.ToString();
            Console.WriteLine($"{value} -> {strValue} \n{value.GetType()} -> {strValue.GetType()}");
            return strValue;
        }

        public string IntToString(int value)
        {
            string strValue = value.ToString();
            Console.WriteLine($"{value} -> {strValue} \n{value.GetType()} -> {strValue.GetType()}");
            return strValue;
        }

        public object DateTimeToObject(DateTime value)
        {
            object boxedValue = value;
            Console.WriteLine($"Boxing (DateTime to object): {value} -> {boxedValue} \nDateTime -> object");
            return boxedValue;
        }

        public DateTime ObjectToDateTime(object value)
        {
            DateTime unboxedValue = (DateTime)value;
            Console.WriteLine($"Unboxing (object to DateTime): {value} -> {unboxedValue} \nobject -> DateTime");
            return unboxedValue;
        }
    }
}
