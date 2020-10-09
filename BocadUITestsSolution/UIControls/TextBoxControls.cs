using System.Windows.Automation;
using TestStack.White.InputDevices;

namespace BocadUITestsSolution.UIControls
{
    public class TextBoxControls
    {

        public static void SetTextinAnyTextBox(string windowname, AutomationProperty windowprop, AutomationProperty textboxprop, string textbox, string text)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(textboxprop, textbox);
            AutomationElement okbutton = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            ValuePattern vp = okbutton.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
            vp.SetValue(text);

        }

        public static string GetTextfromAnyTextBox(string windowname, AutomationProperty windowprop, AutomationProperty textboxprop, string textbox)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(textboxprop, textbox);
            AutomationElement okbutton = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            ValuePattern vp = okbutton.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
            string val = vp.Current.Value;
            return val;
        }



        public static void SetTextiManyTextBoxes(string windowname, AutomationProperty windowprop, ControlType textboxprop, int n)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, textboxprop);
            AutomationElementCollection textboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = 1; i <= n; i++)
            {
                AutomationElement item2 = textboxes[i];
                ValuePattern vp = item2.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;


                if (i == 1)
                {
                    vp.SetValue("Phase 1");
                }
                else if (i == 3)
                {
                    vp.SetValue("Phase 2");
                }

                else if (i == 5)
                {
                    vp.SetValue("Phase 3");
                }

            }
        }

        public static void SetTextthroughKeyBoardinAnyTextBoxBasedonIndex(string windowname, AutomationProperty windowprop, ControlType textboxprop, int index,string text)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, textboxprop);
            AutomationElementCollection textboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = 0; i <= textboxes.Count; i++)
            {
                AutomationElement item2 = textboxes[index];
               // ValuePattern vp = item2.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                item2.GetClickablePoint();
                Keyboard.Instance.Enter(text);
            }
        }

        public static void SetTextinAnyTextBoxBasedonIndex(string windowname, AutomationProperty windowprop, ControlType textboxprop, int index, string text)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, textboxprop);
            AutomationElementCollection textboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = 0; i <= textboxes.Count; i++)
            {
                AutomationElement item2 = textboxes[index];
                 ValuePattern vp = item2.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                vp.SetValue(text);
            }
        }


    }
}
