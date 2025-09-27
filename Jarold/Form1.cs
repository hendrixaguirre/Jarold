using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            String Sexo = tbSex.Text;
            int Jaños = Convert.ToInt32(tbJaños.Text);
            if (btnAccept.Enabled)
            {
                MessageBox.Show($"Hola Jarold!\n1. Eres {Sexo}\n2. Tienes {Jaños} jaños", "Entraste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Cerrando la aplicación...");
            this.Close();
        }
    }
}
