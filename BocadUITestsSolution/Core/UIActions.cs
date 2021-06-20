using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;

namespace BocadAPITestsSolution.Core
{
    public class UIActions
    {

        public static void Click_Element(AutomationElement Element)
        {
            try
            {

                Mouse.Instance.Click(Element.GetClickablePoint());
                
            }
            catch (Exception)
            {

            }

        }

        public static void RightClick_Element(AutomationElement Element)
        {
            try
            {
                Mouse.Instance.RightClick(Element.GetClickablePoint());
            }
            catch (Exception)
            {
                
            }
        }
        public static void EnterValueIntoBox(AutomationElement Element, string value)
        {
            ValuePattern EnterPattern = Element.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
            EnterPattern.SetValue(value);
        }

        public static void Click_Element(UIItem item)
        {
            try
            {
                item.Click();
            }
            catch (Exception)
            {

            }
        }


        public static void Click_Element(System.Windows.Point point)
        {
            try
            {
                Mouse.Instance.Click(point);

            }
            catch (Exception)
            {

            }

        }

        public static void Click_Element(int point, int point1)
        {
            try
            {
                TestStack.White.InputDevices.Mouse.Instance.Click(new System.Windows.Point(point, point1));

            }
            catch (Exception)
            {

            }

        }

        public static void Mouse_RightClick(int X, int Y)
        {
            if (X != 0 && Y != 0)
            {
                Mouse.Instance.Location = new System.Windows.Point(X, Y);
               // TestStack.White.InputDevices.Keyboard.Instance.HoldKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
                Mouse.Instance.RightClick();
               // TestStack.White.InputDevices.Keyboard.Instance.LeaveKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
               // TestReport.ReportManager.LogSuccess("Clicked On Specified Location", " Item CLicked", "Location of X :" + X, "LOcation Of Y" + Y, false);

            }
            else
            {
                //TestReport.ReportManager.LogFailure("Specified Location Can't Be Navigated", " Specified location not found", "Location of X :" + X, "LOcation Of Y" + Y, false);
            }

        }

        public static void Control_Click(int X, int Y)
        {
            if (X != 0 && Y != 0)
            {
                Mouse.Instance.Location = new System.Windows.Point(X, Y);
                TestStack.White.InputDevices.Keyboard.Instance.HoldKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
                Mouse.Instance.Click();
                TestStack.White.InputDevices.Keyboard.Instance.LeaveKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
            }
            else
            {

            }

        }
        public static void Control_Mouse_RightClick(int X, int Y)
        {
            if (X != 0 && Y != 0)
            {
                Mouse.Instance.Location = new System.Windows.Point(X, Y);
                TestStack.White.InputDevices.Keyboard.Instance.HoldKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
                Mouse.Instance.RightClick();
                TestStack.White.InputDevices.Keyboard.Instance.LeaveKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
               // TestReport.ReportManager.LogSuccess("Clicked On Specified Location", " Item CLicked", "Location of X :" + X, "LOcation Of Y" + Y, false);

            }
            else
            {
               // TestReport.ReportManager.LogFailure("Specified Location Can't Be Navigated", " Specified location not found", "Location of X :" + X, "LOcation Of Y" + Y, false);
            }

        }

        public static void Double_Click_Element(UIItem item)
        {
            try
            {
                item.DoubleClick();
            }
            catch
            {
                //TestReport.ReportManager.LogSuccess("Double Click On Item " + item.Name, item.Name + "Double Clicked", item.Name, item.Name, false);
            }
        }

        public static void DoubleClick_Element(int point, int point1)
        {
            try
            {
                TestStack.White.InputDevices.Mouse.Instance.DoubleClick(new System.Windows.Point(point, point1));

            }
            catch (Exception)
            {

            }

        }


        public static void DoubleClick_Element(AutomationElement Element)
        {
            try
            {
                Mouse.Instance.DoubleClick(Element.GetClickablePoint());
            }
            catch
            {
                //TestReport.ReportManager.LogSuccess("Double Click On Item " + item.Name, item.Name + "Double Clicked", item.Name, item.Name, false);
            }

        }


        public static bool DragNDrop(Point source, Point Target)
        {


           // UIActions.Click_Element(source);

            Mouse.Instance.Location = source;
            Task.Delay(1000).Wait();
            Mouse.LeftDown();
            Task.Delay(2000).Wait();

            //Move to the new window

            Mouse.Instance.Location = Target;
            Task.Delay(1000).Wait();
            
            //Drop
            Mouse.LeftUp();
            Task.Delay(1000).Wait();
            
            return true;




        }



    }
}
