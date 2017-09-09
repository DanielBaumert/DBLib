using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public class DBManager {
        private MySqlConnection Connection;
        private DBManager() {
        }

        public DBManager(MySqlConnection connection) : base() {
            Connection = connection;
        }

        /// <summary>
        /// Create a connection to the MySQL Server
        /// </summary>
        /// <param name="connection">Hold the Connection</param>
        /// <param name="usr">Username</param>
        /// <param name="pwd">Unhased Password</param>
        /// <param name="adr">Remote Adress</param>
        /// <param name="dbase">optinonal Databasename: Empty = ""</param>
        /// <returns>True->Connect, False->Something went wrong</returns>
        public static bool Login(out DBManager connection, string usr, string pwd, string adr,string port = "3306", string dbase = "") {
            connection = null;
            string database = string.IsNullOrEmpty(dbase) ? "" : $"database={dbase};";
            string connstr = $"server={adr}; uid={usr};{database} port=3306; pwd={pwd};";
            MySqlConnection db = new MySqlConnection(connstr);
            try {
                db.Open();
                connection = new DBManager(db);
                return true;
            } catch {
                return false;
            }
        }
        public void SetPermission(string usr, PermissionTyp permission, string databasename, params string[] tables) {
            foreach(string table in tables) {
                string query = $"GRANT {permission.ToString().Replace('_', ' ').Replace(" |",",")} ON {databasename}.{table} TO ‘{usr}’@'localhost’;";
                SingleQuery(query);
            }
        }

        public void CreateUser(string usr, string pwd) {
            string query = $"CREATE USER {usr} IDENTIFIED BY '{pwd}';";
            SingleQuery(query);
        }

        public void DeleteUser(string usr, string host) {
            string query = $"DROP USER ‘{usr}’@‘{host}’;";
            SingleQuery(query);
        }


        //public void CreateTable(string table) {
        //    string query = $"CREATE TABLE IF NOT EXISTS {table}({string.Join(", ", table.Select(column => column.GetCreateQuery()))});";
        //    SingleQuery(query);
        //}

        //public void CreateTable(DBTable table, string settings) {
        //    string query = $"CREATE TABLE IF NOT EXISTS {table.TableName}({string.Join(", ", table.Columns.Select(column => column.GetCreateQuery()))},{settings});";
        //    SingleQuery(query);
        //}

        //public void CreateTables(DBTable[] tables) {
        //    foreach(DBTable table in tables) {
        //        string query = $"IF NOT EXISTS CREATE TABLE {table.TableName}({string.Join(", ", table.Columns.Select(column => column.GetCreateQuery()))});";
        //        SingleQuery(query);
        //    }
        //}

        //public void Insert(DBTable table, params (DBColumn column, string value)[] values) {
        //    string query = $"INSERT INTO {table.TableName}({string.Join(", ", values.Select(item => item.column.Name))}) VALUES ({string.Join(", ", values.Select(item => item.value))});";
        //    SingleQuery(query);
        //}

        //public void Inserts(DBTable table, List<(DBColumn column, string value)[]> values) {
        //    foreach(var items in values) {
        //        string query = $"INSERT INTO {table.TableName}({string.Join(", ", items.Select(item => item.column.Name))}) VALUES ({string.Join(", ", items.Select(item => item.value))});";
        //        SingleQuery(query);
        //    }

        //}
        //public List<(DBColumn column, string value)[]> Select(DBTable table, params DBColumn[] columns) {
        //    string query = $"SELECT {string.Join(",", columns.Select(item => item.Name))} FROM {table.TableName};";
        //    MySqlDataReader reader = SingleReaderQuery(query);
        //    return GetReaderReponse(columns, reader);
        //}

        //public List<(DBColumn column, string value)[]> Select(DBTable table, string order, params DBColumn[] columns) {
        //    string query = $"SELECT {string.Join(",", columns.Select(item => item.Name))} FROM {table.TableName} {order};";
        //    MySqlDataReader reader = SingleReaderQuery(query);
        //    return GetReaderReponse(columns, reader);
        //}

        private void SingleQuery(string query) {
            lock(Connection) {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                command.Dispose();
            }
        }
        public MySqlDataReader SingleReaderQuery(string query) {
            MySqlDataReader reader = null;
            lock(Connection) {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();
                command.Dispose();
            }
            return reader;
        }

        public List<(DBColumn column, string value)[]> GetReaderReponse(DBColumn[] columns, MySqlDataReader reader) {
            List<(DBColumn column, string value)[]> items = new List<(DBColumn column, string value)[]>();
            while(reader.Read()) {
                (DBColumn column, string value)[] acc = new(DBColumn column, string value)[columns.Length];
                for(int i = 0; i < columns.Length; i += 1) {
                    DBColumn cal = columns[i];
                    acc[i] = (cal, reader[cal.Name].ToString());
                }
                items.Add(acc);
            }
            return items;
        }
    }
}
