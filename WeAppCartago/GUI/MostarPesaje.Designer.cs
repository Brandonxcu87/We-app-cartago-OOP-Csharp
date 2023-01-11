
namespace WeAppCartago
{
    partial class MostarPesaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_asistencia = new System.Windows.Forms.DataGridView();
            this.cmb_cedula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_asistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_asistencia
            // 
            this.DGV_asistencia.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_asistencia.Location = new System.Drawing.Point(14, 101);
            this.DGV_asistencia.Name = "DGV_asistencia";
            this.DGV_asistencia.Size = new System.Drawing.Size(405, 151);
            this.DGV_asistencia.TabIndex = 31;
            // 
            // cmb_cedula
            // 
            this.cmb_cedula.BackColor = System.Drawing.Color.Black;
            this.cmb_cedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.cmb_cedula.FormattingEnabled = true;
            this.cmb_cedula.Location = new System.Drawing.Point(27, 48);
            this.cmb_cedula.Name = "cmb_cedula";
            this.cmb_cedula.Size = new System.Drawing.Size(121, 21);
            this.cmb_cedula.TabIndex = 30;
            this.cmb_cedula.SelectedIndexChanged += new System.EventHandler(this.cmb_cedula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pesajes";
            // 
            // MostarPesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.DGV_asistencia);
            this.Controls.Add(this.cmb_cedula);
            this.Controls.Add(this.label1);
            this.Name = "MostarPesaje";
            this.Text = "MostarPesaje";
            this.Load += new System.EventHandler(this.MostarPesaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_asistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_asistencia;
        private System.Windows.Forms.ComboBox cmb_cedula;
        private System.Windows.Forms.Label label1;
    }
}