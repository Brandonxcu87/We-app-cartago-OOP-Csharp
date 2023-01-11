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
    public partial class Principal : Form
    {
        public string usuario;
        public string Cedula;
        public Principal()
        {
            InitializeComponent();
            Personalizardiseño();
            AbrirFormularioshijos2(new AsistenciaAbajo());
            AbrirFormularioshijos(new FormInicioBonito());
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        public void Personalizardiseño()
        {
            panel_ingresar.Visible = false;
            panel_Miembros.Visible = false;
            panel_modificar.Visible = false;
              
        }

        private void hideSubMenu()
        {
            if (panel_ingresar.Visible == true)
                panel_ingresar.Visible = false;
            if (panel_modificar.Visible == true)
                panel_modificar.Visible = false;
            if (panel_Miembros.Visible == true)
                panel_Miembros.Visible = false;

        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_ingresar);
        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel_ingresar);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_modificar);
        }

        private void btn_TusPesajes_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new MostrarEmergencia());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Frm_Ingreso F_ingreso = new Frm_Ingreso();
            F_ingreso.Show();
            this.Close();
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Miembros);
        }

        private void btn_paso1_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new fmr_paso1());
       
           
        }

        private Form activeForm = null;
        private Form activeForm2 = null;
        private void AbrirFormularioshijos(Form ChildForm)
        {

            if (activeForm != null)
           
            activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_todo.Controls.Add(ChildForm);
            panel_todo.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void AbrirFormularioshijos2(Form ChildForm)
        {
            if (activeForm2 != null)
                activeForm2.Close();
            activeForm2 = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Panel_asistencia.Controls.Add(ChildForm);
            Panel_asistencia.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_paso2_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new fmr_paso2());         
        }

        private void btn_paso3_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new Fmr_Emergencia());     
        }

        private void btn_agregaradmin_Click(object sender, EventArgs e)
        {
           AbrirFormularioshijos(new AgregarAdmins());
        }

        private void btn_modificarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new ModificarMiembros());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new Frm_Pesajes());
        }

        private void btn_MisDatos_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new MostrarDatos());
        }

        private void btn_modificarFichasMedicas_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new ModificarFichasMedicas());
        }

        private void btn_MiFichaMedica_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new MostrarFichaMedica());
        }

        private void btn_modificarPesajes_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new ModificarEmergencia());
        }

        private void btn_modificarAdmins_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new ModificarAdmins());
        }

        private void btn_TusPesajes_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new MostarPesaje());
        }

        private void btn_asistenciageneral_Click(object sender, EventArgs e)
        {
            AbrirFormularioshijos(new MirarAsistencia());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lbl_name.Text = usuario;
        }
    }
}

