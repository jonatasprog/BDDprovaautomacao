using RelevantCodes.ExtentReports;
using System;
using System.IO;

namespace BDDprovaautomacao.utils
{
    public static class Report
    {
        private static string DEFAULT_PATH = Directory.GetParent(Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName).Parent.FullName + "\\Reports\\";

        private static string path;
        private static string reportPath { get; set; }
        public static string screenshotsPath { get; set; }

        private static ExtentReports extent;
        private static ExtentTest test;

        private static int count = 1;

        public static String GetPath()
        {
            return (path == null) ? DEFAULT_PATH : path;
        }

        private static String GenerateTestName(String testSuiteName)
        {
            return reportPath + "Report_" + testSuiteName + "_" + count++ + ".html";
        }

        public static void Start(String testSuiteName, bool createDirectory)
        {
            if (createDirectory)
            {
                CreateDirectory(testSuiteName);
                CreateScreenshotDirectory();
                extent = new ExtentReports(GenerateTestName(testSuiteName));
                path = reportPath;
            }
            else
            {
                String reportFile = DEFAULT_PATH + GenerateTestName(testSuiteName);
                extent = new ExtentReports(reportFile);
                screenshotsPath = GetPath() + "Screenshots\\";
            }
        }

        public static void Start(String testSuiteName)
        {
            Start(testSuiteName, false);
        }

        private static void CreateDirectory(String testSuiteName)
        {
            reportPath = DEFAULT_PATH + testSuiteName + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_FFF") + "\\";
            Directory.CreateDirectory(reportPath);
        }

        private static void CreateScreenshotDirectory()
        {
            screenshotsPath = reportPath + "\\Screenshots\\";
            Directory.CreateDirectory(screenshotsPath);
        }

        public static void AddTestCase(String testName, String testDescription)
        {
            test = extent.StartTest(testName, testDescription);
        }

        public static void Log(LogStatus logStatus, String message, String screenshot)
        {
            test.Log(logStatus, message + test.AddScreenCapture(screenshot));
            extent.Flush();
        }

        public static void Log(LogStatus logStatus, String message)
        {
            Console.WriteLine(message);
            test.Log(logStatus, message);
            extent.Flush();
        }

        public static void End()
        {
            extent.EndTest(test);
        }

        public static void Stop()
        {
            extent.EndTest(test);
            extent.Flush();
            extent.Close();
        }
    }
}