using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WPFDemo.Model.DB;
using WPFDemo.ViewModel.Enum;

namespace WPFDemo.ViewModel
{
    public class IndexDataGridModel
    {

        public IndexDataGridModel()
        {
            GetListData();
        }

        private List<IndexDataGrid> listIndexDataGrid = new List<IndexDataGrid>();
        /// <summary>
        /// 用于绑定首页DataGrid的模板的实例
        /// </summary>
        public List<IndexDataGrid> ListIndexDataGrid
        {
            get { return listIndexDataGrid; }
            set { listIndexDataGrid = value; }
        }
        
        public void GetListData()
        {
            DataSet newDataSet = new DataSet();
            newDataSet = DBHelper.SelectAnnounceInfo();
            foreach (DataRow row in newDataSet.Tables[0].Rows)
            {
                IndexDataGrid indexDataGrid = new IndexDataGrid();
                indexDataGrid.InfoCode = row[0].ToString();//资讯编码
                indexDataGrid.InfoTitle = row[1].ToString();//资讯标题
                indexDataGrid.URL = row[2].ToString();//URL标题
                //资讯来源 发行人网站,期货公告,基金,债券,资金公告
                indexDataGrid.InfoSource = System.Enum.GetName(typeof(SourceNameEnum),(int)row[3]);
                //资讯类型 公告,研报,新闻,法律法规,投资者关系
                indexDataGrid.InfoType = System.Enum.GetName(typeof(ColumnClassEnum), (int)row[4]);
                //数据状态 未发布,已发布
                indexDataGrid.DataStatus = System.Enum.GetName(typeof(DataStatusEnum), (int)row[5]);
                //任务状态待处理,待完善,已发布检索
                indexDataGrid.TaskStatus = System.Enum.GetName(typeof(TaskStatusEnum), (int)row[6]);
                //操作人
                indexDataGrid.UserName = row[7].ToString();
                //入库时间
                indexDataGrid.StorageTime = row[8].ToString();
                listIndexDataGrid.Add(indexDataGrid);
            }
        }
    }
}
