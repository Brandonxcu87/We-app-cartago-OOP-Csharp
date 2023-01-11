using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
   
    public partial class MostrarDatos : Form
    {
        private ClaseMiembros pro;
        private ClaseMiembrosHelper ProdH;
        private DataTable table;
        public MostrarDatos()
        {
            InitializeComponent();
            LlenarTextbox();

        }

        private void LlenarTextbox()
        {
            pro = new ClaseMiembros();
            pro.Cedula = Convert.ToString(this.cmb_cedula.SelectedValue);
            ProdH = new ClaseMiembrosHelper(pro);
            table = new DataTable();
            table = ProdH.Buscarcliente();
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                this.txb_Cedula.Text = row["Cedula"].ToString();
                this.txb_nombre.Text = row["Nombre"].ToString();
                this.txb_ap1.Text = row["AP1"].ToString();
                this.txb_ap2.Text = row["AP2"].ToString();
                this.txb_Edad.Text = row["edad"].ToString();
                this.txt_telefono.Text = row["telefono"].ToString();
                this.txt_ProximoPago.Text = row["ProximoPago"].ToString();
                this.txt_menbresia.Text = row["membresia"].ToString();
            }
        }

        private void CargarComboBox()
        {
            ProdH = new ClaseMiembrosHelper();
            cmb_cedula.DataSource = ProdH.ListarClientes();
            cmb_cedula.DisplayMember = "Cedula";
            cmb_cedula.ValueMember = "Cedula";

        }




        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cmb_cedula_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

  
    }
}
