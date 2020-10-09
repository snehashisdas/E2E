using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace BocadUITestsSolution.UIControls
{
    public class Miscellanous
    {

        public string TextfromTableNextSiblingElement(string windowname, AutomationProperty windowprop, AutomationProperty infoprop, string nodelement)
        {
            //To Get the Member --> Info --> Text
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(infoprop, nodelement);
            AutomationElement infoproperty = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            TreeWalker tWalker = TreeWalker.ControlViewWalker;
            AutomationElement aaElemParent = tWalker.GetNextSibling(infoproperty);
            string val = aaElemParent.Current.Name;
            return val;

        }

    }
}
