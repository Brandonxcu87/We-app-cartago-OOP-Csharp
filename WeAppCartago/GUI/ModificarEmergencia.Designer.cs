
namespace WeAppCartago
{
    partial class ModificarEmergencia
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
            this.cmb_cedula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txb_Parentesco = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_cedula = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_cedula
            // 
            this.cmb_cedula.BackColor = System.Drawing.Color.Black;
            this.cmb_cedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.cmb_cedula.FormattingEnabled = true;
            this.cmb_cedula.Location = new System.Drawing.Point(25, 63);
            this.cmb_cedula.Name = "cmb_cedula";
            this.cmb_cedula.Size = new System.Drawing.Size(121, 21);
            this.cmb_cedula.TabIndex = 32;
            this.cmb_cedula.SelectedIndexChanged += new System.EventHandler(this.cmb_cedula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "En caso de emergencia llamaremos a...";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_telefono.BackColor = System.Drawing.Color.Black;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txt_telefono.Location = new System.Drawing.Point(168, 103);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 30;
            this.txt_telefono.Text = "Telefono";
            // 
            // txb_Parentesco
            // 
            this.txb_Parentesco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_Parentesco.BackColor = System.Drawing.Color.Black;
            this.txb_Parentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Parentesco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_Parentesco.Location = new System.Drawing.Point(291, 103);
            this.txb_Parentesco.Name = "txb_Parentesco";
            this.txb_Parentesco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Parentesco.Size = new System.Drawing.Size(100, 20);
            this.txb_Parentesco.TabIndex = 29;
            this.txb_Parentesco.Text = "Parentesco";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_nombre.BackColor = System.Drawing.Color.Black;
            this.txb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_nombre.Location = new System.Drawing.Point(25, 143);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_nombre.Size = new System.Drawing.Size(366, 20);
            this.txb_nombre.TabIndex = 28;
            this.txb_nombre.Text = "Nombre";
            // 
            // txb_cedula
            // 
            this.txb_cedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_cedula.BackColor = System.Drawing.Color.Black;
            this.txb_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.txb_cedula.Location = new System.Drawing.Point(25, 103);
            this.txb_cedula.Name = "txb_cedula";
            this.txb_cedula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_cedula.Size = new System.Drawing.Size(100, 20);
            this.txb_cedula.TabIndex = 27;
            this.txb_cedula.Text = "Tu cedula";
            this.txb_cedula.Visible = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(199)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(32)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ingresar.Location = new System.Drawing.Point(262, 207);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ingresar.Size = new System.Drawing.Size(159, 45);
            this.btn_ingresar.TabIndex = 33;
            this.btn_ingresar.Text = "Modificar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // ModificarEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.cmb_cedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txb_Parentesco);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.txb_cedula);
            this.Name = "ModificarEmergencia";
            this.Text = "ModificarEmergencia";
            this.Load += new System.EventHandler(this.ModificarEmergencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txb_Parentesco;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_cedula;
        private System.Windows.Forms.Button btn_ingresar;
    }
}