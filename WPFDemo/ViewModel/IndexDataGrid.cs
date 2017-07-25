using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.ViewModel
{
    public class IndexDataGrid
    {
        /// <summary>
        /// 资讯编码
        /// </summary>
        public string InfoCode { get; set; }
        /// <summary>
        /// 资讯标题
        /// </summary>
        public string InfoTitle { get; set; }
        /// <summary>
        /// URL标题
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// 资讯来源
        /// </summary>
        public string InfoSource { get; set; }
        /// <summary>
        /// 资讯类型
        /// </summary>
        public string InfoType { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public string DataStatus { get; set; }
        /// <summary>
        /// 任务状态
        /// </summary>
        public string TaskStatus { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public string StorageTime { get; set; }
    }
}
