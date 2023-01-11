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
    public partial class fmr_paso2 : Form
    {
        private FichasMedicas pro;
        private ClaseFichasMedicasHelper ProdH;
        private DataTable table;
        public fmr_paso2()
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
                    if (this.txb_Cedula.Text != "" && this.txb_Cirujias.Text != "" && this.txb_habitos.Text != "" && this.txb_Padecimientos.Text != "" && this.txb_ProblemasPosturales.Text != "" && this.txt_GrupoSangre.Text != "" )
                    {
                        this.pro = new FichasMedicas();
                        this.pro.Cedula = this.txb_Cedula.Text;
                        this.pro.GrupoSangre = this.txt_GrupoSangre.Text;
                        this.pro.Cirujias = this.txb_Cirujias.Text;
                        this.pro.Padecimientos = this.txb_Padecimientos.Text;                  
                        this.pro.ProblemasPosturales = this.txb_ProblemasPosturales.Text;
                        this.pro.habitos = this.txb_habitos.Text;



                        //Hasta acá, llenamos la instancia de clase Clientes contenido a los atributos.

                        ProdH = new ClaseFichasMedicasHelper(pro);
                        ProdH.GuardarCliente();
                        MessageBox.Show("Ficha Medica Guardada");
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
