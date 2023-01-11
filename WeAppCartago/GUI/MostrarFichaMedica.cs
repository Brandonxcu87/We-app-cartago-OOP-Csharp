﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
    public partial class MostrarFichaMedica : Form
    {
        private FichasMedicas pro;
        private ClaseFichasMedicasHelper ProdH;
        private DataTable table;
        public MostrarFichaMedica()
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
        private void MostrarFichaMedica_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cmb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }
    }
}