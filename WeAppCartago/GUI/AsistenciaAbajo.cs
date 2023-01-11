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
    public partial class AsistenciaAbajo : Form
    {

        private ClaseAsistencia pro;
        private ClaseAsistenciaHelper ProdH;
        private DataTable table;

        public AsistenciaAbajo()
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
                    if (this.txb_Cedula.Text != "" && this.txt_hora.Text != "" && this.txt_opcion.Text != "" && this.txt_temp.Text != "")
                    {
                        this.pro = new ClaseAsistencia();
                        this.pro.Cedula = this.txb_Cedula.Text;
                        this.pro.hora = this.txt_hora.Text;
                        this.pro.opcion = this.txt_opcion.Text;
                        this.pro.Temperatura = this.txt_temp.Text;


                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseAsistenciaHelper(pro);
                        ProdH.GuardarCliente();
                        MessageBox.Show("Bienvenido");
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
            txb_Cedula.Text = "Cedula";
            txt_hora.Text = "Hora";
            txt_opcion.Text = "Multifuncional";
            txt_temp.Text = "Tempº";
        }
    }
}
