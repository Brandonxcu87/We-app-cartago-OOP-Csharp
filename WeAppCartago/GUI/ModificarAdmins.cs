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
    public partial class ModificarAdmins : Form
    {
        private ClaseAdmins pro;
        private ClaseAdminsHelper ProdH;
        private DataTable table;
        public ModificarAdmins()
        {
            InitializeComponent();
        }

        private void guardar()
        {

            try
            {
                if (false)
                {
                    MessageBox.Show("el numero de celuda ya esta registrado");
                    this.txb_Cedula.Clear();

                }
                else
                {
                    if (this.txb_Cedula.Text != "" && this.txb_Contraseña.Text != "" && this.txb_Usuario.Text != "")
                    {
                        this.pro = new ClaseAdmins();
                        this.pro.Cedula = this.txb_Cedula.Text;
                        this.pro.Contraseña = this.txb_Contraseña.Text;
                        this.pro.Usuario = this.txb_Usuario.Text;



                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseAdminsHelper(pro);
                        ProdH.ModificarCliente();
                        MessageBox.Show("Admin Modificado");
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

        private void LlenarTextbox()
        {
            pro = new ClaseAdmins();
            pro.Cedula = Convert.ToString(this.cmb_cedula.SelectedValue);
            ProdH = new ClaseAdminsHelper(pro);
            table = new DataTable();
            table = ProdH.Buscarcliente();
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                this.txb_Cedula.Text = row["Cedula"].ToString();
                this.txb_Contraseña.Text = row["Usuario"].ToString();
                this.txb_Usuario.Text = row["Contraseña"].ToString();


            }
        }

        private void CargarComboBox()
        {
            ProdH = new ClaseAdminsHelper();
            cmb_cedula.DataSource = ProdH.ListarClientes();
            cmb_cedula.DisplayMember = "Cedula";
            cmb_cedula.ValueMember = "Cedula";
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void ModificarAdmins_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }
    }
}
