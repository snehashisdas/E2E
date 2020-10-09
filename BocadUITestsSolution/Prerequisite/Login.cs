using BocadAPITestsSolution.Core;
using BocadUITestsSolution.Core;
using BocadUITestsSolution.ObjectRepos;
using BocadUITestsSolution.UIControls;
using System.Windows.Automation;
using TestStack.White;

namespace BocadUITestsSolution.Prerequisite
{
    public class Login
    {

        public static void CreationofNewJob()
        {

            Application app = Application.Launch(@"C:\AVEVA\bocad\3_2_2\bocrun\aveva_bocad.bat");

            MyUtilities.WaitTime(6000);
            TextBoxControls.SetTextinAnyTextBox(LoginElements.Win_Login, AutomationElement.NameProperty, AutomationElement.AutomationIdProperty, LoginElements.TxtBx_UserName, "SYSTEM");
            TextBoxControls.SetTextinAnyTextBox(LoginElements.Win_Login, AutomationElement.NameProperty, AutomationElement.AutomationIdProperty, LoginElements.TxtBx_Password, "XXXXXX");
            ButtonContorls.ClickButtoninAnyWindow(LoginElements.Win_Login, AutomationElement.NameProperty, AutomationElement.AutomationIdProperty, LoginElements.Btn_StrcuturalDesign);
            MyUtilities.WaitTime(20000);

            //Creation of New Job
            ButtonContorls.ClickButtoninAnyWindow(LoginElements.Win_MainWindow, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, LoginElements.LstItm_NewJob);
            string JobName = MiscFunctions.GenerateCoupon(7);
            TextBoxControls.SetTextinAnyTextBox(LoginElements.Win_MainWindow, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, LoginElements.TxtBx_JobName, JobName);
            ButtonContorls.ClickButtoninAnyWindow(LoginElements.Win_MainWindow, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, LoginElements.Btn_Create);
            MyUtilities.WaitTime(6000);
            //Creation of Grid
            ButtonContorls.ClickButtoninAnyWindow(LoginElements.Win_CreateGrid, AutomationElement.NameProperty, AutomationElement.NameProperty, LoginElements.Btn_Ok);
            MyUtilities.WaitTime(2000);
            ButtonContorls.DoubleClickButtoninAnyWindow(LoginElements.Win_ChangeMainView, AutomationElement.NameProperty, AutomationElement.NameProperty, LoginElements.Lst_Axis1);

        }




    }
}
