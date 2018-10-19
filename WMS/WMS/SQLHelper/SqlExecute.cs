using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;
using WMS.BaseClass;

namespace WMS.SQLHelper
{
    class SqlExecute
    {
        static string dataBaseFile = System.Environment.CurrentDirectory + @"\database\WMS.sqlite";
        static bool existFile = File.Exists(dataBaseFile);
        public SQLiteConnection sqliteCon = new SQLiteConnection("Data Source=" + dataBaseFile + ";Version=3;");
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
        
        /// <summary>
        /// 查询编号是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public int SelectCode(string code,string parameterName, string sqlString)
        {
            int status = 0;
            try
            {
                sqliteCom.Connection = sqliteCon;
                sqliteCom.CommandText = sqlString;
                sqliteCom.Parameters.AddWithValue(parameterName, code);
                sqliteCon.Open();
                if(sqliteCom.ExecuteScalar()==null)
                {
                    return status;
                }
                string cd = sqliteCom.ExecuteScalar().ToString();
                if (cd == code)
                {
                    status = 1;
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("数据库查询错误", "错误");
            }
            finally
            {
                
                sqliteCon.Close();
            }
            
            return status;
        }

        /// <summary>
        /// 保存物资字典信息
        /// </summary>
        /// <param name="code">编码</param>
        /// <param name="sQLiteParameters">参数列表</param>
        /// <param name="sqlString">SQL语句</param>
        /// <returns></returns>
        public int SaveGoods(string code,SQLiteParameter[] sQLiteParameters,string sqlString)
        {
            int result = 0;
            try
            {
                sqliteCom.CommandText = sqlString;
                sqliteCom.Parameters.AddRange(sQLiteParameters);
                sqliteCom.Connection = sqliteCon;
                sqliteCon.Open();
                result= sqliteCom.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                
            }
            finally
            {
                
                sqliteCon.Close();
            }
            return result;
        }
       
        #region sql执行函数，只需要传入参数和SQL语句，返回一个int标志执行结果 执行成功返回1
        public int Execute(SQLiteParameter[] sQLiteParameters, string sqlString)
        {
            int result = 0;
            try
            {
                sqliteCom.CommandText = sqlString;
                sqliteCom.Parameters.AddRange(sQLiteParameters);
                sqliteCom.Connection = sqliteCon;
                sqliteCon.Open();
                result = sqliteCom.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {

            }
            finally
            {

                sqliteCon.Close();
            }
            return result;
        }
        #endregion

        /// <summary>
        /// 获取行号 主要用于生成订单号及明细行号
        /// </summary>
        /// <param name="sQLiteParameters"></param>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public int GetRows( string sqlString)
        {
            
            int rows=0;
            try
            {
                sqliteCom.Connection = sqliteCon;
                sqliteCom.CommandText = sqlString;
                sqliteCon.Open();
                SQLiteDataReader dr = sqliteCom.ExecuteReader();
                if(dr.Read())
                {
                    rows = int.Parse(dr["rows"].ToString());
                }
                
            }
            catch(Exception e)
            {

            }
            finally
            {
                sqliteCon.Close();
            }
            return rows;

        }

        /// <summary>
        /// 页面数据加载
        /// </summary>
        /// <param name="sqlString">查询SQL语句</param>
        /// <returns></returns>
        public DataTable LoadInfo(string sqlString)
        {
            SQLiteDataAdapter sQLiteDataAdapter;
            DataTable dt=new DataTable();
            try
            {
                sqliteCom.CommandText = sqlString;
                sqliteCom.Connection = sqliteCon;
                sqliteCon.Open();
                sQLiteDataAdapter = new SQLiteDataAdapter(sqliteCom);
                sQLiteDataAdapter.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                return dt = null;
            }
            finally
            {
                
                sqliteCon.Close();
            }
            
            
        }

        public int SaveTypeInfo()
        {
            int success = 0;
            return success;
        }

        public DataTable SelectInfo(SQLiteParameter[] sQLiteParameters,string sqlString)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter sQLiteDataAdapter;
            try
            {
                sqliteCom.Parameters.AddRange(sQLiteParameters);
                sqliteCom.CommandText = sqlString;
                sqliteCom.Connection = sqliteCon;
                
                sQLiteDataAdapter = new SQLiteDataAdapter(sqliteCom);
                sqliteCon.Open();
                sQLiteDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception e)
            {
                return dataTable = null;
            }
            finally
            {
                sqliteCon.Close();
            }
            
        }

        /// <summary>
        /// 扣减库存 1-扣减成功，n-第n行数据扣减失败
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public int MinusStock(DataTable dataTable)
        {
            int result = 0;
            string minusSQL;
            sqliteCon.Open();
            IDbTransaction trans = sqliteCon.BeginTransaction();
            sqliteCom.Connection = sqliteCon;
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string goodscode = dataTable.Rows[i][0].ToString();
                    double amount = double.Parse(dataTable.Rows[i][1].ToString());
                }
                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
            return result;
        }
    }
}
