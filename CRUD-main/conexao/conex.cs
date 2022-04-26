using MySql.Data.MySqlClient;

namespace DAL
{
    public class conex
    {
        private string x;
        private MySqlConnection c;

        public conex (string d)
        {
            c = new MySqlConnection();
            x = d;
            c.ConnectionString = d; 
        }
        public MySqlConnection Conect
        {
            get { return c; }
            set { c = value; }
        }

        public void Conectar()
        {
           c.Open();
        }
        public void Desconectar()
        {
           c.Close();
        }
    }
}
