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
    public partial class ModificarMiembros : Form
    {

        private ClaseMiembros pro;
        private ClaseMiembrosHelper ProdH;
        private DataTable table;
        public ModificarMiembros()
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

        private void Modificar()
        {

            try
            {
                if (false)
                {
                    MessageBox.Show("el numero de celuda no existe");
                    this.txb_Cedula.Clear();

                }
                else
                {
                    if (this.txb_Cedula.Text != "" && this.txb_nombre.Text != "" && this.txb_ap1.Text != "" && this.txb_ap2.Text != "" && this.txb_Edad.Text != "" && this.txb_ap2.Text != "" && this.txt_ProximoPago.Text != "")
                    {
                        this.pro = new ClaseMiembros();
                        this.pro.Cedula = this.txb_Cedula.Text;
                        this.pro.Nombre = this.txb_nombre.Text;
                        this.pro.AP1 = this.txb_ap1.Text;
                        this.pro.AP2 = this.txb_ap2.Text;                 
                        this.pro.edad = Convert.ToInt32(this.txb_Edad.Text);
                        this.pro.telefono = this.txt_telefono.Text;
                        this.pro.ProximoPago = Convert.ToDateTime(this.txt_ProximoPago.Text);
                        this.pro.membresia = this.txt_menbresia.Text;


                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseMiembrosHelper(pro);
                        ProdH.ModificarCliente();
                        MessageBox.Show("Miembro modificado");
                        //Listar();
                        //Limpiar();
                        //Iniciar();

                    }
                    else
                    {
                        MessageBox.Show("debe llenar todos los campos ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void ModificarMiembros_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }
    }
}
