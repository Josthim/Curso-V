namespace pjPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, egr, monto, util, cuota, plazo,utpor;


            if (textBox1.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                maskedTextBox1.Focus();

            }
            else
            {

                ing = double.Parse(maskedTextBox1.Text);
                egr = double.Parse(maskedTextBox2.Text);
                monto = double.Parse(maskedTextBox3.Text);
                plazo = double.Parse(comboBox2.Text);
                if (ing >= 500 && ing <= 10000)
                    if (egr <= ing)
                    {
                        util = ing - egr;
                        textBox6.Text = util.ToString();

                        
                    }
                    else
                    {
                        MessageBox.Show("rango entre 500 y 10000", "Error");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();

                    }

                    if (monto < 100 || monto > 5000)
                    {
                        MessageBox.Show("rango entre 100 y 5000", "Error");
                        maskedTextBox3.Text = "";
                        maskedTextBox3.Focus();
                    }
                    else
                    {
                        cuota = monto / plazo;
                        textBox5.Text = cuota.ToString();

                    }
                util = double.Parse(textBox6.Text);
                utpor = double.Parse(textBox2.Text);
                if (util > utpor)
                {
                   
                    utpor = util * 0.35;
                    textBox2.Text = utpor.ToString();

                }
                    
                                    

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                 "Solicitud de Prestamo",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }




    }
}







