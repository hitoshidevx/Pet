using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace APIPet.Context
{
    public class PetShopContext
    {

        SqlConnection con = new SqlConnection();

        public PetShopContext()
        {
            con.ConnectionString = @"Data Source=DESKTOP-GPMBRDJ\SQLEXPRESS;Initial Catalog=PetShop;User ID=sa;Password=sa132;";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        

        public SqlConnection Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }

    }
}
