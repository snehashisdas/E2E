using BocadAPITestsSolution.Core;
using BocadUITestsSolution.ObjectRepos;
using BocadUITestsSolution.UIControls;
using System.Windows.Automation;

namespace BocadUITestsSolution.Prerequisite
{
    public class Misc
    {
        //Creation of New Phase
        public static void CreationofPhase()
        {
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.Tb_PhaseandGrid);
            ButtonContorls.ClickButtoninAnyWindow(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.NameProperty, MainRibbonElements.SbTb_CreateIndividual);
            //Creation of Phase
            MyUtilities.WaitTime(2000);
            CheckBoxControls.UnCheckAnyCheckBoxItem(Tab_PhaseandGridElements.Win_CreateIndividualPhase, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_PhaseandGridElements.ChkBx_AssociateViewtoPhase);
            ButtonContorls.ClickButtoninAnyWindow(Tab_PhaseandGridElements.Win_CreateIndividualPhase, AutomationElement.NameProperty, AutomationElement.NameProperty, Tab_PhaseandGridElements.Btn_OK);
            

        }

        //Chaging the Phase
        public static void ChangeofPhase(string phasename)
        {
            ComboBoxControls.SelecAnyComboboxitem(MainRibbonElements.Main_Window, AutomationElement.AutomationIdProperty, AutomationElement.AutomationIdProperty, MainRibbonElements.CmBx_PhaseDropdown, phasename);
        }

    }
}
