using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _5_num_in_words
{
    public static class StringNumber
    {
        public static String CreateString(long number)
        {
            String result = String.Empty;
            bool isPositive = true;
            if (number < 0)
            {
                result += "Минус ";
                number = Math.Abs(number);
                isPositive = false;
            }
            else if (number == 0)
            {
                return "Ноль";
            }
            List<long> pows = GetTriplets(number);
            for (int i = pows.Count-1; i > 0; i--)
            {
                result += PowBuilder(pows[i], i) + " ";
            }
            result += HundredsBuilder(pows[0], pows[0].ToString().Length);

            if (isPositive) result = UppercaseFirst(result); //first letter to uppercase
            result = Regex.Replace(result, @" {2,}", " "); //clear excess spaces
            return result;
        }

        public static String UppercaseFirst(String str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb[0] = char.ToUpper(sb[0]);
            return sb.ToString();
        }

        private static string HundredsBuilder(long num, long numLenght)
        {
            switch (numLenght)
            {
                case (0):
                    return String.Empty;
                case (1):
                    return Units(num);
                case (2):
                    if (num < 20)
                        return Units(num);
                    else return Dozens(num / 10) + " " + Units(num % 10);
                case (3):
                    return Hundreds(num / 100) + " " + HundredsBuilder(num % 100, 2);
                default:
                    return String.Empty;
            }
        }

        private static string PowBuilder(long num, long powIndex)
        {
            String result = "";
            switch (powIndex)
            {
                case (1):
                    result += HundredsBuilder(num, num.ToString().Length) + " " + ((num != 0) ? Powers(Pows.Thousand) : String.Empty);
                    result += (num % 10) > 1 && (num % 10) < 5 ? "и" : (num % 10) == 1 ? "а" : String.Empty;
                    if (num % 100 > 10 && num % 100 < 20) result = result.Remove(result.Length - 1);
                    if ((num % 10 == 1 && num % 100 != 11) || (num % 10 == 2 && num % 100 != 12))
                        result = result.Replace("один ", "одна ").Replace("два ", "две ");
                    return result;
                case (2):
                    result = FixEnding(num, result, Pows.Million);
                    return result;
                case (3):
                    result = FixEnding(num, result, Pows.Billion);
                    return result;
                case (4):
                    result = FixEnding(num, result, Pows.Trillion);
                    return result;
                case (5):
                    result = FixEnding(num, result, Pows.Quadrillion);
                    return result;
                case (6):
                    result = FixEnding(num, result, Pows.Quintillion);
                    return result;
                default:
                    return "";
            }
        }

        private static String FixEnding(long num, String numStr, Pows pw)
        {
            numStr += HundredsBuilder(num, num.ToString().Length) + " " + ((num != 0) ? Powers(pw) : String.Empty);
            numStr += (num == 0) ? String.Empty : (((num % 10 > 1 && num % 10 < 5) && !(num % 100 > 10 && num % 100 < 20)) ? "a" : (num % 10) == 1 ? String.Empty : "ов");
            return numStr;
        }

        private static List<long> GetTriplets(long num)
        {
            List<long> pows = new List<long>();
            int numOfTriplets;
            if (num.ToString().Length % 3 == 0)
                numOfTriplets = num.ToString().Length / 3;
            else
                numOfTriplets = num.ToString().Length / 3 + 1;
            String numStr = num.ToString();
            for (int i = 0; i < numOfTriplets; i++)
            {
                if (numStr.Length >= 3)
                {
                    pows.Add(Int64.Parse(numStr.Substring(numStr.Length - 3, 3)));
                    numStr = numStr.Substring(0, numStr.Length - 3);
                }
                else pows.Add(Int64.Parse(numStr));
            }
            return pows;
        }

        private static string Units(long number)
        {
            switch (number)
            {
                case (1):
                    return "один";
                case (2):
                    return "два";
                case (3):
                    return "три";
                case (4):
                    return "четире";
                case (5):
                    return "пять";
                case (6):
                    return "шесть";
                case (7):
                    return "семь";
                case (8):
                    return "восемь";
                case (9):
                    return "девять";
                case (10):
                    return "десять";
                case (11):
                    return "одинадцать";
                case (12):
                    return "двенадцать";
                case (13):
                    return "тринадцать";
                case (14):
                    return "четырнадцать";
                case (15):
                    return "пятнадцать";
                case (16):
                    return "шестнадцать";
                case (17):
                    return "семнадцать";
                case (18):
                    return "восемнадцать";
                case (19):
                    return "девятнадцать";
                default:
                    return String.Empty;
            }
        }
        private static string Dozens(long number)
        {
            switch (number)
            {
                case (2):
                    return "двадцать";
                case (3):
                    return "тридцать";
                case (4):
                    return "сорок";
                case (5):
                    return "пятьдесят";
                case (6):
                    return "шестьдесят";
                case (7):
                    return "семьдесят";
                case (8):
                    return "восемьдесят";
                case (9):
                    return "девяносто";
                default:
                    return String.Empty;
            }
        }
        private static string Hundreds(long number)
        {
            switch (number)
            {
                case (1):
                    return "сто";
                case (2):
                    return "двести";
                case (3):
                    return "триста";
                case (4):
                    return "четыреста";
                case (5):
                    return "пятьсот";
                case (6):
                    return "шестьсот";
                case (7):
                    return "семьсот";
                case (8):
                    return "восемьсот";
                case (9):
                    return "девятьсот";
                default:
                    return String.Empty;
            }

        }
        private static string Powers(Pows pw)
        {
            switch (pw)
            {
                case (Pows.Thousand):
                    return "тысяч";
                case (Pows.Million):
                    return "миллион";
                case (Pows.Billion):
                    return "миллиард";
                case (Pows.Trillion):
                    return "триллион";
                case (Pows.Quadrillion):
                    return "квадриллион";
                case (Pows.Quintillion):
                    return "квинтиллион";
                default:
                    return String.Empty;
            }
        }
        public enum Pows
        {
            Thousand, Million, Billion, Trillion, Quadrillion, Quintillion
        }
    }
}
