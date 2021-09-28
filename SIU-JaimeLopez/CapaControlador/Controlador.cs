using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Data;
namespace CapaControlador
{
    class Controlador
    {
        Sentencias refS = new CapaModelo.Sentencias();
        public DataTable llenarDGV(string tabla)
        {
            OdbcDataAdapter dt = refS.llenarDGV(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool insertar(string campos, string datos, string tabla)
        {
            return refS.insertar(campos, datos, tabla);
        }

        public bool modificar(string campos, string datos, string tabla)
        {
            return refS.modificar(campos, datos, tabla);
        }

        public bool eliminar(string campo, string dato, string tabla, string campoID, string ID)
        {
            return refS.eliminar(campo, dato, tabla, campoID, ID);
        }

        public string generarCarnet(string nom, string tel, string dir)
        {
            string tabla = "alumnos";
            int num = refS.cuenta(tabla);
            //el carnet empieza con el número actual
            string carnet = "";
            carnet += (num + 1).ToString();
            //seguido del anio actual
            carnet += "-" + (DateTime.Now).Year;
            //seguido de la inicial del nombre
            carnet += "-" + nom.Substring(0, 1);
            //seguido del 1er digito telefonico
            carnet += "-" + tel.Substring(0, 1);
            //seguido del 1er caracter de la direccion
            carnet += "-" + dir.Substring(0, 1);

            return carnet;
        }
    }
}
