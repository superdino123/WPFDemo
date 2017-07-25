using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace WPFDemo.Model.DB
{
    public class DBHelper
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public static string DBName { get; set; } = "InfoDB";

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string source = @"server = (local); integrated security = SSPI; database = " + DBName + ";";
        
        /// <summary>
        /// 验证账户密码
        /// </summary>
        /// <param name="userIdText">输入的账户</param>
        /// <param name="passwordText">输入的密码</param>
        /// <returns>返回验证结果</returns>
        public static bool IsLoginSucceed(string userNameText, string userPasswordText)
        {
            try
            {
                SqlConnection conn = new SqlConnection(source);
                conn.Open();
                string select = "select userName,userPassword from t_user where userName = '" + userNameText + "' and userPassword = '" + userPasswordText + "'";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    conn.Close();
                    return false;
                }
                else
                {
                    conn.Close();
                    return true;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// 在视图中查询出某类(如公告)数据
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectAnnounceInfo()
        {
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            string select = "select * from v_info where infoType = 0";
            SqlDataAdapter da = new SqlDataAdapter(select, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "IndexInfo");
            conn.Close();
            return ds;
        }
    }
}
