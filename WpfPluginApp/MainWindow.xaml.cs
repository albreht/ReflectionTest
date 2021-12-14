using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPluginApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string codebase = System.AppDomain.CurrentDomain.BaseDirectory;
            Uri p = new Uri(codebase);
            string localPath = p.LocalPath;
            var myassembly = System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(localPath, "WpfCustomControlLibrary1.dll"));
            var s = myassembly.GetModules()[0].Assembly.GetTypes()[0];
            UserControl instance = (UserControl) Activator.CreateInstance(s);
            instance.Width = 200;
            instance.Height = 200;

          // uc1.Content = instance;

            testgr.Children.Add((UIElement)instance);
        }
    }
}
