using System;

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
        public static bool IsPositive(int value)
        {
            bool result = value > 0 ? true : false;
            if (!result)
            {
                Output.Message("Value can't be negative or zero", ConsoleColor.Red);
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
        public static int ReadInt2()
        {
            Console.Write(" >> ");
            String str;
            int Number = 0;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Int32.TryParse(str, out int result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter integer number!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else Number = result;
            }
            while (!isValid);
            return Number;
        }
        public static int ReadInt2(bool sign)
        {
            Console.Write(" >> ");
            String str;
            int Number = 0;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Int32.TryParse(str, out int result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter integer number!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else
                {
                    if (sign && result <= 0)
                    {
                        Output.Message("Value can't be negative or zero", ConsoleColor.Red);
                        Console.Write(" >> ");
                        isValid = false;
                        continue;
                    }
                    else if (!sign && result >= 0)
                    {
                        Output.Message("Value can't be positive or zero", ConsoleColor.Red);
                        Console.Write(" >> ");
                        isValid = false;
                        continue;
                    }
                    else Number = result;
                }
                Number = result;
            }
            while (!isValid);
            return Number;
        }
        public static double ReadDouble2()
        {
            Console.Write(" >> ");
            String str;
            double Number = 0;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Double.TryParse(str, out double result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter double number!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else Number = result;
            }
            while (!isValid);
            return Number;
        }
        public static double ReadDouble2(bool sign)
        {
            Console.Write(" >> ");
            String str;
            double Number = 0;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Double.TryParse(str, out double result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter double number!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else
                {
                    if (sign && result <= 0)
                    {
                        Output.Message("Value can't be negative or zero", ConsoleColor.Red);
                        Console.Write(" >> ");
                        isValid = false;
                        continue;
                    }
                    else if (!sign && result >= 0)
                    {
                        Output.Message("Value can't be positive or zero", ConsoleColor.Red);
                        Console.Write(" >> ");
                        isValid = false;
                        continue;
                    }
                    else Number = result;
                }
                Number = result;
            }
            while (!isValid);
            return Number;
        }
        public static long ReadLong2()
        {
            Console.Write(" >> ");
            String str;
            long Number = 0;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Int64.TryParse(str, out long result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter long integer number!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else Number = result;
            }
            while (!isValid);
            return Number;
        }
        public static long ReadLong2(bool sign)
        {
            Console.Write(" >> ");
            String str;
            long Number = 0;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Int64.TryParse(str, out long result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter long integer number!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else
                {
                    if (sign && result <= 0)
                    {
                        Output.Message("Value can't be negative or zero", ConsoleColor.Red);
                        Console.Write(" >> ");
                        isValid = false;
                        continue;
                    }
                    else if (!sign && result >= 0)
                    {
                        Output.Message("Value can't be positive or zero", ConsoleColor.Red);
                        Console.Write(" >> ");
                        isValid = false;
                        continue;
                    }
                    else Number = result;
                }
                Number = result;
            }
            while (!isValid);
            return Number;
        }
        public static char ReadChar2()
        {
            Console.Write(" >> ");
            String str;
            char Character = ' ';
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = Char.TryParse(ClearString(str).Substring(0, 1), out char result);
                if (!isValid)
                {
                    Output.Message("Invalid input! Enter char value!", ConsoleColor.Red);
                    Console.Write(" >> ");
                }
                else Character = result;
            }
            while (!isValid);
            return Character;
        }
    }
}
