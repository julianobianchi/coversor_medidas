namespace coversor_medidas
{
    public partial class Form1 : Form
    {
        public double num0;
        public double num1;
        public double num2;
        public double num3;
        public double num4;
        public double num5;
        public double num6;
        public double num7;
        public double num8;
        public double num9;
        public double virgula;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblRes1.Text += 9;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblRes1.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblRes1.Text += ",";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            lblRes1.Text = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //calulos
            if (comboBox1.Text == "Metros" && comboBox2.Text == "Centímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 100;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Metros" && comboBox2.Text == "Milímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 1000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Metros" && comboBox2.Text == "Quilômetros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 1000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Metros" && comboBox2.Text == "Polegadas")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 39.37;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Metros" && comboBox2.Text == "Pés")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 3.28084;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Metros" && comboBox2.Text == "Metros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                lblRes2.Text = num.ToString();
            }
            if (comboBox1.Text == "Centímetro" && comboBox2.Text == "Metros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 100;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Centímetro" && comboBox2.Text == "Milímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 10;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Centímetro" && comboBox2.Text == "Quilômetros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 100000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Centímetro" && comboBox2.Text == "Polegadas")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 0.39;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Centímetro" && comboBox2.Text == "Pés")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 0.032808;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Centímetro" && comboBox2.Text == "Centímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                lblRes2.Text = num.ToString();
            }
            if (comboBox1.Text == "Milímetro" && comboBox2.Text == "Metros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 1000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Milímetro" && comboBox2.Text == "Centímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 10;
                //teste commit

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Milímetro" && comboBox2.Text == "Quilômetros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 0.000001;

                lblRes2.Text = total.ToString("0.000000");
            }
            if (comboBox1.Text == "Milímetro" && comboBox2.Text == "Polegadas")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 25.4;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Milímetro" && comboBox2.Text == "Pés")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 304.8;
                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Milímetro" && comboBox2.Text == "Milímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                lblRes2.Text = num.ToString();
            }
            if (comboBox1.Text == "Quilômetros" && comboBox2.Text == "Centímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 100000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Quilômetros" && comboBox2.Text == "Milímetro")
            {
                Double total;
                Double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 1000000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Quilômetros" && comboBox2.Text == "Metros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 1000;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Quilômetros" && comboBox2.Text == "Polegadas")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 39370;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Quilômetros" && comboBox2.Text == "Pés")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 3280.84;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Quilômetros" && comboBox2.Text == "Quilômetros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                lblRes2.Text = num.ToString();
            }
            //Falta concluir





            if (comboBox1.Text == "Polegadas" && comboBox2.Text == "Centímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 2.45;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Polegadas" && comboBox2.Text == "Milímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 25.4;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Polegadas" && comboBox2.Text == "Quilômetros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 0.0000254;

                lblRes2.Text = total.ToString("0.0000000");
            }
            if (comboBox1.Text == "Polegadas" && comboBox2.Text == "Metros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 39.37;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Polegadas" && comboBox2.Text == "Pés")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 12;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Polegadas" && comboBox2.Text == "Polegadas")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                lblRes2.Text = num.ToString();
            }

            if (comboBox1.Text == "Pés" && comboBox2.Text == "Centímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 30.48;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Pés" && comboBox2.Text == "Milímetro")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 304.8;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Pés" && comboBox2.Text == "Quilômetros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 3281;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Pés" && comboBox2.Text == "Metros")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num / 3.281;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Pés" && comboBox2.Text == "Polegadas")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                total = num * 12;

                lblRes2.Text = total.ToString();
            }
            if (comboBox1.Text == "Pés" && comboBox2.Text == "Pés")
            {
                double total;
                double num;
                num = Convert.ToDouble(lblRes1.Text);
                lblRes2.Text = num.ToString();
            }
        }
    }
}
//num1 = Convert.ToDouble(txtNum1.Text);
//txtResul.Text = resultado.ToString();