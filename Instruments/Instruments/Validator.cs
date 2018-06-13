using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public static class Validator
    {
        public static string ReadString()
        {
            return Console.ReadLine();
        }
        public static string ClearString(String str)
        {
            return str.Replace(" ", String.Empty).Replace("\t", String.Empty);
        }
        public static int ReadInt()
        {
            String temp = Console.ReadLine();
            temp = temp.Trim().Replace(" ", String.Empty).Replace("\t", String.Empty);
            int result;
            try
            {
                result = Int32.Parse(temp);
            }
            catch
            {
                throw;
            }
            return result;
        }
        public static long ReadLong()
        {
            String temp = Console.ReadLine();
            temp = temp.Trim().Replace(" ", String.Empty).Replace("\t", String.Empty);
            long result;
            try
            {
                result = long.Parse(temp);
            }
            catch
            {
                throw;
            }
            return result;
        }
        public static double ReadDouble()
        {
            String temp = Console.ReadLine();
            temp = temp.Trim().Replace(" ", String.Empty).Replace("\t", String.Empty);
            double result;
            try
            {
                result = Double.Parse(temp);
            }
            catch
            {
                throw;
            }
            return result;
        }
        public static char ReadChar()
        {
            String enteredString = Console.ReadLine();
            char result;
            try
            {
                result = Char.Parse(enteredString.Replace(" ", String.Empty).Replace("\t", String.Empty).Substring(0, 1));
            }
            catch
            {
                throw;
            }
            return result;
        }
        public static bool IsPositive(int value)
        {
            bool result = value > 0 ? true : false;
            if (!result)
            {
                throw new Exception("Value can`t be negative or zero");
            }
            return result;
        }
        public static bool IsPositive(double value)
        {
            bool result = value > 0 ? true : false;
            if (!result)
            {
                throw new Exception("Value can`t be negative or zero");
            }
            return result;
        }

        public static double ReadFraction()
        {
            String fractionStr = Validator.ReadString();
            String[] splitArray = fractionStr.Split('/');
            double numerator = double.Parse(splitArray[0]);
            double nominator = double.Parse(splitArray[1]);
            return numerator / nominator;
        }
    }
}
