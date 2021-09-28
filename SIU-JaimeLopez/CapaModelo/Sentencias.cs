using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;

namespace CapaModelo
{
    public class Sentencias
    {
        private Conexion manejoConexion = new Conexion();
        public OdbcDataAdapter llenarDGV(string tabla)//llena un DGV con la info de la tabla
        {
            string select = "SELECT * FROM " + tabla + ";";
            OdbcConnection conn = manejoConexion.abrirConexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(select, conn);
            manejoConexion.cerrarConexion(conn);//se cierra la conexion por seguridad
            return dataTable;
        }
        // Jaime Noel López Daniel 0901-18-735
        public bool modificar(string[] campos, string[] datos, string tabla)
        {
            int resultado = 0;
            OdbcConnection conn = manejoConexion.abrirConexion();
            string sentencia = "UPDATE " + tabla + " SET ";
            //Formación de los sets y sus valores
            for (int i = 1; i < campos.Length; i++)
            {
                sentencia += campos[i] + " = '" + datos[i] + "'";
                if(i < campos.Length - 1)
                {
                    sentencia += " , ";
                    //si es menor a la longitud menos 1 (hasta el penultimo dato), ingresará la coma
                    //y en el ultimo, se la saltará
                }
            }
            //asumimos que el primer dato enviado al arreglo es el de ID o identificación
            sentencia += " WHERE " + campos[0]+ " = '" + datos[0] + "';";
            //hacer la operacion
            try
            {
                OdbcCommand modificar = new OdbcCommand(sentencia, conn);
                modificar.ExecuteNonQuery();
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Se produjo un error al modificar\n" + Error);

            }
            //cerramos la conexion
            manejoConexion.cerrarConexion(conn);
            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool insertar(string[] campos, string[] datos, string tabla)
        {
            int resultado = 0;
            OdbcConnection conn = manejoConexion.abrirConexion();
            //creacion de la sentencia
            string sentencia = "INSERT INTO " + tabla + "(";
            //definimos los campos
            for (int i = 0; i < campos.Length; i++)
            {
                sentencia += campos[i];
                if (i < campos.Length - 1)
                {
                    sentencia += " , ";
                }
                else
                {
                    sentencia += " ) VALUES ( ";
                }
            }
            //ahora los valores a ingresar
            for (int i = 0; i < datos.Length; i++)
            {
                sentencia += " '" + datos[i] + "' ";
                if (i < datos.Length - 1)
                {
                    sentencia +=  " , ";
                }
                else
                {
                    sentencia += " );";
                }
            }
            //hacer la operacion
            try
            {
                OdbcCommand ingreso = new OdbcCommand(sentencia, conn);
                ingreso.ExecuteNonQuery();
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Se produjo un error al ingresar\n" + Error);

            }
            manejoConexion.cerrarConexion(conn);
            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool eliminar(string campo, string dato, string tabla, string campoID, string ID)
        {
            int resultado = 0;
            OdbcConnection conn = manejoConexion.abrirConexion();
            string sentencia = "UPDATE " + tabla + " SET ";
            //como es solo dar de baja, cambiaremos el campo
            //que nos especifican como estado
            sentencia += campo + " = '" + dato+"' ";
            //ahora si necesitamos pedir el campo ID y el dato ID
            sentencia += " WHERE " + campoID + " = '" + ID + "';";
            //hacer la operacion
            try
            {
                OdbcCommand eliminar = new OdbcCommand(sentencia, conn);
                eliminar.ExecuteNonQuery();
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Se produjo un error al dar de baja\n" + Error);

            }
            //cerramos la conexion
            manejoConexion.cerrarConexion(conn);
            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int cuenta(string tabla)
        {
            string consulta = "SELECT COUNT(*) FROM " + tabla + " ;";
            int conteo = 0;
            OdbcConnection conn = manejoConexion.abrirConexion();
            //probamos obtener la cuenta de registros de una tabla
            try
            {
                OdbcCommand contar = new OdbcCommand(consulta, conn);
                OdbcDataReader lector = contar.ExecuteReader();
                while (lector.Read())
                {
                    conteo = Int32.Parse(lector[0].ToString());
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("Eror al obtener el conteo");
            }
            manejoConexion.cerrarConexion(conn);
            return conteo;
        }
    }
}
