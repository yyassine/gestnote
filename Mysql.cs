using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace gestnote
{
    abstract class MySql
    {
        private string BD;
        private MySqlConnection con;
        private string Pass;
        private MySqlDataReader rs;
        private MySqlCommand st;
        private string User;

        public List<Dictionary<string,string>> Get(string sql)
        {

        }

        protected MySql(string BD, string UID, string Passw)
        {

        }
    }
}
