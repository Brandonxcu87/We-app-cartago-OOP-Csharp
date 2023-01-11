
namespace WeAppCartago
{
    partial class AgregarAdmins
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
            this.txb_Contraseña = new System.Windows.Forms.TextBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Contraseña
            // 
            this.txb_Contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Contraseña.BackColor = System.Drawing.Color.Black;
            this.txb_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Contraseña.Location = new System.Drawing.Point(283, 76);
            this.txb_Contraseña.Name = "txb_Contraseña";
            this.txb_Contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txb_Contraseña.TabIndex = 13;
            this.txb_Contraseña.Text = "Contraseña";
            this.txb_Contraseña.TextChanged += new System.EventHandler(this.txb_Contraseña_TextChanged);
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Usuario.BackColor = System.Drawing.Color.Black;
            this.txb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Usuario.Location = new System.Drawing.Point(149, 76);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txb_Usuario.TabIndex = 12;
            this.txb_Usuario.Text = "Usuario";
            this.txb_Usuario.TextChanged += new System.EventHandler(this.txb_Usuario_TextChanged);
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Cedula.BackColor = System.Drawing.Color.Black;
            this.txb_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Cedula.Location = new System.Drawing.Point(16, 76);
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Cedula.Size = new System.Drawing.Size(100, 20);
            this.txb_Cedula.TabIndex = 11;
            this.txb_Cedula.Text = "Cedula";
            this.txb_Cedula.TextChanged += new System.EventHandler(this.txb_Cedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bienvenido a la famila WeDance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Elije un trabajo que te guste";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(49, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "y no tendras que trabajar ni un dia de tu vida";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(199)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(32)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ingresar.Location = new System.Drawing.Point(262, 133);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ingresar.Size = new System.Drawing.Size(159, 45);
            this.btn_ingresar.TabIndex = 16;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // AgregarAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Contraseña);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.txb_Cedula);
            this.Controls.Add(this.label1);
            this.Name = "AgregarAdmins";
            this.Text = "AgregarAdmins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Contraseña;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.TextBox txb_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ingresar;
    }
}