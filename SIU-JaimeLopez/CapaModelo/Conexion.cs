using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace CapaModelo
{
    class Conexion
    {
        public OdbcConnection abrirConexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=SIUJaimeLopez");
            try
            {
                conexion.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("¡No se ha podido aperturar la conexión!\n"+
                    "Revisar el nombre del ODBC: SIUJaimeLopez");
            }
            return conexion;
        }
        //Jaime Noel López Daniel 0901-18-735
        public void cerrarConexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error cerrando la conexión");
            }
        }

    }
}
