using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebVideoGame.Models
{
    public class Conexion
    {

        #region "Constructor"
            public Conexion() { }
        #endregion

        #region "Metodos Publicos" 
        public SqlConnection Conectar()
            {
                SqlConnection conectar = new SqlConnection("Data Source=.;" +
                    "Initial Catalog=VIDEOGAME;Integrated Security=SSPI;");

                try
                {
                    conectar.Open();
                    return conectar;
                }
                catch (SqlException e)
                {
                    return null;
                    throw e;
                }
            }
        
            public void CerrarConexion(SqlConnection conectar)
            {
                try
                {
                    conectar.Close();
                }
                catch (SqlException e)
                {
                    throw e;
                }
            }

            public int operaracion(string conSQL, SqlConnection conector)
            {
                int num = 0;

                try
                {
                    SqlCommand comando = new SqlCommand(conSQL, conector);
                    num = comando.ExecuteNonQuery();
                    return num;
                }
                catch (SqlException ex)
                {              
                    return num;
                    throw ex;
                }
            }
        #endregion

        #region ""

        #endregion
    }
}