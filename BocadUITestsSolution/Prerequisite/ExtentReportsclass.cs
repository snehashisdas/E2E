using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BocadUITestsSolution.Prerequisite
{
   [TestFixture]
    public class ExtentReportsclass
    {
        public ExtentReports extent;
        public ExtentTest test;


        [TestInitialize]
        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = "C:\\bin\\Reports\\Bocad_TestAutomationReport.html";
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Reports\\ExtentStepLogs.html";
            extent = new ExtentReports(reportPath,true);
            
        }

        [Test]
        public void StepLogsGeneration()
        {
           // test = extent.StartTest("");
        }


        [TestCleanup]
        public void TearDown()
        {
            
            extent.Flush();
            extent.Close();
        }

    }
}
