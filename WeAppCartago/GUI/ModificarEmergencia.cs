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
    public partial class ModificarEmergencia : Form
    {
        private ClaseEmergencia pro;
        private ClaseEmergenciaHelper ProdH;
        private DataTable table;
        public ModificarEmergencia()
        {
            InitializeComponent();
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
                DataRow row = table.Rows[0];
                this.txb_cedula.Text = row["Cedula"].ToString();
                this.txb_nombre.Text = row["Nombre"].ToString();
                this.txb_Parentesco.Text = row["Parentesco"].ToString();
                this.txt_telefono.Text = row["telefono"].ToString();

            }
        }

        private void CargarComboBox()
        {
            ProdH = new ClaseEmergenciaHelper();
            cmb_cedula.DataSource = ProdH.ListarClientes();
            cmb_cedula.DisplayMember = "Cedula";
            cmb_cedula.ValueMember = "Cedula";
        }

        private void modificar()
        {

            try
            {
                if (false)
                {
                    MessageBox.Show("el numero de celuda ya esta registrado");
                    this.txb_cedula.Clear();

                }
                else
                {
                    if (this.txb_cedula.Text != "" && this.txb_nombre.Text != "" && this.txb_Parentesco.Text != "" && this.txt_telefono.Text != "")
                    {
                        this.pro = new ClaseEmergencia();
                        this.pro.Cedula = this.txb_cedula.Text;
                        this.pro.Nombre = this.txb_nombre.Text;
                        this.pro.telefono = this.txb_Parentesco.Text;
                        this.pro.Parentesco = this.txt_telefono.Text;


                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseEmergenciaHelper(pro);
                        ProdH.ModificarCliente();
                        MessageBox.Show("Cliente Modificado");
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

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void ModificarEmergencia_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            modificar();
        }
    }
}
