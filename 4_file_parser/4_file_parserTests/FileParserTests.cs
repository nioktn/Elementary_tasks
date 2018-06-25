using _4_file_parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace _4_file_parserTests
{
    [TestClass()]
    public class FileParserTests
    {
        static String path = String.Empty;
        [ClassInitialize]
        public static void FileInitialize(TestContext context)
        {
            path = Path.GetFullPath(@"text.txt");
            if (!File.Exists(path)) throw new Exception("File doesn't exist");
            Debug.WriteLine(path);
        }

        [TestMethod()]
        public void EntriesQtyTest()
        {
            String pattern = "ipsum";
            int expectedResult = 5;
            int actualResult = FileParser.EntriesQty(path, pattern);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}