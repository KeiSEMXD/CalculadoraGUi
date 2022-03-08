namespace CalculadoraGUI_version_final_
{
    public partial class FPrincipal : Form
    {
        string input = string.Empty;
        string operando1 = string.Empty;
        string operando2 = string.Empty;
        char operacion;
        double resultado = 0.0;

        public FPrincipal()
        {
            InitializeComponent();
        }

      



        private void Bcero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void Bpunto_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input; 
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "C";
            this.input = string.Empty;
            this.operando1 = string.Empty;
            this.operando2= string.Empty;
            
           
        }

        private void Brestar_Click(object sender, EventArgs e)
        {
            operando1 = input;
            operacion = '-';
            input = string.Empty;
        }

        private void Bones_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Btwo_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Bthree_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void Bfour_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Bfive_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Bsix_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Bseven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Beigth_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Bnine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Bsumar_Click(object sender, EventArgs e)
        {
            operando1 = input;
            operacion = '+';
            input = string.Empty;
        }

        private void Bmultiplicar_Click(object sender, EventArgs e)
        {
            operando1 = input;
            operacion = '*';
            input = string.Empty;
        }

        private void Bdividir_Click(object sender, EventArgs e)
        {
            operando1 = input;
            operacion = '/';
            input = string.Empty;
        }

        private void Bigual_Click(object sender, EventArgs e)
        {
            operando2 = input;
            double num1, num2;
            double.TryParse(operando1, out num1);
            double.TryParse(operando2, out num2);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operando1 = string.Empty;
            this.operando2 = string.Empty;


            if(operacion == '+')
            {
              resultado = num1 + num2;
              textBox1.Text = resultado.ToString();
            }
             else if(operacion == '-') {
                resultado = num1 - num2;
                textBox1.Text = resultado.ToString();

              }
            else if (operacion == '*')
            {
                resultado = num1 * num2;
                textBox1.Text = resultado.ToString();

            }
            else if (operacion == '/')
            {
                if(operacion != '0')
                {
                    resultado = num1 / num2;
                    textBox1.Text = resultado.ToString();

                }
                else
                {
                    textBox1.Text = "No se puede dividir entre 0";
                }
               

            }

            else if(operacion == '√')
            {
                resultado = Math.Sqrt(num1);
                textBox1.Text = resultado.ToString();

            }

            else if (operacion == 'x')
            {
                int exponente = 2;
                resultado = Math.Pow(num1, exponente);
                textBox1.Text = resultado.ToString();
            }
            
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BRaiz2_Click(object sender, EventArgs e)
        {
            operando1 = input;
            operacion = '√';
            input = string.Empty;

        }

        private void Belevacion_Click(object sender, EventArgs e)
        {
            operando1 = input;
            operacion = 'x';
            input = string.Empty;
        }
    }
}