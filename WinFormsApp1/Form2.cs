using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double itl, ing, eg;
            ing = double.Parse(textBox1.Text);
            eg = double.Parse(textBox2.Text);
            if (ing >= 4800 && ing <= 500000)
            if (eg >= 4800 && eg <= 500000)
            {
                itl = ing - eg;
                textBox3.Text = itl.ToString();
            }
            else
            {
                MessageBox.Show("rango entre 4800 y 500000", "Error");
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                 "Calcular Utilidad",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

 
    }
}
