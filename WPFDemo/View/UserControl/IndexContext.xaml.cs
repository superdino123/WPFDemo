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
using WPFDemo.ViewModel;

namespace WPFDemo.View.UserControl
{
    /// <summary>
    /// IndexContext.xaml 的交互逻辑
    /// </summary>
    public partial class IndexContext : System.Windows.Controls.UserControl
    {
        IndexDataGridModel indexDataGridModel = new IndexDataGridModel();

        public IndexContext()
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

        /// <summary>
        /// 双击进入某一条数据编辑界面 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
