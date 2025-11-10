using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CliniPet.Datos
{
	public class ClConexion
	{
        SqlConnection oConex;

        public ClConexion()
        {
            oConex = new SqlConnection("aaa");
        }

        public SqlConnection MtAbrirConexion()
        {
            oConex.Open();
            return oConex;
        }

        public void MtCerrarConexion()
        {
            oConex.Close();
        }
    }
}