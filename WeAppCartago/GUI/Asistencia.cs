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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
            AbrirFormularioshijos(new AsistenciaAbajo());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Frm_Ingreso F_ingreso = new Frm_Ingreso();
            F_ingreso.Show();
            this.Close();
        }

        private void btn_Horarios_Click(object sender, EventArgs e)
        {
            ptb_funcional.Visible = true;
            ptb_yoga.Visible = false;
            ptb_Swell.Visible = false;
            ptb_boxeo.Visible = false;
        }



        private Form activeForm = null;
    
        private void AbrirFormularioshijos(Form ChildForm)
        {

            if (activeForm != null)

                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Panel_asistencia.Controls.Add(ChildForm);
            Panel_asistencia.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_Yoga_Click(object sender, EventArgs e)
        {
            ptb_funcional.Visible = false;
            ptb_yoga.Visible = true;
            ptb_Swell.Visible = false;
            ptb_boxeo.Visible = false;
        }

        private void btn_Boxeo_Click(object sender, EventArgs e)
        {
            ptb_funcional.Visible = false;
            ptb_yoga.Visible = false;
            ptb_Swell.Visible = false;
            ptb_boxeo.Visible = true;
        }

        private void btn_Swell_Click(object sender, EventArgs e)
        {
            ptb_funcional.Visible = false;
            ptb_yoga.Visible = false;
            ptb_Swell.Visible = true;
            ptb_boxeo.Visible = false;
        }


    }
}
