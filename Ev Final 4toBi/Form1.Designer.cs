namespace Ev_Final_4toBi
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
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.LBL = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(135, 121);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(100, 26);
            this.TextContraseña.TabIndex = 0;
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(423, 121);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 26);
            this.TextUsuario.TabIndex = 1;
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(296, 34);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(105, 20);
            this.LBL.TabIndex = 2;
            this.LBL.Text = "Examen Final";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnIngresar.Location = new System.Drawing.Point(284, 217);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(91, 30);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.TextContraseña);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Button BtnIngresar;
    }
}

