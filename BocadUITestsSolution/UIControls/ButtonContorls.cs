using BocadAPITestsSolution.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace BocadUITestsSolution.UIControls
{
    public class ButtonContorls
    {
        public static void ClickButtoninAnyWindow(string windowname, AutomationProperty windowprop, AutomationProperty buttonprop, string anybutton)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(buttonprop, anybutton);
            AutomationElement button = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            UIActions.Click_Element(button);
            
        }

        public static void ClickButtoninAnyWindowwithDropDown(string windowname, AutomationProperty windowprop, AutomationProperty buttonprop, string anybutton)
        {
            MyUtilities.DelayFor(2000);

            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(buttonprop, anybutton);
            AutomationElement okbutton = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            var r = okbutton.Current.BoundingRectangle;
            double x = r.X;
            double y = r.Y;

            int value1 = (int)x;
            int value2 = (int)y;
            UIActions.Click_Element(value1 + 10, value2 + 23);
            MyUtilities.DelayFor(1000);

        }
        public static void DoubleClickButtoninAnyWindow(string windowname, AutomationProperty windowprop, AutomationProperty buttonprop, string anybutton)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(buttonprop, anybutton);
            AutomationElement button = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            UIActions.DoubleClick_Element(button);

        }


        public static void ClickManyButtons(string windowname, AutomationProperty windowprop, ControlType buttonprop, int n,int j)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, buttonprop);
            AutomationElementCollection buttons = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = j; i < n; i++)
            {
                AutomationElement item1 = buttons[i];
                
                    UIActions.Click_Element(item1);
                
            }
        }

    }
}
