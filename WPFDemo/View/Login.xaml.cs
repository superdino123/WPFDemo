using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using WPFDemo.Model.Binding;
using WPFDemo.Model.DB;

namespace WPFDemo.View
{
    /// <summary>
    ///     Login.xaml 的交互逻辑
    ///     底部区域绑定单选按钮的值，数据库绑定连接数据库名称(数据库名称没有实现INotifyPropertyChanged接口)
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            //设置界面显示在屏幕中心
            WindowStartupLocation = WindowStartupLocation.CenterScreen; 
            //初始用户名框获取焦点
            userName.Focus();
            //绑定连接数据库实例
            BindingOperations.SetBinding(SqlName, ContentProperty, BindingDB.BindingDBName());
        }

        #region 页面点击事件

        /// <summary>
        ///     窗口关闭按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginIn();
        }

        #endregion

        #region 快捷键设置

        /// <summary>
        ///     快捷键设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl+F4 关闭窗口
            if ((e.KeyboardDevice.IsKeyDown(Key.LeftCtrl) || e.KeyboardDevice.IsKeyDown(Key.RightCtrl)) &&
                e.KeyboardDevice.IsKeyDown(Key.F4))
                Close();
        }

        /// <summary>
        ///     密码框回车，提交登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyDown(Key.Enter))
            {
                LoginIn();
            }
        }

        #endregion

        #region 前端界面设计

        /// <summary>
        ///     鼠标点击窗口时窗口头部背景变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderGrid.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#FB8633"));
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        /// <summary>
        ///     窗口变成后台窗口时窗口头部背景变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Deactivated(object sender, EventArgs e)
        {
            HeaderGrid.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#808080"));
        }

        #endregion

        #region 业务逻辑

        /// <summary>
        /// 登录
        /// </summary>
        public void LoginIn()
        {
            if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(userPassword.Password))
            {
                MessageBox.Show("用户名和密码不能为空！");
            }
            else if (DBHelper.IsLoginSucceed(userName.Text, userPassword.Password))
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
        
        #endregion
    }
}