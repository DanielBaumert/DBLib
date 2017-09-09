using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    class DBQueryHelper {
        public const string ShowDatabase = "SHOW DATABASES;";
        public string ShowTablesQuery(string database) => $"SHOW TABLES FROM {database}";
        public string ShowColumnsQuery(string database, string table) => $"SHOW COLUMNS FROM {database}.{table}";
        //public abstract void CreateTableQuery(string name, DBColumn[] Columns);
    }
}
