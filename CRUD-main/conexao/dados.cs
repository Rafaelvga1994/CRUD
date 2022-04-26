using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dados
    {

        private string server = "sql10.freesqldatabase.com";
        private string port = "3306";
        private string user = "sql10348454";
        private string pass = "Iq7QaLdfZe";
        private string database = "sql10348454";
    

        public string ConectarX
        {
            get
            {
                return "server= " + this.server + ";" +
                       "port= " + this.port + ";" +
                       "User Id= " + this.user + ";" +
                       "Password= " + this.pass + ";" +
                       "database= " + this.database + ";";
            }
        }
    }
}
