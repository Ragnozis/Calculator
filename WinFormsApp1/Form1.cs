namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1, number2;
        int operation, repeat = 0;
        bool number_sign = true;
        bool end = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 0;
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + 9;
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Screen.Text + ",";
            
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (repeat == 0)
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 1;
                Label.Text = number1.ToString();
                number_sign = true;
                repeat = repeat + 1;
            }
            else
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 1;
                Label.Text = number1.ToString();
                number_sign = true;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (repeat == 0)
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 2;
                Label.Text = number1.ToString();
                number_sign = true;
                repeat = repeat + 1;
            }
            else
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 2;
                Label.Text = number1.ToString();
                number_sign = true;
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (repeat == 0)
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 3;
                Label.Text = number1.ToString();
                number_sign = true;
                repeat = repeat + 1;
            }
            else
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 3;
                Label.Text = number1.ToString();
                number_sign = true;
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (repeat == 0)
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 4;
                Label.Text = number1.ToString();
                number_sign = true;
                repeat = repeat + 1;
            }
            else
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 4;
                Label.Text = number1.ToString();
                number_sign = true;
            }
        }

        private void calculate()
        {
            switch (operation)
            {
                case 1:
                    number2 = number1 + double.Parse(Screen.Text);
                    Screen.Text = number2.ToString();
                    if (number2 < 0) number_sign = false;
                    break;
                case 2:
                    number2 = number1 - double.Parse(Screen.Text);
                    Screen.Text = number2.ToString();
                    if (number2 < 0) number_sign = false;
                    break;
                case 3:
                    number2 = number1 * double.Parse(Screen.Text);
                    Screen.Text = number2.ToString();
                    if (number2 < 0) number_sign = false;
                    break;
                case 4:
                    number2 = number1 / double.Parse(Screen.Text);
                    Screen.Text = number2.ToString();
                    if (number2 < 0) number_sign = false;
                    break;
                default:
                    break;
            }
        }

        private void Åquals_Click(object sender, EventArgs e)
        {
            if (repeat == 1)
            {
                calculate();
                Label.Text = "";
                end = true;
                repeat = 0;
            }
            else
            {
                Label.Text = "";
                end = true;
                repeat = 0;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Label.Text = "";
            repeat = 0;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            int lenght = Screen.Text.Length - 1;
            string text = Screen.Text;
            Screen.Clear();
            for (int i = 0; i < lenght; i++)
            {
                Screen.Text = Screen.Text + text[i];
            }
            repeat = 0;
        }
        private void Sign_Click(object sender, EventArgs e)
        {
            if(number_sign == true)
            {
                Screen.Text = "-" + Screen.Text;
                number_sign = false;
            }
            else
            {
                Screen.Text = Screen.Text.Replace("-", "");
                number_sign = true;
            }
            repeat = 0;
        }







    }
}