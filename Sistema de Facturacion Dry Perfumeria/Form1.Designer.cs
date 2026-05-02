namespace Sistema_de_Facturacion_Dry_Perfumeria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnelUsuario = new System.Windows.Forms.Panel();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnelContraseña = new System.Windows.Forms.Panel();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnelUsuario.SuspendLayout();
            this.pnelContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(26, 39);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(84, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(117, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 47);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Dry Perfumeria";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pnelUsuario);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnelContraseña);
            this.panel1.Controls.Add(this.lblContraseña);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(407, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 652);
            this.panel1.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(62, 494);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(363, 37);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.panel5.Location = new System.Drawing.Point(62, 438);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 1);
            this.panel5.TabIndex = 1;
            // 
            // pnelUsuario
            // 
            this.pnelUsuario.Controls.Add(this.txtbUsuario);
            this.pnelUsuario.Controls.Add(this.textBox4);
            this.pnelUsuario.Location = new System.Drawing.Point(62, 288);
            this.pnelUsuario.Name = "pnelUsuario";
            this.pnelUsuario.Size = new System.Drawing.Size(366, 29);
            this.pnelUsuario.TabIndex = 2;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtbUsuario.Location = new System.Drawing.Point(0, 8);
            this.txtbUsuario.Multiline = true;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.PasswordChar = '*';
            this.txtbUsuario.Size = new System.Drawing.Size(337, 21);
            this.txtbUsuario.TabIndex = 0;
            this.txtbUsuario.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(0, 8);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(337, 26);
            this.textBox4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.panel3.Location = new System.Drawing.Point(62, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 1);
            this.panel3.TabIndex = 1;
            // 
            // pnelContraseña
            // 
            this.pnelContraseña.Controls.Add(this.txtbContraseña);
            this.pnelContraseña.Controls.Add(this.textBox1);
            this.pnelContraseña.Location = new System.Drawing.Point(62, 407);
            this.pnelContraseña.Name = "pnelContraseña";
            this.pnelContraseña.Size = new System.Drawing.Size(366, 32);
            this.pnelContraseña.TabIndex = 2;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbContraseña.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtbContraseña.Location = new System.Drawing.Point(0, 8);
            this.txtbContraseña.Multiline = true;
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(337, 26);
            this.txtbContraseña.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(0, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 26);
            this.textBox1.TabIndex = 0;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(58, 370);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(123, 23);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(58, 251);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.Location = new System.Drawing.Point(144, 183);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(178, 37);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 789);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnelUsuario.ResumeLayout(false);
            this.pnelUsuario.PerformLayout();
            this.pnelContraseña.ResumeLayout(false);
            this.pnelContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnelUsuario;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnelContraseña;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBienvenido;
    }
}

