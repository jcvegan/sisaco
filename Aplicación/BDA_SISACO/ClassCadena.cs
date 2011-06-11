using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Configuration;
using System.IO;

namespace BDA_SISACO
{
    public class ClassCadena
    {
        public static string fnConexion()
        {
            //Cadena que hace referencia a la BD
            //return ConfigurationManager.ConnectionStrings["BD_URPConnectionString"].ConnectionString;
            return "Data Source=.;Initial Catalog=SISACO;Integrated Security=True";
        }
    }
}
