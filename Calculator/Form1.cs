namespace Calculator
{
    public partial class Form1 : Form
    {
        double resualtView = 0;
        string operationstr = " ";
        
        string sign;
        double num1;
        double num2;

        bool isCheak = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

       

        private void btn5_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            yazitxt.Text = "0";
        }

      

        private void btnbol_Click(object sender, EventArgs e)
        {
            Operetion("/");

        }

        private void btnvur_Click(object sender, EventArgs e)
        {
            Operetion("*");
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Operetion("-");

        }

        private void btmplus_Click(object sender, EventArgs e)
        {
            Operetion("+");
        }

        


        




        private void Operetion(string sign)
        {
            num1 = Convert.ToDouble(yazitxt.Text);
            label1.Text = yazitxt.Text;
            label1.Text += sign;
            this.sign = sign;
            isCheak = true; 
        }

        private void btnmoterize_Click(object sender, EventArgs e)
        {

        }

        private void btnmi_Click(object sender, EventArgs e)
        {

        }

        private void btnfaiz_Click(object sender, EventArgs e)
        {
            Operetion("%");
        }

        private void btnvergul_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            yazitxt.Text = yazitxt.Text + button.Text;
            if (yazitxt.Text == "0")
            {
                yazitxt.Clear();

            }

            
        }
        private void UpdateDisplay()
        {
            yazitxt.Text = operationstr;
        }

        private void yazitxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnberaber_Click(object sender, EventArgs e)
        {
            if(operationstr != " ")
            {
                double secondOperand = double.Parse(operationstr);

                switch (secondOperand)
                {
                    case '+':
                        resualtView += secondOperand;
                        break;
                    case '-':
                        resualtView -= secondOperand;
                        break;
                    case '*':
                        resualtView *= secondOperand;
                        break;
                    case '/':
                        resualtView /= secondOperand;
                        break;


                }

                operationstr = resualtView.ToString();
                UpdateDisplay();

            }
        }
    }
}
