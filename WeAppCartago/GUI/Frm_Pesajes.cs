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
    public partial class Frm_Pesajes : Form
    {

        private ClasePesajes pro;
        private ClasePesajesHelper ProdH;
        private DataTable table;

        public Frm_Pesajes()
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
                    if (this.txb_Cedula.Text != "" && this.txb_Altura.Text != "" && this.txb_Peso.Text != "" && this.txb_Piernas.Text != "" && this.txt_abdomen.Text != "" && this.txb_cintura.Text != "" )
                    {
                        this.pro = new ClasePesajes();
                        this.pro.Cedula = this.txb_Cedula.Text;
                        this.pro.altura = this.txb_Altura.Text;
                        this.pro.peso = this.txb_Peso.Text;
                        this.pro.piernas = this.txb_Piernas.Text;                   
                        this.pro.abdomen = this.txt_abdomen.Text;                     
                        this.pro.cintura = this.txb_cintura.Text;
                        this.pro.brazos = this.txb_cintura.Text;


                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClasePesajesHelper(pro);
                        ProdH.GuardarCliente();
                        MessageBox.Show("Pesaje Guardado");
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
