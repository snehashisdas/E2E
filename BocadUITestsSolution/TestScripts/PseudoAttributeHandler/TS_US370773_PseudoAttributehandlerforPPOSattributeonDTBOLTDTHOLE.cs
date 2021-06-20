using BocadAPITestsSolution.Core;
using BocadUITestsSolution.ObjectRepos;
using BocadUITestsSolution.UIControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace BocadUITestsSolution.TestScripts.PseudoAttributeHandler
{
    //[TestClass]
    public class TS_US370773_PseudoAttributehandlerforPPOSattributeonDTBOLTDTHOLE
    {
        [TestMethod]
        public void US370773_PseudoAttributehandlerforPPOSattributeonDTBOLTDTHOLE()
        {
            Task.Delay(1000).Wait();
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, "Maximize");
            //Opening the Perspective View
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_View);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Perspective);
            Task.Delay(1000).Wait();

            ButtonContorls.ClickButtoninAnyWindow(Tab_ViewElements.Win_PerspectiveRepresentations, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_ViewElements.Btn_OK);
            Task.Delay(1000).Wait();
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_GlobalPersView);
            

            //Creation of Plate to create a Hole
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.Tb_Create);
            ButtonContorls.ClickButtoninAnyWindowwithDropDown(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_Plate);

            TestStack.White.InputDevices.Mouse.Instance.Click(new System.Windows.Point(1067, 852));
            TestStack.White.InputDevices.Mouse.Instance.Click(new System.Windows.Point(1067, 735));
            TestStack.White.InputDevices.Mouse.Instance.Click(new System.Windows.Point(796, 698));
            Task.Delay(1000).Wait();
            TestStack.White.InputDevices.Mouse.Instance.DoubleClick(new System.Windows.Point(775, 814));

            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Home);
            UIActions.Click_Element(327, 108);
            MyUtilities.DelayFor(1000);
            UIActions.Click_Element(181, 448);

            MyUtilities.DelayFor(1000);

            //To create a cut in half point for the plate
           
            UIActions.Mouse_RightClick(832, 455);
            MyUtilities.DelayFor(1000);

            //To create a cut in half point
            CheckBoxControls.CheckAnyCheckBoxItem(Tab_HomeElements.Win_PointsSetting1, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_HomeElements.ChkBx_withZcoordinates);
            ButtonContorls.ClickButtoninAnyWindow(Tab_HomeElements.Win_PointsSetting1, AutomationElement.NameProperty, AutomationElement.NameProperty,Tab_ViewElements.Btn_OK);

            UIActions.Click_Element(777, 815);
            UIActions.Click_Element(1066, 735);


            //Creation of Hole Connection
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.Tb_Create);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_HoleThread);
            


            UIActions.DoubleClick_Element(922, 775);
            MyUtilities.DelayFor(1000);
            UIActions.DoubleClick_Element(862, 800);


          

            string DtJobName = "DTJOB " + "TEST" + " ";
            //Selecting the Hole in the Model Explorer
            TreeViewControls.ExpandAnyModelExpElements(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tv_Dtworld);
            TreeViewControls.ExpandAnyModelExpElements(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, DtJobName);
            TreeViewControls.ExpandAnyModelExpElements(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tv_FirstPhase);
            TreeViewControls.ExpandAnyModelExpElements(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tv_DTMain);
            TreeViewControls.ExpandAnyModelExpElements(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tv_DTPlat);
            TreeViewControls.ToSelectModelExpNodeElement(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tv_DTHole);
            //Scenario 1 : PPOS Attribute for Hole
            Task.Delay(1000).Wait();
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_Tools);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_CommandWindow);
            Task.Delay(1000).Wait();
            TextBoxControls.SetTextinAnyTextBox(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Tab_ToolsElements.TxtBx_CommandWindow,"q PPOS");
            TestStack.White.InputDevices.Keyboard.Instance.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.RETURN);
            string holeppos=TextBoxControls.GetTextfromAnyTextBox(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Tab_ToolsElements.TxtBx_CommandWindow);

            //Scenario 2 : PPOS Attribute for Plate
           TreeViewControls.ToSelectModelExpNodeElement(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tv_DTPlat);
            TextBoxControls.SetTextinAnyTextBox(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, Tab_ToolsElements.TxtBx_CommandWindow, "q PPOS");
            TestStack.White.InputDevices.Keyboard.Instance.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.RETURN);


            //Scenario 3 : PPOS Attribute for Bolt
            



        }
    }
}
