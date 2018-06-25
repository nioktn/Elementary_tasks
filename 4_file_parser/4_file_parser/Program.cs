using Instruments;
using System;
using System.IO;

namespace _4_file_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"..\..\assets\";
            Console.WriteLine("Enter name of the file: \n");
            String filePath = dirPath + Validator.ReadString();
            if (File.Exists(filePath))
            {
                for (; ; )
                {
                    int option;
                    Console.Write("Choose programm mode:\n 1. Entries search\n 2. Replace string\n 0. Exit\n");
                    option = Validator.ReadInt2();
                    switch (option)
                    {
                        case (1):
                            String search;
                            Console.Write(" \nEntries search:\nEnter your string for search:\n >> ");
                            search = Validator.ReadString();
                            Output.Message(search.Equals(String.Empty) ? "Search string shouldn't be empty\n" : 
                                String.Format("There are {0} entries of your string\n",
                                FileParser.EntriesQty(filePath, search)), ConsoleColor.Yellow);
                            break;
                        case (2):
                            Console.Write("Enter pattern string: \n >> ");
                            string pattern = Validator.ReadString();
                            Console.Write("Enter replace string: \n >> ");
                            string replace = Validator.ReadString();
                            if (pattern.Equals(String.Empty)) Output.Message("Pattern string couldn't be empty\n", ConsoleColor.Red);
                            else FileParser.ReplaceString(filePath, pattern, replace);
                            break;
                        case (0):
                            Environment.Exit(0);
                            break;
                        default:
                            Output.Message("There is no mode like this.\n", ConsoleColor.Red);
                            continue;
                    }
                }
            }
            else
            {
                Output.Message("File is not found", ConsoleColor.Red);
                Console.Read();
            }
        }
    }
}
