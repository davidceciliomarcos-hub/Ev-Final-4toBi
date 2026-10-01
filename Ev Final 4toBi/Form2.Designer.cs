namespace Ev_Final_4toBi
{
    partial class Form2
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
            this.TextVar1 = new System.Windows.Forms.TextBox();
            this.Textvar2 = new System.Windows.Forms.TextBox();
            this.BtbProducto = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextVar1
            // 
            this.TextVar1.Location = new System.Drawing.Point(202, 57);
            this.TextVar1.Name = "TextVar1";
            this.TextVar1.Size = new System.Drawing.Size(100, 26);
            this.TextVar1.TabIndex = 0;
            // 
            // Textvar2
            // 
            this.Textvar2.Location = new System.Drawing.Point(427, 57);
            this.Textvar2.Name = "Textvar2";
            this.Textvar2.Size = new System.Drawing.Size(100, 26);
            this.Textvar2.TabIndex = 1;
            // 
            // BtbProducto
            // 
            this.BtbProducto.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtbProducto.Location = new System.Drawing.Point(144, 152);
            this.BtbProducto.Name = "BtbProducto";
            this.BtbProducto.Size = new System.Drawing.Size(91, 27);
            this.BtbProducto.TabIndex = 2;
            this.BtbProducto.Text = "Producto";
            this.BtbProducto.UseVisualStyleBackColor = false;
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSuma.Location = new System.Drawing.Point(443, 152);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 39);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnPotencia.Location = new System.Drawing.Point(144, 254);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(82, 32);
            this.BtnPotencia.TabIndex = 4;
            this.BtnPotencia.Text = "Potencia";
            this.BtnPotencia.UseVisualStyleBackColor = false;
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnDivision.Location = new System.Drawing.Point(443, 254);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 32);
            this.BtnDivision.TabIndex = 5;
            this.BtnDivision.Text = "Division";
            this.BtnDivision.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtbProducto);
            this.Controls.Add(this.Textvar2);
            this.Controls.Add(this.TextVar1);
            this.Name = "Form2";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextVar1;
        private System.Windows.Forms.TextBox Textvar2;
        private System.Windows.Forms.Button BtbProducto;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnDivision;
    }
}