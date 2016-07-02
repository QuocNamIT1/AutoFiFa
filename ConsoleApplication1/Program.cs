using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;


namespace ConsoleApplication1
{
    class Program
    {
        static List<A> listA;
         class A
         {
             public int abc = 2;
         }
        static void Main(string[] args)
        {

            var prc = Process.GetProcessesByName("fifazf");
            if (prc.Length > 0)
            {

                SetForegroundWindow(prc[0].MainWindowHandle);
                int count = 75;
                while (count-- != 0)
                {
                    LeftMouseClick(1013, 382, 2000);
                    LeftMouseClick(763, 449, 2000);
                    LeftMouseClick(878, 614, 15000);
                    LeftMouseClick(1068, 719, 2000);

                }
            }
           //den 592137 4736835
            //xanh 685824 54784

        }
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos, int delay)
        {
            SetCursorPos(xpos, ypos);
            Thread.Sleep(1000);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
            Thread.Sleep(delay);
        }

    }
}
