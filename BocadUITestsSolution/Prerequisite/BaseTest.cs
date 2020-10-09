
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;
using System;

namespace BocadAPITestsSolution.Core
{
    [TestClass]
    [DeploymentItem("Resource", "Resource")]
    [DeploymentItem("TestData", "TestData")]

    public class BaseTest
    {
        protected TestContext testContextInstance;
        public static ExtentReports extent;
        public static ExtentTest test;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {

        }
        [TestInitialize]
        public void TestInit()
        {
            String path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            String Fpath = path.Substring(0, path.LastIndexOf("bin")) + "Reports\\E3D_Visual_TestAutomationReport.html";
            String reportPath = new Uri(Fpath).LocalPath;
            //Boolean value for replacing exisisting report
            extent = new ExtentReports(reportPath, true);
            //Add QA system info to html report
            extent.AddSystemInfo("Environment", "Test Environment").AddSystemInfo("Company", "AVEVA");



            //Adding config.xml file
            String Fpath1 = path.Substring(0, path.LastIndexOf("bin"));
            String projectPath = new Uri(Fpath1).LocalPath;
            extent.LoadConfig(projectPath + "extent-Config.xml"); //Get the config.xml file from http://extentreports.com
            //return extent;
            // ReportManager.initalizeTestCase(TestContext.TestName, TestContext.TestName);

        }
        [TestCleanup]
        public void TestCleanUp()
        {

           // ReportManager.CloseTestCaseReport();

        }

        [AssemblyInitialize]
        public static void AssemIn(TestContext context)
        {
           // ReportManager.intializeTestReport("ABC", "ABC");
        }
        [AssemblyCleanup]
        public static void AssenCl()
        {

            //ReportManager.CloseTestSuiteReport();
        }

    }
}

