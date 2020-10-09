using BocadAPITestsSolution.Core;
using System.Windows.Automation;

namespace BocadUITestsSolution.UIControls
{
    public class CheckBoxControls
    {
        public static void UnCheckAnyCheckBoxItem(string windowname, AutomationProperty windowprop, AutomationProperty checkboxprop, string checkboxitem)
        {

            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(checkboxprop, checkboxitem);
            AutomationElement checkboxitem1 = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            

            TogglePattern tp = checkboxitem1.GetCurrentPattern(TogglePattern.Pattern) as TogglePattern;
            if (tp.Current.ToggleState == ToggleState.On) // not on? click it
            {
                UIActions.Click_Element(checkboxitem1);
            }

        }

        public static void CheckAnyCheckBoxItem(string windowname, AutomationProperty windowprop, AutomationProperty checkboxprop, string checkBoxItem)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(checkboxprop, checkBoxItem);
            AutomationElement checkboxitem = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);

            TogglePattern tp = checkboxitem.GetCurrentPattern(TogglePattern.Pattern) as TogglePattern;
            if (tp.Current.ToggleState == ToggleState.Off) // not on? click it
            {
                UIActions.Click_Element(checkboxitem);
            }
        }


        public static void UnCheckManyCheckBoxItems(string windowname, AutomationProperty windowprop, ControlType checkboxprop, int n,int n1)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, checkboxprop);
            AutomationElementCollection checkboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = n1; i <= n; i++)
            {
                AutomationElement item1 = checkboxes[i];
                TogglePattern tp = item1.GetCurrentPattern(TogglePattern.Pattern) as TogglePattern;
                if (tp.Current.ToggleState == ToggleState.On) // not on? click it
                {
                    UIActions.Click_Element(item1);
                }
            }
        }

        public static void CheckManyCheckBoxItems(string windowname, AutomationProperty windowprop, ControlType checkboxprop, int n)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, checkboxprop);
            AutomationElementCollection checkboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = 0; i <= n; i++)
            {
                AutomationElement item1 = checkboxes[i];
                TogglePattern tp = item1.GetCurrentPattern(TogglePattern.Pattern) as TogglePattern;
                if (tp.Current.ToggleState == ToggleState.Off) // not on? click it
                {
                    UIActions.Click_Element(item1);
                }
            }
        }
    }
}
