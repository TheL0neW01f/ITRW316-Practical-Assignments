using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x101;
        public static bool shift = false;
        public static bool ctrl = false;
        public static bool s = false;
        public static bool hotkey = false;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        static void Main(string[] args)
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);      
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if (vkCode == 160)
                {
                    if (shift)
                    {
                        shift = false;
                    }
                    else
                    {
                        shift = true;
                    }
                }
                if (vkCode == 162)
                {
                    if (ctrl)
                    {
                        ctrl = false;
                    }
                    else
                    {
                        ctrl = true;
                    }
                }
                if (vkCode == 83)
                {
                    if (s)
                    {
                        s = false;
                    }
                    else
                    {
                        s = true;
                    }
                }
                
                if (shift && ctrl && s)
                {
                    if (hotkey)
                    {
                        hotkey = false;
                        Console.WriteLine("off");
                    }
                    else
                    {
                        hotkey = true;
                        Console.WriteLine("on");
                    }
                    shift = false;
                    ctrl = false;
                    s = false;
                }

                if (hotkey)
                {
                    Console.Write((Keys)vkCode);
                    using (StreamWriter sw = File.AppendText(Application.StartupPath + @"/Keylog.txt"))
                    {
                        sw.Write((Keys)vkCode);
                    }
                }   

                if(vkCode == 37)
                {
                    MousePoint point;
                    GetCursorPos(out point);
                    SetCursorPos(point.X - 25, point.Y);
                }
                if (vkCode == 38)
                {
                    MousePoint point;
                    GetCursorPos(out point);
                    SetCursorPos(point.X, point.Y - 25);
                }
                if (vkCode == 39)
                {
                    MousePoint point;
                    GetCursorPos(out point);
                    SetCursorPos(point.X + 25, point.Y);
                }
                if (vkCode == 40)
                {
                    MousePoint point;
                    GetCursorPos(out point);
                    SetCursorPos(point.X, point.Y + 25);
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;
        }
        
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);
    }
}
