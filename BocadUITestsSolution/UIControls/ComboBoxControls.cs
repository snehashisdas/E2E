using BocadAPITestsSolution.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.InputDevices;

namespace BocadUITestsSolution.UIControls
{
    public class ComboBoxControls
    {

        public static void SelectAnyListIteminCombobox(string windowname, AutomationProperty windowprop, ControlType comboboxprop, int n, System.Windows.Point dragpoint1,System.Windows.Point dragpoint2,int point1,int point2,int n1)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, comboboxprop);
            AutomationElementCollection comboboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            for (int i = n1; i <= n; i++)
            {
                AutomationElement item2 = comboboxes[i];
                ValuePattern vp = item2.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                //vp.SetValue("6");
                UIActions.Click_Element(item2);
                MyUtilities.WaitTime(2000);

                // UIActions.DragNDrop(new System.Windows.Point(677,184), new System.Windows.Point(675,135));
                UIActions.DragNDrop(dragpoint1, dragpoint2);

                UIActions.Click_Element(point1, point2);
                //TestStack.White.InputDevices.Keyboard.Instance.Enter("6");
            }
        }


        public static void SelecAnyComboboxitem(string windowname, AutomationProperty windowprop, AutomationProperty comboboxprop, string comboboxitem, string text)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(comboboxprop, comboboxitem);
            AutomationElement comboboxxboxitem = MainWindowAsElement.FindFirst(TreeScope.Descendants, prop);
            Mouse.Instance.Click(comboboxxboxitem.GetClickablePoint());
            Keyboard.Instance.Enter(text);
            TestStack.White.InputDevices.Keyboard.Instance.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.RETURN);
        }

        //to select a combobox item from a list based in index
        public static void SelectAnyListIteminComboboxBasedonIndex(string windowname, AutomationProperty windowprop, ControlType comboboxprop, int index, System.Windows.Point point1)
        {
            AutomationElement MainWindowAsElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(windowprop, windowname));
            PropertyCondition prop = new PropertyCondition(AutomationElement.ControlTypeProperty, comboboxprop);
            AutomationElementCollection comboboxes = MainWindowAsElement.FindAll(TreeScope.Descendants, prop);

            
            AutomationElement item2 = comboboxes[index];
            UIActions.Click_Element(item2);
            MyUtilities.WaitTime(2000);
            UIActions.Click_Element(point1);

        }

        }
    }