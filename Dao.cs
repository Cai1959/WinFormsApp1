using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//引用mysql
using MySql.Data;

namespace WinFormsApp1
{
    public class Dao
    {
        MySqlConnection sc;
        public MySqlConnection connect()
        {
           
            string str = "Database = store;Server = localhost;Port = 3306;Password = 789456qw;UserID = root;charset = utf8mb4"; ;//数据库连接字符串
            sc = new MySqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }
        public MySqlCommand command(string sql) 
        {
            MySqlCommand cmd = new MySqlCommand(sql,connect());
            return cmd;
        }
        public int Execute(string sql) //更新
        {
            return command(sql).ExecuteNonQuery();
        }
        public MySqlDataReader read(string sql)//读取
        {
            return command(sql).ExecuteReader();
        }
        public void Daoclose() 
        {
            sc.Close();//关闭数据连接
        }
    }
}
