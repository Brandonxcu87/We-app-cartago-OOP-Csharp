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
    public partial class MostarPesaje : Form
    {
        private ClasePesajes pro;
        private ClasePesajesHelper ProdH;
        private DataTable table;


        public MostarPesaje()
        {
            InitializeComponent();
            LlenarGV();
        }

        private void CargarComboBox()
        {
            ProdH = new ClasePesajesHelper();
            cmb_cedula.DataSource = ProdH.ListarClientes();
            cmb_cedula.DisplayMember = "Cedula";
            cmb_cedula.ValueMember = "Cedula";
        }

        private void LlenarGV()
        {
            pro = new ClasePesajes();

            ProdH = new ClasePesajesHelper(pro);
            table = new DataTable();
            table = ProdH.ListarClientes();
            if (table.Rows.Count > 0)
            {
                DGV_asistencia.DataSource = table;
            }
        }

        private void LlenarTextbox()
        {
            pro = new ClasePesajes();
            pro.Cedula = Convert.ToString(this.cmb_cedula.SelectedValue);
            ProdH = new ClasePesajesHelper(pro);
            table = new DataTable();
            table = ProdH.Buscarcliente();
            if (table.Rows.Count > 0)
            {
                DGV_asistencia.DataSource = table;

            }
        }

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void MostarPesaje_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }
    }
}
