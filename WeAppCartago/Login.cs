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
    public partial class Frm_Ingreso : Form
    {
        public string usuario;
      


        private ClaseAdmins pro;
        private ClaseAdminsHelper ProdH;
        private DataTable table;
        public Frm_Ingreso()
        {
            InitializeComponent();
        }

        private void Btn_Asistencia_Click(object sender, EventArgs e)
        {
            Asistencia F_Asistencia = new Asistencia();
            F_Asistencia.Show();
            this.Hide();
        }


        private void ingreso()
        {
            pro = new ClaseAdmins();
            usuario = this.txb_usuario.Text; 
            pro.Usuario = this.txb_usuario.Text;
            ProdH = new ClaseAdminsHelper(pro);
            table = new DataTable();
            table = ProdH.BuscarContraseña();
            Principal F_clientes = new Principal();
            F_clientes.usuario = usuario;
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                if (row["Contraseña"].ToString() == txb_contraseña.Text)
                {              
                    F_clientes.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                    txb_contraseña.Text = "";
                    txb_usuario.Text = "";
                }
            }
            else
            {
                MessageBox.Show("usuario no existe");
            }
        }


        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }
    }
}
