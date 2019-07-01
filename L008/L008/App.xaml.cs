using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace L008
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var arg = e.Args;
            if(arg.Contains("/window1"))
            {
                new Window1().Show();
            }
            else
            {
                new MainWindow().Show();
            }

        }

    }
}
