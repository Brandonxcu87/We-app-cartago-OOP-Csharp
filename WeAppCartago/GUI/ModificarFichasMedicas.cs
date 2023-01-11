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
    public partial class ModificarFichasMedicas : Form
    {
        private FichasMedicas pro;
        private ClaseFichasMedicasHelper ProdH;
        private DataTable table;
        public ModificarFichasMedicas()
        {
            InitializeComponent();
        }

        private void LlenarTextbox()
        {
            pro = new FichasMedicas();
            pro.Cedula = Convert.ToString(this.cmb_cedula.SelectedValue);
            ProdH = new ClaseFichasMedicasHelper(pro);
            table = new DataTable();
            table = ProdH.Buscarcliente();
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                this.txb_Cedula.Text = row["Cedula"].ToString();
                this.txb_Cirujias.Text = row["Cirujias"].ToString();
                this.txb_habitos.Text = row["habitos"].ToString();
                this.txb_Padecimientos.Text = row["Padecimientos"].ToString();
                this.txb_ProblemasPosturales.Text = row["ProblemasPosturales"].ToString();
                this.txt_GrupoSangre.Text = row["GrupoSangre"].ToString();
                this.txt_diaficha.Text = row["DiaFicha"].ToString();
            }
        }

        private void CargarComboBox()
        {
            ProdH = new ClaseFichasMedicasHelper();
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
                    MessageBox.Show("el numero de celuda ya esta registrado");
                    this.txb_Cedula.Clear();

                }
                else
                {
                    if (this.txb_Cedula.Text != "" && this.txb_Cirujias.Text != "" && this.txb_habitos.Text != "" && this.txb_Padecimientos.Text != "" && this.txb_ProblemasPosturales.Text != "" && this.txt_GrupoSangre.Text != "")
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
                        ProdH.ModificarCliente();
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



        private void ModificarFichasMedicas_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
