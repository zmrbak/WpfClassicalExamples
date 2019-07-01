using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace L007
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Mutex mutex = new Mutex(true,"单实例程序",out bool isNewInstance); 
            if(isNewInstance!=true)
            {
                //MessageBox.Show("程序已经启动");
                IntPtr intPtr = FindWindowW(null, "单实例应用程序");
                if(intPtr!=IntPtr.Zero)
                {
                    SetForegroundWindow(intPtr);
                }

                Shutdown();
            }
        }

        // HWND FindWindowW(
        //  LPCWSTR lpClassName,
        //  LPCWSTR lpWindowName
        //);
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowW(String lpClassName,String lpWindowName);
        //BOOL SetForegroundWindow(
        //  HWND hWnd
        //);
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern Boolean SetForegroundWindow(IntPtr hWnd);
    }
}
