using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestnote
{
    abstract class DAO : MySql
    {
        public static string[] param_co;
        private string Table;
        //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        public DAO(string BD, string UID, string Passw,string table): base(BD,UID,Passw) 
        {
            Table = table;
            // server = localhost;
            param_co[0] = BD;
            param_co[1] = UID;
            param_co[2] = Passw;
        }
         public List<Dictionary<string, string>> Select(string Conditions)
        {

        }
        public int Update(string action, Dictionary<string,object> Data, string Conditions)
        {

        }
    }
}
