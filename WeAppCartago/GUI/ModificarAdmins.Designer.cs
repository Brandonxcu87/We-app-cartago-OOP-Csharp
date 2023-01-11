
namespace WeAppCartago
{
    partial class ModificarAdmins
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
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txb_Contraseña = new System.Windows.Forms.TextBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_cedula = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(199)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(32)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ingresar.Location = new System.Drawing.Point(262, 171);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ingresar.Size = new System.Drawing.Size(159, 45);
            this.btn_ingresar.TabIndex = 21;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txb_Contraseña
            // 
            this.txb_Contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Contraseña.BackColor = System.Drawing.Color.Black;
            this.txb_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Contraseña.Location = new System.Drawing.Point(283, 114);
            this.txb_Contraseña.Name = "txb_Contraseña";
            this.txb_Contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txb_Contraseña.TabIndex = 20;
            this.txb_Contraseña.Text = "Contraseña";
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Usuario.BackColor = System.Drawing.Color.Black;
            this.txb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Usuario.Location = new System.Drawing.Point(149, 114);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txb_Usuario.TabIndex = 19;
            this.txb_Usuario.Text = "Usuario";
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Cedula.BackColor = System.Drawing.Color.Black;
            this.txb_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Cedula.Location = new System.Drawing.Point(16, 114);
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Cedula.Size = new System.Drawing.Size(100, 20);
            this.txb_Cedula.TabIndex = 18;
            this.txb_Cedula.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bienvenido a la famila WeDance";
            // 
            // cmb_cedula
            // 
            this.cmb_cedula.BackColor = System.Drawing.Color.Black;
            this.cmb_cedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.cmb_cedula.FormattingEnabled = true;
            this.cmb_cedula.Location = new System.Drawing.Point(16, 65);
            this.cmb_cedula.Name = "cmb_cedula";
            this.cmb_cedula.Size = new System.Drawing.Size(121, 21);
            this.cmb_cedula.TabIndex = 38;
            this.cmb_cedula.SelectedIndexChanged += new System.EventHandler(this.cmb_cedula_SelectedIndexChanged);
            // 
            // ModificarAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.cmb_cedula);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_Contraseña);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.txb_Cedula);
            this.Controls.Add(this.label1);
            this.Name = "ModificarAdmins";
            this.Text = "ModificarAdmins";
            this.Load += new System.EventHandler(this.ModificarAdmins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txb_Contraseña;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.TextBox txb_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_cedula;
    }
}