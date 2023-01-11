using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeAppCartago
{
    public partial class MirarAsistencia : Form
    {
        private ClaseAsistencia pro;
        private ClaseAsistenciaHelper ProdH;
        private DataTable table;
        public MirarAsistencia()
        {
            InitializeComponent();
            LlenarGV();
         
        }


        private void LlenarGV()
        {
            pro = new ClaseAsistencia();
          
            ProdH = new ClaseAsistenciaHelper(pro);
            table = new DataTable();
            table = ProdH.ListarAsistencia();
            if (table.Rows.Count > 0)
            {
                DGV_asistencia.DataSource = table;
            }
        }

        private void LlenarGVconCB()
        {
            pro = new ClaseAsistencia();
            pro.Cedula = Convert.ToString(this.cmb_cedula.SelectedValue);           
            ProdH = new ClaseAsistenciaHelper(pro);
            table = new DataTable();
            table = ProdH.Buscarcliente();
            if (table.Rows.Count > 0)
            {
                DGV_asistencia.DataSource = table;
            }
        }

        private void CargarComboBox()
        {
            ProdH = new ClaseAsistenciaHelper();
            cmb_cedula.DataSource = ProdH.ListarAsistencia();
            cmb_cedula.DisplayMember = "Cedula";
            cmb_cedula.ValueMember = "Cedula";

        }
        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGVconCB();
        }

        private void MirarAsistencia_Load(object sender, EventArgs e)
        {
               CargarComboBox();
        }

        private void DGV_asistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
