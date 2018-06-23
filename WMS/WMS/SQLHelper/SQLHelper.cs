using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace WMS.SQLHelper
{
    class SQLHelper
    {
        static string  dataBaseFile = System.Environment.CurrentDirectory + @"\database\WMS.sqlite";
        static bool existFile = File.Exists(dataBaseFile);
        public SQLiteConnection sqliteCon = new SQLiteConnection("Data Source="+dataBaseFile+";Version=3;");
        public SQLiteCommand sqliteCom = new SQLiteCommand();
        
        /// <summary>
        /// 登录时获取用户信息
        /// </summary>
        /// <param name="userName">传入参数用户名</param>
        /// <returns></returns>
        public SQLiteDataReader GetLoginInfo(string userName)
        {
            SQLiteDataReader userInfo;
            string selectStr = "select id,name,password,department from employee where id=@id and status=0 ";
            sqliteCom.Connection = sqliteCon;
            sqliteCom.CommandText = selectStr;
            sqliteCom.Parameters.AddWithValue("@id", userName);
            sqliteCon.Open();
            userInfo = sqliteCom.ExecuteReader();
            return userInfo;
            
        }
           
    }
}


