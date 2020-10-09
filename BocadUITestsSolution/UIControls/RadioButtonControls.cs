using BocadAPITestsSolution.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace BocadUITestsSolution.UIControls
{
    public class RadioButtonControls
    {
        public static void SelectAnyRadioButton(string windowname, AutomationProperty windowprop, AutomationProperty radiobuttonprop, string radioButtonItem,bool value)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(radiobuttonprop, radioButtonItem);
            AutomationElement radiobuttonitem = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            SelectionItemPattern pattern = radiobuttonitem.GetCurrentPattern(SelectionItemPattern.Pattern) as SelectionItemPattern;

            //If is true set it to false - false to true
            if (pattern.Current.IsSelected == value)
            {
                UIActions.Click_Element(radiobuttonitem);
            }

        }


    }
}
