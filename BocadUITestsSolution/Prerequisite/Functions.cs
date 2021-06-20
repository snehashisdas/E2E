using RelevantCodes.ExtentReports;
using BocadAPITestsSolution.Core;
using BocadUITestsSolution.Core;
using BocadUITestsSolution.ObjectRepos;
using BocadUITestsSolution.UIControls;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System;
using TestStack.White.InputDevices;

namespace BocadUITestsSolution.Prerequisite
{
    public class Functions
    {

        public static void PreCondition()
        {
            if (Directory.Exists(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Aveva"))
            {
                Directory.Delete(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Aveva", true);
            }
        }
        public static void launchBocad()
        {
            TestStack.White.Application app = TestStack.White.Application.Launch(BocadConstants.BocadApplicationPath);
            MyUtilities.WaitTime(12000);
        }
        public static void loginBocad(string username, string password, string mdb = "ALL", string datestamp = "NONE")
        {
            try
            {
                TextBoxControls.SetTextinAnyTextBox(Locators.Win_Login, AutomationElement.NameProperty, AutomationElement.AutomationIdProperty, Locators.ab_Login_Form_Username["ID"], username);
                TextBoxControls.SetTextinAnyTextBox(Locators.Win_Login, AutomationElement.NameProperty, AutomationElement.AutomationIdProperty, Locators.ab_Login_Form_Password["ID"], password);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Win_Login, AutomationElement.NameProperty, AutomationElement.AutomationIdProperty, Locators.Btn_StrcuturalDesign);
                Reporting.test.Log(LogStatus.Pass, "BOCAD logged in successfully");
                MyUtilities.WaitTime(40000);
                string screenpath1 = Reporting.CaptureScreenShoot("BOCAD LOGIN SNAP");
                Reporting.test.Log(LogStatus.Pass, "BOCAD Log-in Snap" + Reporting.test.AddScreenCapture(screenpath1));
            }

            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Bocad login failed Error: " + e.Message);
            }
        }
        public static void maximizeWindow()
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                     AutomationElement.AutomationIdProperty, Locators.job_Form_Maximize["ID"]);
                Reporting.test.Log(LogStatus.Pass, "Mainwindow maximised successfully");
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Mainwindow maximise Failed Error: " + e.Message);
            }

        }
        public static void CreationofNewJob(string JobName)
        {

            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.LstItm_NewJob);
                //string JobName = MiscFunctions.GenerateCoupon(6);
                TextBoxControls.SetTextinAnyTextBox(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.TxtBx_JobName, JobName);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Btn_Create);
                MyUtilities.WaitTime(15000);
                Reporting.test.Log(LogStatus.Pass, "Job created successfully");
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "job creation Failed Error: " + e.Message);
            }
        }
        public static void CreateGrid(string X_value, string Y_value, string Z_value, string levelName, string axisName = "1")
        {
            try
            {
                UIActions.Click_Element(Locators.createGrid_X_Value_wrtco["X"], Locators.createGrid_X_Value_wrtco["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(X_value);

                UIActions.Click_Element(Locators.createGrid_Y_Value_wrtco["X"], Locators.createGrid_Y_Value_wrtco["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(Y_value);

                UIActions.Click_Element(Locators.createGrid_Z_Value_wrtco["X"], Locators.createGrid_Z_Value_wrtco["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(Z_value);

                UIActions.Click_Element(Locators.createGrid_LevelName_wrtco["X"], Locators.createGrid_LevelName_wrtco["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(levelName);

                //MyUtilities.WaitTime(1500);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Win_CreateGrid, AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Btn_Ok);
                MyUtilities.WaitTime(1500);
                ButtonContorls.DoubleClickButtoninAnyWindow(Locators.view_ChangeMainView_Window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.view_Axis1_Tab["NAME"]);
                Reporting.test.Log(LogStatus.Pass, "Grid created successfully");
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Grid creation Failed Error: " + e.Message);
            }

        }
        public static void OpenPerspective()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.ViewTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.View_Perspective_Btn["NAME"]);
            MyUtilities.WaitTime(1700);
            ButtonContorls.ClickButtoninAnyWindow(Locators.view_PersRepresent_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.View_PersRepresent_OKbtn["NAME"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.view_Glopers_Maximum_Tab["NAME"]);

        }
        public static void OpenDetailView()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.ViewTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.View_Detail_btn["NAME"]);
            MyUtilities.WaitTime(3000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.View_Detail_ViewForm_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.View_Detail_ViewForm_Above["NAME"]);
            SendKeys.SendWait(" ");
            //ButtonContorls.ClickButtoninAnyWindow(Locators.View_Detail_ViewForm_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.View_Detail_ViewForm_Front["NAME"]);
            //SendKeys.SendWait(" ");
            ButtonContorls.ClickButtoninAnyWindow(Locators.View_Detail_ViewForm_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.View_Detail_ViewForm_Diemetry["NAME"]);
            SendKeys.SendWait(" ");
            ComboBoxControls.SelecAnyComboboxitem(Locators.View_Detail_ViewForm_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.View_Detail_ViewForm_Window_dropdown["NAME"], "Views together in a single new window");
            ButtonContorls.DoubleClickButtoninAnyWindow(Locators.View_Detail_ViewForm_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.View_Detail_ViewForm_OK_Btn["NAME"]);
            Point p1 = new Point(200, 740); //Drag Point
            Point p2 = new Point(310, 815); //Drop Point
            UIActions.DragNDrop(p1, p2);
            Functions.createPointAt(280, 755);
            SendKeys.SendWait("{ENTER}");
        }
        public static void CreateFoundation(string position_Y_value, string position_X_value, string Dimension_value)
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.Create_Concrete_Btn["NAME"]);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.Create_Concrete_Foundation_Btn["NAME"]);

                //For Supplying foundation position and dimension values
                UIActions.Control_Mouse_RightClick(450, 240);
                MyUtilities.WaitTime(1000);
                UIActions.Click_Element(Locators.Create_Concrete_Foundation_Position_midPoint["X"], Locators.Create_Concrete_Foundation_Position_midPoint["Y"]);
                UIActions.Click_Element(Locators.Create_Concrete_Foundation_Position_Y_value["X"], Locators.Create_Concrete_Foundation_Position_Y_value["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(position_Y_value);

                UIActions.Click_Element(Locators.Create_Concrete_Foundation_Position_X_value["X"], Locators.Create_Concrete_Foundation_Position_X_value["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(position_X_value);

                UIActions.Click_Element(Locators.Create_Concrete_Foundation_Dimension_midPoint["X"], Locators.Create_Concrete_Foundation_Dimension_midPoint["Y"]);
                UIActions.Click_Element(Locators.Create_Concrete_Foundation_Dimension_value["X"], Locators.Create_Concrete_Foundation_Dimension_value["Y"]);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(Dimension_value);

                ButtonContorls.ClickButtoninAnyWindow(Locators.Create_Concrete_Foundation_SingleBase_MainWin["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Create_Concrete_Foundation_SingleBase_Ok_Btn["NAME"]);

                //Create Points on 0-Axis
                UIActions.Click_Element(Locators.WorkField_PersFoundation_PointB1["X"], Locators.WorkField_PersFoundation_PointB1["Y"]);
                MyUtilities.WaitTime(1000);
                UIActions.Click_Element(Locators.WorkField_PersFoundation_PointB2["X"], Locators.WorkField_PersFoundation_PointB2["Y"]);
                UIActions.Click_Element(Locators.WorkField_PersFoundation_PointB3["X"], Locators.WorkField_PersFoundation_PointB3["Y"]);
                UIActions.Click_Element(Locators.WorkField_PersFoundation_PointA1["X"], Locators.WorkField_PersFoundation_PointA1["Y"]);
                UIActions.Click_Element(Locators.WorkField_PersFoundation_PointA2["X"], Locators.WorkField_PersFoundation_PointA2["Y"]);
                UIActions.Click_Element(Locators.WorkField_PersFoundation_PointA3["X"], Locators.WorkField_PersFoundation_PointA3["Y"]);
                SendKeys.SendWait("{ENTER}");
                MyUtilities.WaitTime(2000);
                Reporting.test.Log(LogStatus.Pass, Reporting.test.AddScreenCapture(Reporting.CaptureScreenShoot("Foundation created shot")));
                Reporting.test.Log(LogStatus.Pass, "Concrete Foundation created successfully");
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Foundation creation Failed Error: " + e.Message);
            }

        }
        public static void createPointAt(int x, int y)
        {
            UIActions.Click_Element(x, y);
            MyUtilities.WaitTime(1300);
        }
        public static void setProfSpecification(string ProfSpecification = "European", string profType = "", string profName = "", string ProfDesignation = "", string ProfOrientaitonPoint = "", string profOrientaionView = "")
        {
            try
            {
                // ProfSpecification.ToLower();
                profType.ToUpper();
                profName.ToUpper();
                ProfOrientaitonPoint.ToUpper();
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
                MyUtilities.WaitTime(1000);
                UIActions.Click_Element(28, 82);//Create Profile Button
                                                //ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,AutomationElement.NameProperty, Locators.Create_Prof_Btn["NAME"]);
                MyUtilities.WaitTime(3000);

                //Set Profile SpecificationName
                if (ProfSpecification.Contains("European"))
                {
                    ButtonContorls.ClickButtoninAnySubWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                     Locators.Create_Prof_Specification_Cmbx["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Create_Prof_Specification_dropDown["ID"]);
                    ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, "European Standard Profiles");
                    SendKeys.SendWait("{ENTER}");
                }

                //Set Profile Type
                if (profType.Contains("HEA"))
                {
                    ButtonContorls.ClickButtoninAnySubWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    Locators.Create_Prof_Type_Cmbx["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Create_Prof_Specification_dropDown["ID"]);
                    ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, "HEA Profile");
                }
                else if (profType.Contains("IPE"))
                {
                    ButtonContorls.ClickButtoninAnySubWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    Locators.Create_Prof_Type_Cmbx["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Create_Prof_Specification_dropDown["ID"]);
                    ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, "IPE Profile");
                }

                //Set Profile Name
                ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                        AutomationElement.AutomationIdProperty, Locators.Create_Prof_Name_Cmbx["ID"], profName);

                //Set Profile Designation
                ButtonContorls.ClickButtoninAnySubWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                Locators.Create_Prof_Designation_Cmbx["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Create_Prof_Specification_EditField["ID"]);
                //ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, ProfDesignation);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(ProfDesignation);
                SendKeys.SendWait("{ENTER}");
                //Set Profile Orientation View
                for (int i = 1; i <= 3; i++)
                {
                    string s = ButtonContorls.fineNameAttributeOfChildElement(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                      AutomationElement.AutomationIdProperty, Locators.Create_Prof_OrientationView_Btn["ID"]);
                    if (s != (profOrientaionView))
                    {
                        ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Create_Prof_OrientationView_Btn["ID"]);
                    }
                    else if (s == profOrientaionView)
                    {
                        break;
                    }
                }

                //Set Profile Orientation Point
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                        AutomationElement.AutomationIdProperty, "my" + ProfOrientaitonPoint);
                SendKeys.SendWait("{ENTER}");

                Reporting.test.Log(LogStatus.Pass, "Profile Specification set successfully");
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Setting profile specification Failed Error: " + e.Message);
            }

        }
        public static void createPointsFromMember()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Home_Points_DropDown_Btn["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Home_Points_PointFromMember["ID"]);
            MyUtilities.WaitTime(1700);
            UIActions.Click_Element(250, 500);//For Selecting the Profile
            SendKeys.SendWait("{ENTER}");
        }
        public static void addPoint(string DXvalue, string DYvalue)
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Home_Points_DropDown_Btn["ID"]);
            MyUtilities.WaitTime(1500);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Home_Points_Add["ID"]);
            MyUtilities.WaitTime(1700);
            UIActions.Control_Mouse_RightClick(250, 500);//Default point
            MyUtilities.WaitTime(2000);

            UIActions.Click_Element(350, 365);//click on dx edit field
            UIActions.DoubleClick_Element(350, 365);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(DXvalue);

            UIActions.Click_Element(350, 385);//click on dy edit field
            UIActions.DoubleClick_Element(350, 385);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(DYvalue);
            MyUtilities.WaitTime(1700);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Home_Points_AddPoints_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.Home_Points_AddPoints_Win_OK_Btn["NAME"]);
            UIActions.Click_Element(250, 444);
            MyUtilities.WaitTime(2000);
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{ENTER}");
        }
        public static void divideLine(int noOfDivision, bool zCoordinate = false)
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.AutomationIdProperty, Locators.Home_Points_DropDown_Btn["ID"]);
                MyUtilities.WaitTime(1500);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.AutomationIdProperty, Locators.Home_Points_DivideLine["ID"]);
                MyUtilities.WaitTime(1700);
                UIActions.Control_Mouse_RightClick(250, 500);//Default point
                MyUtilities.WaitTime(2000);
                UIActions.Click_Element(400, 250);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{BACKSPACE}");
                SendKeys.SendWait(noOfDivision + "");
                if (zCoordinate == true)
                {
                    ButtonContorls.ClickButtoninAnyWindow(Locators.Home_Points_DivideLine_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Home_Points_DivideLine_Win_ZCoordinate_ChkBx["NAME"]);
                }
                ButtonContorls.ClickButtoninAnyWindow(Locators.Home_Points_DivideLine_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Home_Points_DivideLine_Win_Ok_Btn["NAME"]);
                Reporting.test.Log(LogStatus.Pass, "Line divided successfully");
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Line division Failed Error: " + e.Message);
            }

        }
        public static void createHoleOnPlate(int holeDia)
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Create_Hole_Btn["ID"]);
                UIActions.Control_Mouse_RightClick(450, 240);// Default Point on work field
                MyUtilities.WaitTime(1500);
                UIActions.Click_Element(580, 185);
                SendKeys.SendWait("^a");
                SendKeys.SendWait("{backspace}");
                SendKeys.SendWait(holeDia + "");
                ButtonContorls.ClickButtoninAnyWindow(Locators.Create_Hole_Rectangle_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Create_Hole_Rectangle_Win_OK_Btn["NAME"]);

                UIActions.Click_Element(203, 403);
                UIActions.Click_Element(285, 403);
                UIActions.Click_Element(203, 485);
                UIActions.Click_Element(285, 485);
                MyUtilities.WaitTime(1200);
                SendKeys.SendWait("{ENTER}");

                UIActions.Click_Element(240, 360);//Select the Plate for Hole- Creation
                SendKeys.SendWait("{ENTER}");
                MyUtilities.WaitTime(2000);
                AIValLibrary.CaptureBitmap(130, 425, 120, 85, "Hole-creation-snap");
                Reporting.test.Log(LogStatus.Pass, "Hole created successfully" + Reporting.test.AddScreenCapture("C:\\SNEHASHIS\\Snap\\Hole-creation-snap" + ".png"));
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Hole creation Failed Error: " + e.Message);
            }

        }
        public static void createWeldOnProfile()
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
                ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                   AutomationElement.AutomationIdProperty, Locators.Create_Weld_Btn["ID"]);
                MyUtilities.WaitTime(1700);
                UIActions.Control_Mouse_RightClick(500, 200);// Default Point to edit the weld data
                MyUtilities.WaitTime(1700);

                //Setting Weld Standard
                UIActions.Click_Element(780, 111); //Click on Standard Drop-Down
                MyUtilities.WaitTime(1200);
                UIActions.Click_Element(720, 157); //Selecting DIN-Standard

                //Setting Steel Constructor
                UIActions.Click_Element(620, 230); //Click On Drop-Down
                MyUtilities.WaitTime(800);
                UIActions.Click_Element(620, 250); //Select On KEHL 
                MyUtilities.WaitTime(1500);
                UIActions.Click_Element(555, 785);//Click on OK Btn
                                                  //Select Weld-Carrying Member
                UIActions.Click_Element(240, 360);//Select the Plate for Hole- Creation
                MyUtilities.WaitTime(1000);
                SendKeys.SendWait("{ENTER}");
                //Select secondary member
                UIActions.Click_Element(300, 435);//Select the Plate for Hole- Creation
                MyUtilities.WaitTime(1000);
                SendKeys.SendWait("{ENTER}");
                Reporting.test.Log(LogStatus.Pass, "Weld created successfully" + Reporting.test.AddScreenCapture(Reporting.CaptureScreenShoot("Weld creation")));
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Weld creation Failed Error: " + e.Message);
            }

        }
        public static void createPlate(int plateWidth, int expansionValue)
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
                ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                   AutomationElement.AutomationIdProperty, Locators.Create_Plate_Btn["ID"]);
                UIActions.Control_Mouse_RightClick(450, 240);
                MyUtilities.WaitTime(1000);
                //Plate Selection From The list
                UIActions.Click_Element(635, 185);
                MyUtilities.WaitTime(3000);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Create_Plate_ProfileListOutline_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, "PL" + plateWidth);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Create_Plate_ProfileListOutline_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Create_Plate_ProfileListOutline_Win_OKBtn["NAME"]);
                MyUtilities.WaitTime(1500);
                UIActions.Click_Element(667, 350);
                UIActions.Click_Element(660, 440);
                SendKeys.SendWait("^a");
                SendKeys.SendWait(expansionValue + "");
                //ButtonContorls.DoubleClickButtoninAnyWindow(Locators.Create_PlateForm_Win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Create_Plate_ProfileListOutline_Win_OKBtn["NAME"]);
                UIActions.Click_Element(506, 520);
                UIActions.Click_Element(118, 480);
                UIActions.Click_Element(118, 385);
                UIActions.Click_Element(350, 385);
                UIActions.Click_Element(350, 480);
                SendKeys.SendWait("{ENTER}");
                MyUtilities.WaitTime(2000);
                Reporting.test.Log(LogStatus.Pass, "Plate created successfully" + Reporting.test.AddScreenCapture(Reporting.CaptureScreenShoot("Plate creation")));
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Plate creation Failed Error: " + e.Message);
            }
        }
        public static void AdaptMember()
        {
            try
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                          AutomationElement.AutomationIdProperty, Locators.ModifyTab["ID"]);
                ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                  AutomationElement.AutomationIdProperty, Locators.Modify_Length_Btn["ID"]);
                UIActions.Control_Mouse_RightClick(450, 240);
                MyUtilities.WaitTime(5000);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Modify_Length_LengthMod_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Modify_Length_LengthMod_AdaptMember["NAME"]);
                ButtonContorls.ClickButtoninAnyWindow(Locators.Modify_Length_LengthMod_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.Modify_Length_LengthMod_OK_Btn["NAME"]);
                MyUtilities.WaitTime(5000);
                UIActions.Click_Element(343, 690);//For picking tool part
                SendKeys.SendWait("{ENTER}");
                UIActions.Click_Element(1170, 800);//For picking 1st member to adapt
                UIActions.Click_Element(1410, 800);//For picking 2nd member to adapt
                MyUtilities.WaitTime(2000);
                SendKeys.SendWait("{ENTER}");
                SendKeys.SendWait("{ENTER}");
                MyUtilities.WaitTime(5000);
                Reporting.test.Log(LogStatus.Pass, "Member Adapted successfully" + Reporting.test.AddScreenCapture(Reporting.CaptureScreenShoot("Member Adaption snap")));
            }
            catch (Exception e)
            {
                Reporting.test.Log(LogStatus.Fail, "Member adaption Failed Error: " + e.Message);
            }

        }
        public static void copyViaPoints()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                      AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                      AutomationElement.AutomationIdProperty, Locators.Home_Copy_Btn["ID"]);
            MyUtilities.WaitTime(1200);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                      AutomationElement.NameProperty, Locators.Home_Copy_ViaPoints_Btn["NAME"]);
            MyUtilities.WaitTime(3000);
            Point p1 = new Point(233, 729);//Drag Point
            Point p2 = new Point(290, 759);//Drop Point
            UIActions.DragNDrop(p1, p2);
            MyUtilities.WaitTime(1200);
            SendKeys.SendWait("{ENTER}");
            UIActions.Click_Element(280, 760);
            MyUtilities.WaitTime(1200);
            SendKeys.SendWait("{ENTER}");
            UIActions.Click_Element(690, 760);
            MyUtilities.WaitTime(1200);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(3000);
        }
        public static void applyMacro(string macroName, bool mainMemberloop, bool secondryMemberloop, bool stiffner = false)
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_Btn["NAME"]);
            MyUtilities.WaitTime(5000);
            ButtonContorls.ClickButtoninAnyWindow("Macro Explorer", AutomationElement.NameProperty,
                AutomationElement.NameProperty, "Maximize");
            UIActions.DoubleClick_Element(50, 60);
            SendKeys.SendWait(macroName);
            MyUtilities.WaitTime(7000);
            UIActions.DoubleClick_Element(300, 200);//Select the macro at the default position after maximisation
            MyUtilities.WaitTime(4500);


            ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_EditJoint_win_Stiffner["NAME"]);
            MyUtilities.WaitTime(3000);
            if (stiffner == true)
            {
                UIActions.Click_Element(720, 113);//stiffner checkbox
             //   UIActions.Click_Element(1120, 145);//stiffner checkbox 
            }

            if (mainMemberloop == true || secondryMemberloop == true)
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_AdminBox_Btn["NAME"]);
                MyUtilities.WaitTime(3000);
                UIActions.Control_Mouse_RightClick(1000, 500);//Default point
                MyUtilities.WaitTime(4000);

                RadioButtonControls.SelectAnyRadioButton(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.MacroExplorer_AdminBox_Pickrequests_radioBtn["NAME"], false);
                MyUtilities.WaitTime(1000);
                //select Loop for main member 
                if (mainMemberloop == true)
                {
                    UIActions.Click_Element(1000, 170);
                    MyUtilities.WaitTime(1200);
                    UIActions.Click_Element(1000, 225);
                    MyUtilities.WaitTime(1000);
                }
                //select Loop for secondary member 
                if (secondryMemberloop == true)
                {
                    UIActions.Click_Element(1000, 190);
                    MyUtilities.WaitTime(1200);
                    UIActions.Click_Element(1000, 250);
                }

                //ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                //AutomationElement.NameProperty, Locators.MacroExplorer_UserBox_Btn["NAME"]);
                //UIActions.Control_Mouse_RightClick(700, 500);//Default point
                //MyUtilities.WaitTime(4000);
            }


            

            ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
            AutomationElement.NameProperty, Locators.MacroExplorer_EditJoint_win_OKBtn["NAME"]);
            
        }
        public static void copyProfliesViaDistnce(string xValue, string yValue, string zValue)
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                     AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                      AutomationElement.AutomationIdProperty, Locators.Home_Copy_Btn["ID"]);
            MyUtilities.WaitTime(1200);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                      AutomationElement.NameProperty, Locators.Home_Copy_ViaDistance_Btn["NAME"]);
            MyUtilities.WaitTime(3000);
            //Edit X-Value
            UIActions.Click_Element(200, 111);//X-value edit position
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(xValue);
            //Edit Y-Value
            UIActions.Click_Element(200, 130);//Y-value edit position
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(yValue);
            //Edit Z-Value
            UIActions.Click_Element(200, 150);//Z-value edit position
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(zValue);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Home_CopyViaDimension_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.Home_CopyViaDimension_Win_OK_Btn["NAME"]);

            //Select All Profiles
            Point p1 = new Point(200, 150);
            Point p2 = new Point(777, 760);
            UIActions.DragNDrop(p1, p2);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(5000);
        }
        public static void clickonSideExplorerBtn(string explorerBtnName = "")
        {
            ButtonContorls.DoubleClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.WorkField_ModelWorld_Btn["NAME"]);
            ButtonContorls.DoubleClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.WorkField_Comment_Btn["NAME"]);
        }
        public static void make2DViewFit()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.ViewPortTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.viewport_Extents["NAME"]);
        }
        public static void refreshView()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.ViewPortTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.viewport_Calculate["NAME"]);
        }
        public static void divideView(string viewName = "", string divideViewSection = "")
        {
            string capViewName = viewName.ToUpper();
            if (viewName.ToLower() == "perspective")
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.view_Glopers_Maximum_Tab["NAME"]);
            }
            else if (capViewName.Contains("3D"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WorkField_3DView_Tab["NAME"]);
            }
            else if (capViewName.Contains("DETAIL"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WorkField_DetailView_Tab["NAME"]);
            }
            else
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "Grid_0_1_" + capViewName + "/M1:50/tv500/th-500");
            }

            MyUtilities.WaitTime(1500);
            if (divideViewSection.ToLower() == "horizontal")
            {
                ButtonContorls.ClickButtoninAnyWindow("Context", AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.WorkField_newHorizontalTab["NAME"]);
            }
            else if (divideViewSection.ToLower() == "vertical")
            {
                ButtonContorls.ClickButtoninAnyWindow("Context", AutomationElement.NameProperty,
                               AutomationElement.NameProperty, Locators.WorkField_newVerticalTab["NAME"]);
            }

        }
        public static void SaveViewAs(string viewName, string saveViewNameAs)
        {
            string capViewName = viewName.ToUpper();
            if (viewName.ToLower() == "perspective")
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.view_Glopers_Maximum_Tab["NAME"]);
            }
            else if (capViewName.Contains("3D"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WorkField_3DView_Tab["NAME"]);
            }
            else if (capViewName.Contains("DETAIL"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WorkField_DetailView_Tab["NAME"]);
            }
            else
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "Grid_0_1_" + capViewName + "/M1:50/tv500/th-500");
            }
            //ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
            //        AutomationElement.NameProperty, Locators.WorkField_DetailView_Tab["NAME"]);
            MyUtilities.WaitTime(1500);
            ButtonContorls.ClickButtoninAnyWindow("Context", AutomationElement.NameProperty,
                               AutomationElement.NameProperty, Locators.WorkField_Close_Tab["NAME"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.WorkField_TabClose_Save_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.WorkField_TabClose_Save_Yes_Btn["NAME"]);
            MyUtilities.WaitTime(2700);
            ButtonContorls.ClickButtoninAnyWindow(Locators.FileName_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.FileName_Edit_Field["NAME"]);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{backspace}");
            SendKeys.SendWait(saveViewNameAs);
            ButtonContorls.ClickButtoninAnyWindow(Locators.FileName_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.FileName_Save_Btn["NAME"]);
            MyUtilities.WaitTime(2000);
        }
        public static void switchToView(string viewName)
        {
            string capViewName = viewName.ToUpper();
            if (capViewName.Contains("3D"))
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WorkField_3DView_Tab["NAME"]);
            }
            else
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                        AutomationElement.NameProperty, "Grid_0_1_" + capViewName + "/M1:50/tv500/th-500");
            }
        }
        public static void closeView(string viewName)
        {
            string capViewName = viewName.ToUpper();
            if (capViewName.Contains("3D"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WorkField_3DView_Tab["NAME"]);
            }
            else if (capViewName.Contains("CLASHING"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "Filter Colliding members /M1:25/tv4100/th3600");
            }
            else if (capViewName.Contains("PARTNER"))
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "Filter Members_without_partners /M1:25/tv100/th-600");
            }
            else
            {
                ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "Grid_0_1_" + capViewName + "/M1:50/tv500/th-500");
            }

            MyUtilities.WaitTime(1500);
            ButtonContorls.ClickButtoninAnyWindow("Context", AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.WorkField_Close_Tab["NAME"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.WorkField_TabClose_Save_Win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.WorkField_TabClose_Save_No_Btn["NAME"]);
        }
        public static void make3DviewFit(string isometricViewDirection = "")
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.ThreeDViewTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.Look["NAME"]);
            MyUtilities.WaitTime(700);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Look_Isometric_SW["ID"]);
            UIActions.Click_Element(600, 250); //default point in 3D view after direction selection
        }
        public static void clickCanvas()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.ClearCanvas_Btn["NAME"]);

        }
        public static void computeWeight(int rowNo, int userWeightAttribute_No, int userInput_Value, string userOperator, string weightAttribute, bool save = false)
        {
            rowNo = rowNo - 1;
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.AdminTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.Admin_ComputeWeight["NAME"]);

            //Setting user weight attribute
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, "User Weight Attribule Row " + rowNo);
            MyUtilities.WaitTime(500);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, "User Weight Attribule Row " + rowNo);
            ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.WeightCalculator_Cmbx_EditingControl["NAME"], "UDWGH" + userWeightAttribute_No);

            //Setting User Input Value
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, "User Input Row " + rowNo);
            MyUtilities.WaitTime(300);
            SendKeys.SendWait(userInput_Value + "");

            //Setting User Operator
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                 AutomationElement.NameProperty, "Operators Row " + rowNo);
            MyUtilities.WaitTime(500);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                 AutomationElement.NameProperty, "Operators Row " + rowNo);
            ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.WeightCalculator_Cmbx_EditingControl["NAME"], userOperator);
            MyUtilities.WaitTime(300);

            //Setting Weight Attribute
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                 AutomationElement.NameProperty, "Weight Attribule Row " + rowNo);
            MyUtilities.WaitTime(500);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                 AutomationElement.NameProperty, "Weight Attribule Row " + rowNo);
            if (weightAttribute.Contains("Real"))
            {
                ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WeightCalculator_Cmbx_EditingControl["NAME"], "DTRWGH (Real Weight)");
            }
            else if (weightAttribute.Contains("Gross"))
            {
                ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WeightCalculator_Cmbx_EditingControl["NAME"], "DTWGHT (Gross Weight)");
            }
            else if (weightAttribute.Contains("User"))
            {
                ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WeightCalculator_Cmbx_EditingControl["NAME"], "DTRUWG (User Weight)");
            }
            else if (weightAttribute.Contains("Rubber"))
            {
                ComboBoxControls.SelecAnyComboboxitem(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, Locators.WeightCalculator_Cmbx_EditingControl["NAME"], "DTUWGH (Rubber Band Weight)");
            }

            //Save The Weight Calculator Setting
            if (save == true)
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.AutomationIdProperty, Locators.WeightCalculator_Ok_Btn["ID"]);
            }
        }
        public static void undo()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.ToolBar_Undo_Btn["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.ToolBar_UndoConfirmation_Win_Ok_Btn["ID"]);
        }
        public static void checkClashingMember(string startList)
        {
            string S1Upper = startList.ToUpper();
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.Home_ClashingMember_Btn["NAME"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_ListRadio_Btn["NAME"]);
            Functions.createPointAt(662, 62);
            //UIActions.DoubleClick_Element(638, 136);
            //UIActions.Click_Element(662, 62);
            //
            // UIActions.DoubleClick_Element(638, 134);
            if (S1Upper.Contains("PROJECT"))
            {
                UIActions.DoubleClick_Element(638, 134);
                //ComboBoxControls.SelecAnyComboboxitem(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
                //   AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_StartList_DropDown["NAME"], "Complete project");

            }
            else if (S1Upper.Contains("PICKED"))
            {
                UIActions.DoubleClick_Element(638, 78);
                // ComboBoxControls.SelecAnyComboboxitem(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
                //AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_StartList_DropDown["NAME"], Locators.startList_AsPicked);
            }
            else if (S1Upper.Contains("ASSEMBLIES"))
            {
                UIActions.DoubleClick_Element(638, 108);
                // ComboBoxControls.SelecAnyComboboxitem(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
                //AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_StartList_DropDown["NAME"], Locators.startList_Assemblies);
            }
            else if (S1Upper.Contains("PHASE"))
            {
                UIActions.DoubleClick_Element(638, 149);
                // ComboBoxControls.SelecAnyComboboxitem(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
                //AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_StartList_DropDown["NAME"], Locators.startList_Phase);
            }

            ButtonContorls.DoubleClickButtoninAnyWindow(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_Ok_Btn["NAME"]);
            //MyUtilities.WaitTime(1000);
            //SendKeys.SendWait("{RIGHT}");
            //SendKeys.SendWait("{RIGHT}");

        }
        public static void checkMemberWithoutPartner()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.HomeTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.Home_MemberWithoutPartners_Btn["NAME"]);
            //Functions.createPointAt(880, 60);
            //ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Home_MemberWithoutPartners_Win["NAME"], AutomationElement.NameProperty,
            //    AutomationElement.NameProperty, Locators.Home_MemberWithoutPartners_Win_startListDropDown_Btn["NAME"]);
            //ComboBoxControls.SelecAnyComboboxitem(Locators.Home_ClashingMember_CollidingMember_Win["NAME"], AutomationElement.NameProperty,
            //     AutomationElement.NameProperty, Locators.Home_ClashingMember_CollidingMember_Win_StartList_DropDown["NAME"], "Complete project");
            //UIActions.DoubleClick_Element(880, 134);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(700, 415);
            //ButtonContorls.ClickButtoninAnyWindow(Locators.Home_MemberWithoutPartners_Win["NAME"], AutomationElement.NameProperty,
            //    AutomationElement.NameProperty, Locators.Home_MemberWithoutPartners_Win_Ok_Btn["NAME"]);
            MyUtilities.WaitTime(1000);
            SendKeys.SendWait("{RIGHT}");

        }
        public static string GetCurrentFunctionName(string FunctionsName)
        {
            return FunctionsName.Split(' ').GetValue(1).ToString().Split('(').GetValue(0).ToString();
        }
        //Functions using re-usable functions
        public static void createProfOnAxis1()
        {
            Functions.setProfSpecification("European", "IPE", "IPE400", "COLUMN", "MC", "Front");
            //Point at B1 to create column
            Functions.createPointAt(280, 755);
            Functions.createPointAt(280, 195);
            //Point at A1 to create column
            Functions.createPointAt(690, 755);
            Functions.createPointAt(690, 195);
            Functions.setProfSpecification("European", "IPE", "IPE300", "Beam", "ML", "Front");
            //Point on L-5500 to create Beam
            Functions.createPointAt(280, 195);
            Functions.createPointAt(690, 195);
            //Point on L-4000 to create Beam
            Functions.createPointAt(275, 350);
            Functions.createPointAt(690, 350);
        }
        public static void applyMacroForProfonAxis1()
        {
            Functions.applyMacro("AVV204", false, false, false);

            Point p1 = new Point(800, 500);
            Point p2 = new Point(200, 550);
            UIActions.DragNDrop(p1, p2);
            SendKeys.SendWait("{ENTER}");
            Point p3 = new Point(500, 150);
            Point p4 = new Point(400, 380);
            UIActions.DragNDrop(p3, p4);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(7000);
        }
        public static void modifyMacro(string macroName, bool mainMemberloop, bool secondryMemberloop, int plateThickness, int boltRowsCount,
            int boltGageOnColumn, int boltRowsInBeamCount)
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
               AutomationElement.AutomationIdProperty, Locators.CreateTab["ID"]);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_Btn["NAME"]);
            MyUtilities.WaitTime(4000);
            SendKeys.SendWait(macroName);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(300, 200);//Clicking on searched macro
            MyUtilities.WaitTime(3000);

            if (mainMemberloop == true || secondryMemberloop == true)
            {
                ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_AdminBox_Btn["NAME"]);
                MyUtilities.WaitTime(3000);
                UIActions.Control_Mouse_RightClick(1000, 500);//Default point
                MyUtilities.WaitTime(4000);

                RadioButtonControls.SelectAnyRadioButton(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.MacroExplorer_AdminBox_Pickrequests_radioBtn["NAME"], false);
                MyUtilities.WaitTime(1000);
                //select Loop for main member 
                if (mainMemberloop == true)
                {
                    UIActions.Click_Element(1000, 170);
                    MyUtilities.WaitTime(1200);
                    UIActions.Click_Element(1000, 225);
                    MyUtilities.WaitTime(1000);
                }
                //select Loop for secondary member 
                if (secondryMemberloop == true)
                {
                    UIActions.Click_Element(1000, 190);
                    MyUtilities.WaitTime(1200);
                    UIActions.Click_Element(1000, 250);
                }

                ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_UserBox_Btn["NAME"]);
                UIActions.Control_Mouse_RightClick(700, 500);//Default point
                MyUtilities.WaitTime(4000);
            }

            ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_EditJoint_win_Stiffner["NAME"]);
            MyUtilities.WaitTime(1500);

            UIActions.Click_Element(800, 150);//stiffner checkbox 
            MyUtilities.WaitTime(1500);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("PL" + plateThickness);

            //Bolts Geometry
            ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                    AutomationElement.NameProperty, Locators.MacroExplorer_EditJoint_win_BoltsBtn["NAME"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.MacroExplorer_EditJoint_win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.MacroExplorer_EditJoint_win_BoltsBtn_GeometryBtn["NAME"]);
            UIActions.Click_Element(800, 150);// Bolts Rows text field 
            SendKeys.SendWait("^a");
            SendKeys.SendWait("" + boltRowsCount);

            UIActions.Click_Element(800, 260);//Bolt Gage On Column Text Field
            SendKeys.SendWait("^a");
            SendKeys.SendWait("" + boltGageOnColumn);

            UIActions.Click_Element(800, 345);//Bolts Rows in Beam text field
            SendKeys.SendWait("^a");
            SendKeys.SendWait("" + boltRowsInBeamCount);

        }
        public static void secondaryBeam()
        {
            Functions.setProfSpecification("European", "IPE", "IPE300", "Beam", "TC", "Top");
            Functions.createPointAt(1400, 620);//A1
            Functions.createPointAt(1540, 500);//A2
            Functions.createPointAt(1150, 600);//B1
            Functions.createPointAt(1290, 470);//B2
        }
        public static void applyMacroOnSecondryBeam()
        {
            Functions.applyMacro("AVV208", false, false, true);
            //Apply macro for A-Row
            Functions.createPointAt(1400, 700);//Profile at A1
            Functions.createPointAt(1540, 590);//Profile at A2
            SendKeys.SendWait("{ENTER}");
            Functions.createPointAt(1490, 540);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(8000);
            //Apply macro for B-Row
            Functions.createPointAt(1150, 700);//B1
            Functions.createPointAt(1300, 410);//B2
            SendKeys.SendWait("{ENTER}");
            Functions.createPointAt(1200, 550);
            SendKeys.SendWait("{ENTER}");
        }
        public static void divideLineOnBeam()
        {
            Functions.divideLine(3, true);
            Functions.createPointAt(1400, 620);//A1
            Functions.createPointAt(1540, 500);//A2
            Functions.createPointAt(1150, 600);//B1
            Functions.createPointAt(1290, 470);//B2
        }
        public static void createAdditionalBeam()
        {
            Functions.setProfSpecification("European", "IPE", "IPE200", "Beam", "TC", "Top");
            Functions.createPointAt(1170, 555);
            Functions.createPointAt(1430, 588);

            Functions.createPointAt(1220, 530);
            Functions.createPointAt(1470, 555);

            Functions.createPointAt(1260, 488);
            Functions.createPointAt(1500, 530);
            Functions.switchToView("AxiS_1");
        }
        public static void applyMacroOnAdditionalBeams()
        {
            Functions.applyMacro("AVV107", false, false, true);
            //Apply macro for right beam with additional beams
            Functions.createPointAt(650, 715);//Right Beam
            Functions.createPointAt(80, 600);//Left Beam
            SendKeys.SendWait("{ENTER}");
            Point p1 = new Point(630, 400);
            Point p2 = new Point(390, 670);
            UIActions.DragNDrop(p1, p2);
            SendKeys.SendWait("{ENTER}");

            //MyUtilities.WaitTime(8000);
            ////Apply macro for right beam with additional beams

            //SendKeys.SendWait("{ENTER}");
            //UIActions.DragNDrop(p1, p2);
            //SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(16000);
        }
        public static void switchtoorthographicview()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.canvas_view_menu_tab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Look["ID"]);
            UIActions.Click_Element(358, 222);
        }
        public static void expandpropertiesgridwin()
        {
            UIActions.Click_Element(1733, 455);
        }
        public static void expandmodelexplorer()
        {
            UIActions.Click_Element(181, 455);
        }
        public static void removegridfromview()
        {
            ButtonContorls.DoubleClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.LPW_Model_Explorer_Tab_Win_Grd_world["NAME"]);
            ButtonContorls.RightClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.LPW_Model_Explorer_Tab_Win_Grd_world_refgrd["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.LPW_Model_Explorer_Tab_Win_Grd_world_refgrd_contextmenu["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.LPW_Model_Explorer_Tab_Win_Grd_world_refgrd_contextmenu_remove["NAME"]);
        }
        public static void selectallcolumns()
        {
            Point p1 = new Point(660, 676); //Drag Point
            Point p2 = new Point(280, 555); //Drop Point
            UIActions.DragNDrop(p1, p2);
        }
        public static void modifypropertiesfromgrid(string modprofiletype, string moddesignation, string matgrade, string modmemfamily, string modmarkfamily)
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.RPW_Property_Grid_Tab["ID"]);
            UIActions.Click_Element(1783, 314);
            MyUtilities.WaitTime(3000);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(modprofiletype);
            SendKeys.SendWait("{ENTER}");


            // ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.RPW_Property_Grid_Tab["ID"]);
            UIActions.Click_Element(1782, 332);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(moddesignation);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(3000);


            UIActions.Click_Element(1789, 362);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(matgrade);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(1000);

            UIActions.Click_Element(1788, 298);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(modmemfamily);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(3000);

            UIActions.Click_Element(1787, 347);
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(modmarkfamily);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(3000);

        }
        public static void validateinfoprop()

        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Home_tab["ID"]);
            ButtonContorls.ClickButtoninAnySubWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, Locators.Home_Information_group_Member_button_parent["ID"], AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, Locators.Home_Information_group_Member_button_info["NAME"]);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(680, 540);
            MyUtilities.WaitTime(8000);

        }
        public static void closeinfoprop()
        {
            UIActions.Click_Element(1156, 791);
            MyUtilities.WaitTime(4000);
        }
        public static void messagewindow()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.ab_Ribbon_Tools_toolstab_Button["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.ab_Ribbon_Tools_messageWindow_but["ID"]);
            Point p1 = new Point(675, 381); //Drag Point
            Point p2 = new Point(1566, 377); //Drop Point
            UIActions.DragNDrop(p1, p2);
            MyUtilities.WaitTime(3000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.ab_Ribbon_Tools_messagetab["ID"]);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(1730, 550);
            SendKeys.SendWait("^a");
            UIActions.Mouse_RightClick(1730, 550);
            UIActions.Click_Element(1773, 583);


        } 
        public static void DefaultAdvancedmarking()
       
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab_advanced_marking_button["ID"]);
            MyUtilities.WaitTime(5000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_menu_tab_advanced_marking_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_advanced_marking_OK_button["NAME"]);
            
           // UIActions.Click_Element(136, 376);
            MyUtilities.WaitTime(10000);
        }
        public static void performunmark()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_Unmark_button["ID"]);
            MyUtilities.WaitTime(5000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Unmark_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Unmark_window_ok_button["NAME"]);
            //UIActions.Click_Element(435, 194);
            MyUtilities.WaitTime(9000);

        }
        public static void Advancedmarkingboltsandwelds()

        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab_advanced_marking_button["ID"]);
            //ButtonContorls.ClickButtoninAnySubWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, Locators.Output_menu_tab_advanced_marking_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_advanced_marking_OK_button["NAME"]);
            MyUtilities.WaitTime(6000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_menu_tab_advanced_marking_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_advanced_marking_more_button["NAME"]);

            //UIActions.Click_Element(590, 352);
            MyUtilities.WaitTime(4000);
            UIActions.Click_Element(48, 92);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(48, 112);
            MyUtilities.WaitTime(2000);
           //ButtonContorls.ClickButtoninAnyWindow(Locators.Output_menu_tab_marking_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_marking_select_bolts["NAME"]);
            UIActions.Click_Element(100, 93);
            MyUtilities.WaitTime(2000);
            //ButtonContorls.ClickButtoninAnyWindow(Locators.Output_menu_tab_marking_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_advanced_marking_more_typeofmarkingdropdown["NAME"]);
            UIActions.Click_Element(600, 80);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(548, 126);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(39, 488);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(138, 376);
            MyUtilities.WaitTime(10000);
        }
        public static void Revisionmarking()

        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab_advanced_marking_button["ID"]);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(459, 242);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(145, 374);
            MyUtilities.WaitTime(9000);
        }
        public static void createmidpoint()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Home_tab["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Home_Points_DropDown_Btn["ID"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Home_Points_cutinhalf["ID"]);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(263, 345);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(677, 345);
            SendKeys.SendWait("{ESC}");
        }
        public static void applystiffner(string macroname)
        {
            //ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Create_tab_button["ID"]);
            //MyUtilities.WaitTime(2000);
            //ButtonContorls.ClickButtoninAnyWindowwithDropDown(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
            //    AutomationElement.NameProperty, Locators.MacroExplorer_Btn["NAME"]);
            //MyUtilities.WaitTime(5000);
            //UIActions.Click_Element(700, 230);
            //MyUtilities.WaitTime(3000);
            //SendKeys.SendWait(macroname);
            //MyUtilities.WaitTime(4000);
            //UIActions.DoubleClick_Element(900, 377);
            //MyUtilities.WaitTime(4000);
            //UIActions.Click_Element(935, 490);
            //MyUtilities.WaitTime(4000);            
            Functions.applyMacro(macroname, false, false, false);
            UIActions.DoubleClick_Element(504, 358);//Select profile for stiffner
            MyUtilities.WaitTime(2000);
            UIActions.DoubleClick_Element(470, 341);
            MyUtilities.WaitTime(6000);

        }
        public static void automaticdrawings()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Locators.Output_menu_tab["ID"]);

            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Output_Drawing_Automatic_button["ID"]);
            MyUtilities.WaitTime(9000);
        }
        public static void assemblydrawings()
        {
            //Select assembly from drawing types
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty,AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_drawing_win_select_assembly["NAME"]);

           // UIActions.Click_Element(558, 142);
            MyUtilities.WaitTime(2000);

            //Change config settings for assembly
            UIActions.Click_Element(919, 140);
            MyUtilities.WaitTime(4000);

            //Select designation from assembly tree
            UIActions.DoubleClick_Element(400, 123);
            MyUtilities.WaitTime(1000);

            //Select undertitle
            UIActions.Click_Element(411, 202);
            MyUtilities.WaitTime(1000);

            //check undertitle from new line
            UIActions.Click_Element(700, 155);
            MyUtilities.WaitTime(1000);

            //click on pen dropdown
            UIActions.Click_Element(767, 155);
            MyUtilities.WaitTime(1000);

            //choose colour from pen dropdown
            UIActions.Click_Element(755, 235);
            MyUtilities.WaitTime(1000);

            //letter height dropdown
            UIActions.Click_Element(838, 155);
            MyUtilities.WaitTime(1000);

            //select letter height dropdown
            UIActions.Click_Element(815, 295);
            MyUtilities.WaitTime(1000);

            //Enter text in text seperator
            UIActions.Click_Element(878, 155);
            MyUtilities.WaitTime(1000);
            SendKeys.SendWait("FD = ");
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(1000);

            //Information dropdown
            UIActions.Click_Element(1242, 155);
            MyUtilities.WaitTime(1000);
            UIActions.DoubleClick_Element(1270, 378);
           // UIActions.Click_Element(1223, 365);
            //Select information
            UIActions.Click_Element(1223, 365);
            MyUtilities.WaitTime(1000);
            
            //Select frame and colour
            UIActions.Click_Element(1336, 155);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1321, 216);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1394, 155);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1389, 197);
            MyUtilities.WaitTime(2000);

            //Select designation from assembly tree
            UIActions.DoubleClick_Element(400, 123);
            MyUtilities.WaitTime(2000);

            //Select Model from assembly tree
            UIActions.DoubleClick_Element(400, 201);
            MyUtilities.WaitTime(2000);

            //Select Location of section from assembly tree
            UIActions.Click_Element(400, 221);
            MyUtilities.WaitTime(2000);

            //Select Vertically parts dropdown from Rep-Dim locaion tab
            UIActions.Click_Element(1073, 140);
            MyUtilities.WaitTime(1000);

            //Select front view from Vertically parts dropdown
            UIActions.Click_Element(1073, 160);
            MyUtilities.WaitTime(2000);

            //Select Model from assembly tree
            UIActions.DoubleClick_Element(400, 201);
            MyUtilities.WaitTime(2000);

            //Select paper from assembly tree
            UIActions.Click_Element(400, 221);
            MyUtilities.WaitTime(2000);

            //Select button in Frames tab
            UIActions.Click_Element(773, 162);
            MyUtilities.WaitTime(2000);

            //Select frame_dr in Frames window
            UIActions.Click_Element(875, 325);
            MyUtilities.WaitTime(2000);

            //ok button in Frames window
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_Configuration_assembly_drawing_Paper_Frame_win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_Configuration_assembly_drawing_Paper_Frame_win_okbut["NAME"]);
            //UIActions.DoubleClick_Element(, );
            MyUtilities.WaitTime(4000);

            //Select Graphics tab from drawing frame
            UIActions.Click_Element(780, 92);
            MyUtilities.WaitTime(2000);

            //Checkbox for Titleblock from drawing frame
            UIActions.Click_Element(714, 498);
            MyUtilities.WaitTime(2000);

            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_Configuration_assembly_drawing_window["NAME"], AutomationElement.NameProperty,AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_Configuration_assembly_drawing_window_okbutton["NAME"]);
            MyUtilities.WaitTime(2000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty,AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_drawing_win_execute_button["NAME"]);
            MyUtilities.WaitTime(8000);           

        }
        public static void shopdrawings()
        {
            //Select shop from drawing types
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic__select_shop["NAME"]);
            MyUtilities.WaitTime(2000);
            //Change config settings for shop
            UIActions.Click_Element(919, 140);
            MyUtilities.WaitTime(3000);
            
            //Selct designation under shop drawing tree
            UIActions.DoubleClick_Element(400, 122);
            MyUtilities.WaitTime(2000);

            //Selct understitle from designation under shop drawing tree
            UIActions.Click_Element(400, 205);
            MyUtilities.WaitTime(2000);

            //Checkbox for undertitle
            UIActions.Click_Element(699, 155);
            MyUtilities.WaitTime(2000);

            //Ok button in config shop drawing window
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_Configuration_shop_drawing_window["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_Configuration_shop_drawing_window_okbutton["NAME"]);

            //Execute button in create automatic drawings window
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_drawing_win_execute_button["NAME"]);
            MyUtilities.WaitTime(9000);


        }
        public static void ncdstvdrawing()
        {
            //Select ncdstv interface from drawing types
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_create_automatic_drawing_ncdstv["NAME"]);
            
            //Execute button in create automatic drawings window
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_drawing_win_execute_button["NAME"]);
            MyUtilities.WaitTime(9000);


        }
        public static void closedrawingswindow()
        {
            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_Drawing_Automatic_drawing_win["NAME"], AutomationElement.NameProperty, AutomationElement.NameProperty, Locators.Output_Drawing_Automatic_drawing_win_close_button["NAME"]);
            MyUtilities.WaitTime(4000);
        }
        public static void validatedrawingsinboview(string jobName)
        {
            //click on Project menu tab
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.project_tab_but["ID"]);
            //Boview
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.project_tab_but_navigation_win_boview["ID"]);
            MyUtilities.WaitTime(4000);

            //Maximize boview window
            ButtonContorls.ClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            AutomationElement.NameProperty, "Maximize");
            MyUtilities.WaitTime(2000);

            //Select ass folder

            ButtonContorls.DoubleClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
        AutomationElement.NameProperty, "ass");
            MyUtilities.WaitTime(2000);

            //select drawing from ass folder
            //ButtonContorls.ClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            // AutomationElement.NameProperty, "p0100001.bmf_");

            UIActions.Click_Element(284, 268);
            MyUtilities.WaitTime(5000);

            //select second drawing from ass folder
            //ButtonContorls.ClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            //AutomationElement.NameProperty, "p0100003.bmf_");
            UIActions.Click_Element(370, 303);
            MyUtilities.WaitTime(5000);
            UIActions.DoubleClick_Element(140, 225);
            // ButtonContorls.DoubleClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] ", AutomationElement.NameProperty,
            //  AutomationElement.NameProperty, "ass");

            //Select shop folder
            UIActions.DoubleClick_Element(140, 240);
            //    ButtonContorls.DoubleClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            //AutomationElement.NameProperty, "shop");
            MyUtilities.WaitTime(2000);

            //select drawing from shop folder
            // ButtonContorls.ClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            //AutomationElement.NameProperty, "s0100001.bmf_");
            UIActions.Click_Element(200, 263);
            MyUtilities.WaitTime(5000);

            //select second drawing from shop folder
            //ButtonContorls.ClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            //AutomationElement.NameProperty, "s0100003.bmf_");
            UIActions.Click_Element(300, 281);
            MyUtilities.WaitTime(5000);
            UIActions.DoubleClick_Element(140, 240);
            MyUtilities.WaitTime(2000);
            // ButtonContorls.DoubleClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] ", AutomationElement.NameProperty,
            // AutomationElement.NameProperty, "shop");

            //close boview

            UIActions.Click_Element(1900, 10);
            //ButtonContorls.ClickButtoninAnyWindow("AVEVA Bocad BoView (32.20181126) - en [32] [C:/AVEVA/bocad/Projects_3_2_2/BSP/boc_ALL/shekhar.verma/" + jobName + "/plots] - Printer settings", AutomationElement.NameProperty,
            //AutomationElement.NameProperty, "Close");
            MyUtilities.WaitTime(5000);


        }
        public static void Nesteddrawingcreation()
        {
            //creation of Nested drawing
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Output_tab["ID"]);
            MyUtilities.WaitTime(3000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Output_Nested_drawing_btn["ID"]);
            MyUtilities.WaitTime(3000);

            //UIActions.DoubleClick_Element(617, 74);//Clicking on Nested drawing file name edit field
            //MyUtilities.WaitTime(3000);
            ////SendKeys.Equals("Nested Drawing");
            //UIActions.Click_Element(573, 532);
            ////Copy Perspective view in Nested drawing
            //MyUtilities.WaitTime(3000);

            ButtonContorls.ClickButtoninAnyWindow(Locators.Output_NestedDrawing_Win["NAME"], AutomationElement.NameProperty,
                AutomationElement.NameProperty, Locators.Output_NestedDrawing_Win_Ok_Btn["NAME"]);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                    AutomationElement.NameProperty, "plots/sammel.bmfw");

            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Output_Nested_drawing_tab["ID"]);
            MyUtilities.WaitTime(4000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Nested_drawing_Copy_btn["ID"]);
            UIActions.Click_Element(1354, 444);
            MyUtilities.WaitTime(3000);
            SendKeys.SendWait("{ENTER}");
            UIActions.Click_Element(276, 472);



            //Copy Model view in to Nested Drawing
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
               AutomationElement.AutomationIdProperty, Locators.View_btn["ID"]);
            MyUtilities.WaitTime(3000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Model_View_btn["ID"]);
            MyUtilities.WaitTime(3000);
            UIActions.Control_Click(530, 75);
            MyUtilities.WaitTime(3000);
            UIActions.Control_Click(534, 184);
            MyUtilities.WaitTime(3000);
            UIActions.Control_Click(221, 759);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(536, 369);
            MyUtilities.WaitTime(3000);
            SendKeys.SendWait("25");
            UIActions.Click_Element(525, 390);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(458, 538);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(555, 651);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(555, 651);
            //Open representation settings in nested view



            SendKeys.SendWait("{ESC}");
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Nested_drawing_tab_btn["ID"]);
            MyUtilities.WaitTime(3000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Nested_representation_setting_btn["ID"]);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(605, 468);
            MyUtilities.WaitTime(3000);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(875, 123);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(833, 182);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(897, 145);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(824, 188);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(1034, 263);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(1002, 293);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(663, 631);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(833, 462);
            SendKeys.SendWait("Setting1");
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(690, 490);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(662, 652);
            MyUtilities.WaitTime(3000);
            //Apply settings to Perspective view
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Nested_drawing_tab_btn["ID"]);
            MyUtilities.WaitTime(3000);
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Nested_representation_setting_btn["ID"]);
            MyUtilities.WaitTime(3000);
            UIActions.DoubleClick_Element(329, 362);
            MyUtilities.WaitTime(3000);
            SendKeys.SendWait("{ENTER}");
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(433, 632);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(415, 230);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(396, 477);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(369, 653);
            MyUtilities.WaitTime(3000);
            //Save Nested Drawing and close
            ButtonContorls.ClickButtoninAnyWindow(Locators.Job_MainWindow["ID"], AutomationElement.AutomationIdProperty,
                AutomationElement.AutomationIdProperty, Locators.Nested_drawing_save_btn["ID"]);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(534, 992);
            MyUtilities.WaitTime(3000);
            UIActions.Click_Element(886, 554);

        }
    }
    }



