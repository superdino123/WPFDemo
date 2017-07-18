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
using System.Windows.Shapes;

namespace WPFDemo.View
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;//设置界面显示在屏幕中心
        }

        #region 页面逻辑
        /// <summary>
        /// 窗口关闭按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 前端界面设计

        /// <summary>
        /// 鼠标点击窗口时窗口头部背景变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderGrid.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#FB8633"));
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        /// <summary>
        /// 窗口变成后台窗口时窗口头部背景变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Deactivated(object sender, EventArgs e)
        {
            HeaderGrid.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#808080"));
        }


        #endregion

        /// <summary>
        /// 快捷键设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl+F4 关闭窗口
            if ((e.KeyboardDevice.IsKeyDown(key: Key.LeftCtrl) || e.KeyboardDevice.IsKeyDown(key: Key.RightCtrl)) &&
                e.KeyboardDevice.IsKeyDown(key: Key.F4))
            {
                this.Close();
            }
        }
    }
}
