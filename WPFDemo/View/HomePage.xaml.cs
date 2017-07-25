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
using WPFDemo.ViewModel;

namespace WPFDemo.View
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : RibbonWindow
    {
        IndexDataGridModel indexDataGridModel = new IndexDataGridModel();
        
        public HomePage()
        {
            InitializeComponent();
            //指定DataGrid的数据源
            DataGrid.ItemsSource = indexDataGridModel.ListIndexDataGrid;
        }

        /// <summary>
        /// 加载DataGrid时加载行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
