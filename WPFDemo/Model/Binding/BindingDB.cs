using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using WPFDemo.Model.DB;

namespace WPFDemo.Model.Binding
{
    public class BindingDB
    {
        /// <summary>
        /// 创建绑定数据库名称的binding实例
        /// </summary>
        /// <returns></returns>
        public static System.Windows.Data.Binding BindingDBName()
        {
            //数据源实例
            DBHelper db = new DBHelper();
            //Binding实例
            System.Windows.Data.Binding binding = new System.Windows.Data.Binding();
            binding.Source = db;
            binding.Path = new PropertyPath("DBName");
            return binding;
        }
    }
}
