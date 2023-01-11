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
    public partial class MostrarEmergencia : Form
    {

        private ClaseEmergencia pro;
        private ClaseEmergenciaHelper ProdH;
        private DataTable table;
        public MostrarEmergencia()
        {
            InitializeComponent();
            LlenarGV();
        }

        private void LlenarTextbox()
        {
            pro = new ClaseEmergencia();
            pro.Cedula = Convert.ToString(this.cmb_cedula.SelectedValue);
            ProdH = new ClaseEmergenciaHelper(pro);
            table = new DataTable();
            table = ProdH.Buscarcliente();
            if (table.Rows.Count > 0)
            {
                DGV_asistencia.DataSource = table;

            }
        }


        private void LlenarGV()
        {
            pro = new ClaseEmergencia();

            ProdH = new ClaseEmergenciaHelper(pro);
            table = new DataTable();
            table = ProdH.ListarClientes();
            if (table.Rows.Count > 0)
            {
                DGV_asistencia.DataSource = table;
            }
        }


        private void CargarComboBox()
        {
            ProdH = new ClaseEmergenciaHelper();
            cmb_cedula.DataSource = ProdH.ListarClientes();
            cmb_cedula.DisplayMember = "Cedula";
            cmb_cedula.ValueMember = "Cedula";
        }

        private void MostrarEmergencia_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

    
    }
}
