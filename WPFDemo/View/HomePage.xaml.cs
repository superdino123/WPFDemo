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
using Fluent;
using WPFDemo.View.UserControl;
using WPFDemo.ViewModel;

namespace WPFDemo.View
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : RibbonWindow
    {
        readonly IndexContext indexContext = new IndexContext();

        public HomePage()
        {
            InitializeComponent();
            ContentGrid.Children.Add(indexContext);
        }

        /// <summary>
        /// 测试按钮1点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //InfoDataEdit infoDataEdit = new InfoDataEdit();
            //Grid grid = infoDataEdit.GridNew;
            //infoDataEdit.GridFather.Children.RemoveAt(0);
            //ContentGrid.Visibility = Visibility.Collapsed;
            //IndexGrid.Children.Add(grid);
        }

        /// <summary>
        /// 测试按钮2点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// 取消按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(indexContext);
        }
    }
}