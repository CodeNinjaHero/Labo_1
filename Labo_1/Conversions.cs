using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1
{
    internal class Conversions
    {
        public short IntToShort(int value)
        {
            short shortValue;

            if (value < short.MinValue || value > short.MaxValue)
            {
                Console.WriteLine($"Error to convert {value} to short. Value is out of range.");
                return 0; 
            }

            shortValue = (short)value;
            Console.WriteLine($"{value.GetType()} -> {shortValue.GetType()}");

            return shortValue;
        }


        public long IntToLong(int value)
        {
            long longValue = value;
            Console.WriteLine($"{value.GetType()} -> {longValue.GetType()}");

            return longValue;
        }

        public int FloatToInt(float value)
        {
            if (value < int.MinValue || value > int.MaxValue)
            {
                Console.WriteLine($"Error to convert {value} to int. Value is out of range.");
                return 0;
            }
            int intValue = (int)value;
            Console.WriteLine($"{value.GetType()} -> {intValue.GetType()}");

            return intValue;
        }

        public float IntToFloat(int value)
        {
            float floatValue = (float)value;
            Console.WriteLine($"{value.GetType()} -> {floatValue.GetType()}");
            return floatValue;
        }

        public double IntToDouble(int value)
        {
            double doubleValue = value;
            Console.WriteLine($"{value.GetType()} -> {doubleValue.GetType()}");

            return doubleValue;
        }
        
        public string BoolToString(bool value)
        {
            var str = value.ToString();
            Console.WriteLine($"{value.GetType()} -> {str.GetType()}");

            return str;
        }
        
        public string IntToString(int value)
        {
            string str = value.ToString();
            Console.WriteLine($"{value.GetType()} -> {str.GetType()}");

            return value.ToString();
        }

        public object DateTimeToObject(DateTime value)
        {
            object boxedValue = value;
            Console.WriteLine($"Boxing (DateTime a object): DateTime -> object");
            return boxedValue;
        }

        public DateTime ObjectToDateTime(object value)
        {
            DateTime unboxedValue = (DateTime)value;
            Console.WriteLine($"Unboxing (object a DateTime): object -> DateTime");
            return unboxedValue;
        }



    }
}
