using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace WPFDemo.View.UserControl
{
    /// <summary>
    /// SystemTools.xaml 的交互逻辑
    /// </summary>
    public partial class SystemToolsUc : System.Windows.Controls.UserControl
    {
        public SystemToolsUc()
        {
            InitializeComponent();
        }

        private void CalculatorTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //"calc.exe"为计算器
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo {FileName = "calc.exe"};        
            System.Diagnostics.Process.Start(info);
        }

        private void NotepadTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //"notepad.exe"为记事本
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo { FileName = "notepad.exe" };
            System.Diagnostics.Process.Start(info);
        }

        private void JournalTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Process.Start(path);
        }
        
    }
}
