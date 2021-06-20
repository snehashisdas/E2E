using BocadAPITestsSolution.Core;
using BocadUITestsSolution.ObjectRepos;
using BocadUITestsSolution.Prerequisite;
using BocadUITestsSolution.UIControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RelevantCodes.ExtentReports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White;
using BocadUITestsSolution.Core;
namespace BocadUITestsSolution.TestScripts
{
    [TestClass]
    public class BocadTest
    {
        [TestInitialize]
        public void TestSetup()
        {     
            
        }
        Reporting rep = new Reporting();

        AIValLibrary ailib = new AIValLibrary();
        [TestMethod]
        public void ExecuteTest()
        {
            rep.IntitialzeReporting();
            rep.f_createTest("BocadTest");
            Functions.launchBocad();
            Functions.loginBocad(BocadConstants.userName, BocadConstants.password);
           // Functions.maximizeWindow();
            Functions.CreationofNewJob("E2E");
            Functions.CreateGrid("0,2:6000", "0,4000", "0,4000,5500", "El.");

            //Functions.computeWeight(1, 1, 3, "+", "Real");
            //Functions.computeWeight(2, 2, 2, "*", "GrossWeight");
            //Functions.computeWeight(3, 4, 5, "%", "Rubber");
            //Functions.computeWeight(4, 5, 6, "/", "User");
            //Functions.computeWeight(5, 6, 7, "/", "User", true);

            Functions.OpenPerspective();
            Functions.CreateFoundation("600", "600", "500");
            Functions.clickCanvas();
            MyUtilities.WaitTime(3000);
            Functions.divideView("peRspeCtive", "vertical");
            Functions.refreshView();
            Functions.make2DViewFit();
            Functions.switchToView("AxiS_1");
            Functions.make2DViewFit();
            Functions.createProfOnAxis1();

            Functions.OpenDetailView();
            Functions.createPointsFromMember();
            Functions.createPlate(30, 15);
            Functions.AdaptMember();
            Functions.addPoint("a:80,-80", "a:80,-80");
            Functions.createHoleOnPlate(26);
            Functions.createWeldOnProfile();
            MyUtilities.WaitTime(5000);
            Functions.SaveViewAs("DETAIL", "Detail1");
            Functions.copyViaPoints();

            //Validation of  Property grid window
            Functions.switchToView("3D");
            Functions.switchtoorthographicview();
            Functions.clickCanvas();
            Functions.expandpropertiesgridwin();
            Functions.expandmodelexplorer();
            Functions.removegridfromview();
            Functions.clickCanvas();
            Functions.selectallcolumns();
            Functions.clickCanvas();
            Functions.modifypropertiesfromgrid("IPE500", "COLUMN", "S275JR", "111", "999");
            Functions.switchToView("AxiS_1");
            Functions.validateinfoprop();
            Functions.closeinfoprop();
            Functions.clickCanvas();

            //MyUtilities.WaitTime(5000);
            Functions.applyMacroForProfonAxis1();
            MyUtilities.WaitTime(5000);
            Functions.copyProfliesViaDistnce("0", "0", "2:-6000");
            MyUtilities.WaitTime(5000);
            Functions.secondaryBeam();
            MyUtilities.WaitTime(5000);
            Functions.applyMacroOnSecondryBeam();
            MyUtilities.WaitTime(7000);
            Functions.divideLineOnBeam();
            Functions.createAdditionalBeam();
            Functions.checkClashingMember("cOmplete Project");
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "Filter Colliding members /M1:25/tv4100/th3600"); 
            Functions.applyMacroOnAdditionalBeams();
            Functions.closeView("clashing");
            Functions.checkMemberWithoutPartner();
            Functions.closeView("partner");
            Functions.switchToView("AxiS_1");
            Functions.Nesteddrawingcreation();
            //open message window
            Functions.clickCanvas();
            Functions.messagewindow();
            //Valdiation of Advanced marking

            Functions.DefaultAdvancedmarking();
            Functions.validateinfoprop();
            Functions.closeinfoprop();

            //Validation of unmark

            Functions.performunmark();
            Functions.refreshView();
            MyUtilities.WaitTime(2000);
            Functions.validateinfoprop();
            Functions.closeinfoprop();

            //Validation of marking fro bolts and welds
            Functions.Advancedmarkingboltsandwelds();
            Functions.validateinfoprop();
            Functions.closeinfoprop();

            //Apply Stiffner
            Functions.clickCanvas();
            Functions.createmidpoint();
            Functions.applystiffner("AVV601");
            Functions.clickCanvas();

            //Revision marking
            Functions.Revisionmarking();

            //Automatic drawings
            Functions.automaticdrawings();

            //Assembly drawings
            Functions.assemblydrawings();

            //Shop drawings
             Functions.shopdrawings();

            //NC/DSTV interface Nesteddrawingcreation
            Functions.ncdstvdrawing();

            //close drawings window
            Functions.closedrawingswindow();

            //Validate drawings from boview
            Functions.validatedrawingsinboview("E2E");

            Reporting.extent.Flush();
        }


        [TestMethod]
        public void demoTest()
        {
            rep.IntitialzeReporting();
            rep.f_createTest("BocadTest");

            Functions.launchBocad();
            Functions.loginBocad(BocadConstants.userName, BocadConstants.password);
            //Functions.maximizeWindow();
            Functions.CreationofNewJob("");
            Functions.CreateGrid("0,2:6000", "0,4000", "0,4000,5500", "El.");
            Functions.OpenPerspective();

            //Functions.CreateFoundation("600", "600", "500");
            //Functions.clickCanvas();
            //MyUtilities.WaitTime(3000);
            //Functions.divideView("peRspeCtive", "vertical");
            //Functions.refreshView();
            //Functions.make2DViewFit();
            //Functions.switchToView("AxiS_1");
            //Functions.make2DViewFit();
            //Functions.createProfOnAxis1();
            Functions.applyMacro("AVV202",false,false,true);
            // Functions.secondaryBeam();
            // Functions.checkClashingMember("ProJect");
            // Functions.checkMemberWithoutPartner();


        }
        
    }
}
