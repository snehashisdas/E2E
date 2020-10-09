using System;
using RelevantCodes.ExtentReports;


namespace BocadUITestsSolution.Core
{
    public class Reporting
    {
        public static ExtentReports extent;
        public static ExtentTest test;

        ///---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method is to initate  and reuse Extent object for reporting
        /// </summary>
        /// <param name><param>
        /// <returns>Nothing</returns>
        /// <Author>Navya Yadlapalli</Author>
        /// <Created Date>18/09/2020</Created Date>
        /// <Modified Date> </Modified Date>
        /// <Modified by>  </Modified by>	
        ///---------------------------------------------------------------------------------------------------------------------------------------
        public ExtentReports IntitialzeReporting()
        {
            if (extent != null)
            {
                return extent;
            }
            String path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            String Fpath = path.Substring(0, path.LastIndexOf("bin")) + "Reports\\Bocad_TestAutomationReport.html";
            String reportPath = new Uri(Fpath).LocalPath;
            //Boolean value for replacing exisisting report
            extent = new ExtentReports(reportPath, true);
            //Add QA system info to html report
            extent.AddSystemInfo("Environment", "Test Environment")
            .AddSystemInfo("Company", "AVEVA");

            //Adding config.xml file
            String Fpath1 = path.Substring(0, path.LastIndexOf("bin"));
            String projectPath = new Uri(Fpath1).LocalPath;
            extent.LoadConfig(projectPath + "extent-Config.xml"); //Get the config.xml file from http://extentreports.com
            return extent;
        }
        ///---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method is to Report the heading of test case in html Report
        /// </summary>
        /// <param name>
        /// name : Name of test case
        /// <param>
        /// <returns>Nothing</returns>
        /// <Author>Navya Yadlapalli</Author>
        /// <Created Date>17/09/2020</Created Date>
        /// <Modified Date> </Modified Date>
        /// <Modified by> </Modified by>
        ///---------------------------------------------------------------------------------------------------------------------------------------
        public ExtentTest f_createTest(string name)
        {
            test = extent.StartTest(name);
            return test;
        }
        ///---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method is to capture screenshot 
        /// </summary>
        /// <param name>
        /// driver : Winium driver
        /// <param>
        /// <returns>Nothing</returns>
        /// <Author>Navya Yadlapalli</Author>
        /// <Created Date>17/09/2020</Created Date>
        /// <Modified Date> </Modified Date>
        /// <Modified by> </Modified by>
        ///---------------------------------------------------------------------------------------------------------------------------------------
        //public static string CaptureScreenShoot(IWebDriver driver, String ScreenShotName)

        public string CaptureScreenShoot(String ScreenShotName)
        {
            String path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            String Fpath = path.Substring(0, path.LastIndexOf("bin")) + "Reports\\ErrorScreenShot\\" + ScreenShotName + ".png";
            String localpath = new Uri(Fpath).LocalPath;

            try
            {

                //Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                //ss.SaveAsFile(localpath, System.Drawing.Imaging.ImageFormat.Png);
                return localpath;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return localpath;

            }
        }
    }
}
