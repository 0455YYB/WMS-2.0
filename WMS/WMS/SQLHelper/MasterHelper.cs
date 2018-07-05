using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace WMS.SQLHelper
{
    class MasterHelper
    {
        static string dataBaseFile = System.Environment.CurrentDirectory + @"\database\WMS.sqlite";
        static bool existFile = File.Exists(dataBaseFile);
        public SQLiteConnection sqliteCon = new SQLiteConnection("Data Source=" + dataBaseFile + ";Version=3;");
        public SQLiteCommand sqliteCom = new SQLiteCommand();
    }
}
