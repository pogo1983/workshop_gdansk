using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Collections;

namespace CSharp_Basics
{
    [TestFixture]
    public class DataDrivenTestExample
    {

        [TestCaseSource(typeof(TestData), "Numbers")]
        public void TestDrivenData(IDictionary<string, string> parameters)
        {
           int numberOne= int.Parse(parameters["numberOne"]);
           int numberTwo = int.Parse(parameters["numberTwo"]);
           int expectedResult = int.Parse(parameters["result"]);

            int actualResult = numberOne + numberTwo;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public static class TestData
    {

        public static IEnumerable Numbers()
        {
            var path = TestContext.CurrentContext.TestDirectory;
            path = string.Format(CultureInfo.CurrentCulture, "{0}{1}", path, @"\TestData\numbers.csv");
            return ReadDataDriveFileCsv(path, new[] { "numberOne", "numberTwo", "result" }, "Numbers");
        }


        public static IEnumerable<TestCaseData> ReadDataDriveFileCsv(string file, string[] diffParam, string testName)
        {
            using (var fs = File.OpenRead(file))
            using (var sr = new StreamReader(fs))
            {
                string line = string.Empty;
                line = sr.ReadLine();
                string[] columns = line.Split(
                                new char[] { ';' },
                                StringSplitOptions.None);

                var columnsNumber = columns.Length;
                var row = 1;

                while (line != null)
                {
                    string testCaseName;
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        var testParams = new Dictionary<string, string>();

                        string[] split = line.Split(
                            new char[] { ';' },
                            StringSplitOptions.None);

                        for (int i = 0; i < columnsNumber; i++)
                        {
                            testParams.Add(columns[i], split[i]);
                        }

                        try
                        {
                            testCaseName = TestCaseName(diffParam, testParams, testName);
                        }
                        catch (FileNotFoundException e)
                        {
                            throw new FileNotFoundException(
                            string.Format(
                                       " Exception while reading Csv Data Driven file\n searched key '{0}' not found \n for test {1} in file '{2}' at row {3}",
                                        e.Message,
                                        testName,
                                        file,
                                        row));
                        }

                        row = row + 1;

                        var data = new TestCaseData(testParams);
                        data.SetName(testCaseName);
                        yield return data;
                    }
                }
            }
        }




        private static string TestCaseName(string[] diffParam, Dictionary<string, string> testParams, string testCaseName)
        {
            if (diffParam != null && diffParam.Any())
            {
                foreach (var p in diffParam)
                {
                    string keyValue;
                    bool keyFlag = testParams.TryGetValue(p, out keyValue);

                    if (keyFlag)
                    {
                        if (!string.IsNullOrEmpty(keyValue))
                        {
                            testCaseName += "_" + Regex.Replace(keyValue, "[^0-9a-zA-Z]+", "_");
                        }
                    }
                    else
                    {
                        throw new FileLoadException(p);
                    }
                }
            }

            return testCaseName;
        }
    }
}
