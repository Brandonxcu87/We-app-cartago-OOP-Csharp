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
    public partial class AgregarAdmins : Form
    {
        private ClaseAdmins pro;
        private ClaseAdminsHelper ProdH;
        private DataTable table;
        public AgregarAdmins()
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
                    if (this.txb_Cedula.Text != "" && this.txb_Contraseña.Text != "" && this.txb_Usuario.Text != "" )
                    {
                        this.pro = new ClaseAdmins();
                        this.pro.Cedula = this.txb_Cedula.Text;
                        this.pro.Contraseña = this.txb_Contraseña.Text;
                        this.pro.Usuario = this.txb_Usuario.Text;
                        


                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseAdminsHelper(pro);
                        ProdH.GuardarCliente();
                        MessageBox.Show("Admin Guardado");
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
            guardar();
        }

        private void txb_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
