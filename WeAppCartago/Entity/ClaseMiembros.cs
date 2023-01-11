using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
    class ClaseMiembros
    {

            public int opc { get; set; }
            public String Cedula { get; set; }
            public String Nombre { get; set; }
            public String AP1 { get; set; }
            public String AP2 { get; set; }
            public int edad { get; set; }
            public String telefono { get; set; }
            public String membresia { get; set; }
            public DateTime ProximoPago { get; set; }


    }
}
