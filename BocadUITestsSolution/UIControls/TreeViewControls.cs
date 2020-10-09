

using BocadAPITestsSolution.Core;
using System.Windows.Automation;

namespace BocadUITestsSolution.UIControls
{
    public class TreeViewControls
    {
        public static void ExpandAnyModelExpElements(string windowname, AutomationProperty windowprop, AutomationProperty nodeelementprop, string nodelement)
        {
            MyUtilities.DelayFor(2000);

            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(nodeelementprop, nodelement);
            AutomationElement okbutton = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            ExpandCollapsePattern pattern = okbutton.GetCurrentPattern(ExpandCollapsePattern.Pattern) as ExpandCollapsePattern;
            if (pattern.Current.ExpandCollapseState == ExpandCollapseState.Collapsed)
            {
                pattern.Expand();
            }

        }


        public static void ToSelectModelExpNodeElement(string windowname, AutomationProperty windowprop, AutomationProperty nodeelementprop, string nodelement)
        {
            MyUtilities.DelayFor(2000);

            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(nodeelementprop, nodelement);
            AutomationElement button = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            UIActions.Click_Element(button);

        }
    }
}
