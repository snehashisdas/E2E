using BocadAPITestsSolution.Core;
using BocadUITestsSolution.Core;
using BocadUITestsSolution.ObjectRepos;
using BocadUITestsSolution.Prerequisite;
using BocadUITestsSolution.UIControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Automation;

namespace BocadUITestsSolution.TestScripts.MarkingScenarios
{
    [TestClass]
    public class TS1_MarkingScenario 
    {
        Reporting Rep = new Reporting();
        AIValLibrary ailib = new AIValLibrary();
        [TestMethod]
        public void MarkingScenario1()
        {
            





            //MyUtilities.WaitTime(4000);
            //AIValLibrary.CaptureBitmap(673, 620, 35, 100, "sample1");
            //MyUtilities.WaitTime(4000);




            //MyUtilities.WaitTime(4000);
            //AIValLibrary.CaptureBitmap(762,222,100,35,"sample");
            //MyUtilities.WaitTime(4000);
            Rep.IntitialzeReporting();
            Rep.f_createTest("Bocad_MarkingScenario_PrerequsiteReaction");
     
            //To login into the application
            Login.CreationofNewJob();

            //Creation of Phases
            Misc.CreationofPhase();
            Misc.CreationofPhase();

            //View --> Member Colour
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_View);

            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_MemberColour);
            MyUtilities.WaitTime(2000);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_MemberColour);

            //To give the settings for the member colours in Phase
            CheckBoxControls.UnCheckManyCheckBoxItems(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.CheckBox, 30,0);
            CheckBoxControls.CheckManyCheckBoxItems(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.CheckBox, 2);
            TextBoxControls.SetTextiManyTextBoxes(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.Edit, 6);

            //Phase 1 Settings
            ButtonContorls.ClickManyButtons(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.Button, 4,3);
            MyUtilities.WaitTime(4000);
            CheckBoxControls.CheckManyCheckBoxItems(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, ControlType.CheckBox, 0);
            CheckBoxControls.UnCheckManyCheckBoxItems(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, ControlType.CheckBox, 8, 8);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_PhaseNumber);
            MyUtilities.WaitTime(3000);
            ButtonContorls.DoubleClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_Phase1);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);

            //Phase 2 Settings
            MyUtilities.WaitTime(2000);
            ButtonContorls.ClickManyButtons(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.Button, 6, 5);
            MyUtilities.WaitTime(4000);
            CheckBoxControls.CheckManyCheckBoxItems(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, ControlType.CheckBox, 0);
            CheckBoxControls.UnCheckManyCheckBoxItems(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, ControlType.CheckBox, 8, 8);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_PhaseNumber);
            MyUtilities.WaitTime(3000);
            ButtonContorls.DoubleClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_Phase2);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);


            //Phase 3 Settings
            MyUtilities.WaitTime(2000);
            ButtonContorls.ClickManyButtons(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.Button, 8, 7);
            MyUtilities.WaitTime(4000);
            CheckBoxControls.CheckManyCheckBoxItems(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, ControlType.CheckBox, 0);
            CheckBoxControls.UnCheckManyCheckBoxItems(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, ControlType.CheckBox, 8, 8);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_PhaseNumber);
            MyUtilities.WaitTime(3000);
            ButtonContorls.DoubleClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_Phase3);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberFilter, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);

            //Changing the Colors
            ComboBoxControls.SelectAnyListIteminCombobox(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.ComboBox, 0, new System.Windows.Point(1058, 174), new System.Windows.Point(1060, 139), 1007, 235, 0);
            MyUtilities.WaitTime(2000);
            ComboBoxControls.SelectAnyListIteminCombobox(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.ComboBox, 5, new System.Windows.Point(1061, 204), new System.Windows.Point(1061, 160), 1038, 321, 5);

            ComboBoxControls.SelectAnyListIteminCombobox(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.ComboBox, 10, new System.Windows.Point(1059, 232), new System.Windows.Point(1059, 184), 1029, 185, 10);

            ComboBoxControls.SelectAnyListIteminCombobox(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, ControlType.ComboBox, 3, new System.Windows.Point(0, 0), new System.Windows.Point(0, 0), 1550, 202, 3);
            MyUtilities.WaitTime(1000);
            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_MemberColour, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);
            //Changing the phase and creating the profiles
            MyUtilities.WaitTime(1000);
            Misc.ChangeofPhase("1 Steel - ");



            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Grid_0_Axis1);
            UIActions.Click_Element(150, 33);
            //Creation of Profile
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Create);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Profile);

            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_ProfileSpecification, "European Standard Profiles");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_GenericType, "HEA Profile");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Profile, "HE240A");
            
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Designation, "COLUMN");
            RadioButtonControls.SelectAnyRadioButton(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.RdBtn_myML, false);
            RadioButtonControls.SelectAnyRadioButton(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.RdBtn_myMC, false);
            MyUtilities.WaitTime(1000);
            //Creation of three profiles using two points
            UIActions.Click_Element(418, 715);
            UIActions.DoubleClick_Element(416, 190);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(942, 715);
            UIActions.DoubleClick_Element(941, 189);
            
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1468, 715);
            UIActions.DoubleClick_Element(1468, 296);

            
            //

            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_GenericType, "IPE Profiles");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Profile, "IPE240");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Designation, "Beam");
            RadioButtonControls.SelectAnyRadioButton(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.RdBtn_myML, false);
            UIActions.Click_Element(1869, 88);
            MyUtilities.WaitTime(2000);
            //Creation of remaining profiles in phase 1

            UIActions.Click_Element(418, 192);
            UIActions.Click_Element(941, 192);
            TestStack.White.InputDevices.Keyboard.Instance.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.RETURN);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(417, 295);
            UIActions.DoubleClick_Element(941, 294);

            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(417, 504);
            UIActions.DoubleClick_Element(943, 504);


            //Creation of Profiles in Phase 2
            Misc.ChangeofPhase("2 Phase2 - ");


            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Profile);
            UIActions.Click_Element(942, 504);
            UIActions.DoubleClick_Element(1466, 504);

            //Navigate to Home to create intersection points to create next profile
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Home);

            UIActions.Click_Element(327, 104);
            UIActions.Click_Element(178, 450);

            //dividingpoints in view
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(941, 504);
            UIActions.Click_Element(941,297);

            UIActions.Click_Element(1466, 507);
            UIActions.Click_Element(1468, 297);

            UIActions.Click_Element(148, 33);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Create);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Profile);

            UIActions.Click_Element(942, 401);
            UIActions.DoubleClick_Element(1466, 399);


            //Create the profile

            //ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_GenericType, "HEA Profile");
            //ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Profile, "HE240A");

            //ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Designation, "COLUMN");
            //RadioButtonControls.SelectAnyRadioButton(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.RdBtn_myMC, false);
            MyUtilities.WaitTime(1000);

            //Now creating Profiles in Phase 3
            Misc.ChangeofPhase("3 Phase3 - ");
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Home);
            
            UIActions.Click_Element(89, 94);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(328, 107);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(94, 85);
            MyUtilities.WaitTime(1000);
            UIActions.Control_Mouse_RightClick(877,506);

            TextBoxControls.SetTextinAnyTextBoxBasedonIndex(Tab_HomeElements.Win_AddPoints, AutomationElement.NameProperty, ControlType.Edit, 0, "7:-500");
            TextBoxControls.SetTextinAnyTextBoxBasedonIndex(Tab_HomeElements.Win_AddPoints, AutomationElement.NameProperty, ControlType.Edit, 1, "0");
            ButtonContorls.ClickButtoninAnyWindow(Tab_HomeElements.Win_AddPoints, AutomationElement.NameProperty, AutomationElement.NameProperty, MainRibbonElements.Btn_Ok);
            UIActions.DoubleClick_Element(1468, 294);
            MyUtilities.WaitTime(1000);
            UIActions.DoubleClick_Element(1468, 191);

            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(96, 94);
            UIActions.Control_Mouse_RightClick(877, 506);
            MyUtilities.WaitTime(1000);
            TextBoxControls.SetTextinAnyTextBoxBasedonIndex(Tab_HomeElements.Win_AddPoints, AutomationElement.NameProperty, ControlType.Edit, 0, "0");
            TextBoxControls.SetTextinAnyTextBoxBasedonIndex(Tab_HomeElements.Win_AddPoints, AutomationElement.NameProperty, ControlType.Edit, 1, "1:500");
            ButtonContorls.ClickButtoninAnyWindow(Tab_HomeElements.Win_AddPoints, AutomationElement.NameProperty, AutomationElement.NameProperty, MainRibbonElements.Btn_Ok);
            UIActions.DoubleClick_Element(1415, 296);
            //Creation of profiles
            
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.Tb_Create);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Profile);

            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_GenericType, "HEA Profile");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Profile, "HE200A");

            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Designation, "COLUMN");
            RadioButtonControls.SelectAnyRadioButton(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.RdBtn_myMC, false);

            UIActions.Click_Element(1152, 294);
            UIActions.DoubleClick_Element(1152, 190);


            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Profile);

            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_ProfileSpecification, "European Standard Profiles");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_GenericType, "Equal  Angle");
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Profile, "L20x20x3");

            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_Designation, "Angle");
            RadioButtonControls.SelectAnyRadioButton(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.RdBtn_myMC, false);
            MyUtilities.WaitTime(1000);
            //Creation of Profiles
            UIActions.Click_Element(1415, 295);
            UIActions.DoubleClick_Element(1414, 242);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1362, 295);
            UIActions.DoubleClick_Element(1362, 191);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1308, 295);
            UIActions.DoubleClick_Element(1308, 190);

            //Delete the member and copy
            MyUtilities.WaitTime(1000);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Home);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.SbTb_DeletMember);
            MyUtilities.WaitTime(1000);
            UIActions.DoubleClick_Element(416, 656);

            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(942, 638);
            MyUtilities.WaitTime(1000);
            UIActions.Mouse_RightClick(942, 638);
            MyUtilities.WaitTime(1000);
            UIActions.Click_Element(1030, 623);
            MyUtilities.WaitTime(1000);
            MiscFunctions.InputSimulator(5, 5);


            UIActions.Control_Mouse_RightClick(632, 543);
            MyUtilities.WaitTime(1000);
            TextBoxControls.SetTextinAnyTextBoxBasedonIndex(MainRibbonElements.Win_CopyviaDimension, AutomationElement.NameProperty, ControlType.Edit, 0, "-5000");
            TextBoxControls.SetTextinAnyTextBoxBasedonIndex(MainRibbonElements.Win_CopyviaDimension, AutomationElement.NameProperty, ControlType.Edit, 1, "0");
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Win_CopyviaDimension, AutomationElement.NameProperty, AutomationElement.NameProperty, MainRibbonElements.Btn_Ok);
            UIActions.DoubleClick_Element(940, 654);
            MyUtilities.WaitTime(1000);

            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Viewport);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Calculate);


            MyUtilities.WaitTime(4000);
            ailib.CaptureBitmap(126, 155, 1450, 820, "MS1Actual");
            MyUtilities.WaitTime(1000);

            string sExtension = "bmp";
            string[] images = new string[4];
            images[0] = @"D:\Test\BMP\ExpectedImages\MS1." + sExtension;
            images[1] = @"D:\Test\BMP\ActualImages\MS1Actual." + sExtension;
            images[2] = @"D:\Test\BMP\Comparision\MS1Diff." + sExtension;

            double percentage1 = ailib.CompareIMG(images);



            //Creating the Report
            Reporting.extent.Flush();

        }
    }
}
