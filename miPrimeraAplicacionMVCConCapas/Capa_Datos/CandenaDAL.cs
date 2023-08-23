using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class CandenaDAL
    {
        public string cadena { get; set; }
        public CandenaDAL() { 
            cadena =  ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
}
