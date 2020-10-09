using System;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.InputDevices;
using TestStack.White.WindowsAPI;
using WindowsInput;

namespace BocadUITestsSolution.Core
{
    public class MiscFunctions
    {
        public static string GenerateCoupon(int length)
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public static void InputSimulator(int x, int y)
        {
            InputSimulator s1 = new InputSimulator();
            MouseSimulator Msimulator = new MouseSimulator(s1);
            Msimulator.MoveMouseBy(x, y);
            Task.Delay(2000).Wait();
            Msimulator.LeftButtonClick();
            Keyboard.Instance.PressSpecialKey(KeyboardInput.SpecialKeys.ESCAPE);

            Task.Delay(2000).Wait();
            Mouse.Instance.Click();
            Task.Delay(2000).Wait();
        }
    }
}
