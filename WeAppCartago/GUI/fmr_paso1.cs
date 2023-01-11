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
    public partial class fmr_paso1 : Form
    {
        private ClaseMiembros pro;
        private ClaseMiembrosHelper ProdH;
        private DataTable table;

        public fmr_paso1()
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
                    if (this.txb_Cedula.Text != "" && this.txb_nombre.Text != "" && this.txb_ap1.Text != "" && this.txb_ap2.Text != "" && this.txb_Edad.Text != "" && this.txt_ProximoPago.Text != "" && this.txt_telefono.Text != "")
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
                        ProdH.GuardarCliente();
                        MessageBox.Show("Cliente Guardado");
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

        private void txb_Cedula_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
