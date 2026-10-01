using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TextContraseña.Text == "92=29" && TextUsuario.Text == "cecilio")
            {
                this.Hide();
                Form app = new Form();
                app.Show();

            }
            else
            {
                MessageBox.Show("datos incorectos");
            }
        }
    
    }
}
