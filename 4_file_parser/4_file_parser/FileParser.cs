using Instruments;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _4_file_parser
{
    public static class FileParser
    {
        public static int EntriesQty(String path, String pattern)
        {
            int count;
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    String content = sr.ReadToEnd();
                    count = new Regex(pattern, RegexOptions.IgnoreCase).Matches(content).Count;
                    return count;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static void ReplaceString(string path, string pattern, string replace)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                if (content.Contains(pattern))
                {
                    content = content.Replace(pattern, replace);
                    File.WriteAllText(path, content);
                    Output.Message("Successfully replaced\n", ConsoleColor.Green);
                }
                else
                {
                    Output.Message("No such pattern string found\n", ConsoleColor.Red);
                }
            }
        }
    }
}
