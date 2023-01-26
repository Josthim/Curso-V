namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, total;
            string r, a;

            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                textBox2.Focus();

            }
            else
            {
                n1 = int.Parse(textBox2.Text);
                n2 = int.Parse(textBox3.Text);
                n3 = int.Parse(textBox4.Text);
                n4 = int.Parse(textBox5.Text);
                if (n1 < 0 || n1 > 25)
                {
                    MessageBox.Show("rango entre 0 y 25", "Error");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                else if (n2 < 0 || n2 > 25)
                {
                    MessageBox.Show("rango entre 0 y 25", "Error");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                else if(n3 < 0 || n3 > 25)
                {
                    MessageBox.Show("rango entre 0 y 25", "Error");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else if(n4 < 0 || n4 > 25)
                {
                    MessageBox.Show("rango entre 0 y 25", "Error");
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                else
                {
                    total = n1 + n2 + n3 + n4;
                    textBox1.Text = total.ToString();
                    if(total < 60)
                    {
                        r = " REPROVADO";
                        textBox6.Text = r.ToString();

                    }
                    else
                    {
                        a = "APROVADO";
                        textBox6.Text = a.ToString();
                    }
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                        "NOTAS",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
                this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}