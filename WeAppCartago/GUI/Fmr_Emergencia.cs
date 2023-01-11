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
    public partial class Fmr_Emergencia : Form
    {

        private ClaseEmergencia pro;
        private ClaseEmergenciaHelper ProdH;
        private DataTable table;

        public Fmr_Emergencia()
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
                    this.txb_cedula.Clear();

                }
                else
                {
                    if (this.txb_cedula.Text != "" && this.txb_nombre.Text != "" && this.txb_Parentesco.Text != "" && this.txt_telefono.Text != "" )
                    {
                        this.pro = new ClaseEmergencia();
                        this.pro.Cedula = this.txb_cedula.Text;
                        this.pro.Nombre = this.txb_nombre.Text;
                        this.pro.telefono = this.txb_Parentesco.Text;
                        this.pro.Parentesco = this.txt_telefono.Text;       


                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseEmergenciaHelper(pro);
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
    }
}
