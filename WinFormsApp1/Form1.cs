namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1, number2;
        int operation, repeat = 0;
        bool end = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)   // c# regex, Ò‡ÈÚ regex101
        {
            if (double.TryParse(Screen.Text, out number1) == true)
            {
                if (end == true)
                {
                    Screen.Text = "";
                    end = false;
                }
                Screen.Text = Zero.Text;

            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Six.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (end == true)
            {
                Screen.Text = "";
                end = false;
            }
            Screen.Text = Nine.Text;
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Screen.Text, out number1) == true)
            {
                if (end == true)
                {
                    Screen.Text = "";
                    end = false;
                }
                Screen.Text = Dot.Text;

            }
            
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (repeat != 0)
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 1;
                repeat = repeat + 1;
                Label.Text = number1.ToString();

               
            }
            else
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 1;
                Label.Text = number1.ToString();
                repeat = repeat + 1;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (repeat != 0)
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 2;
                repeat = repeat + 1;
                Label.Text = number1.ToString();

                
            }
            else
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 2;
                Label.Text = number1.ToString();
                repeat = repeat + 1;
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (repeat != 0)
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 3;
                repeat = repeat + 1;
                Label.Text = number1.ToString();

            }
            else
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 3;
                Label.Text = number1.ToString();
                repeat = repeat + 1;
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (repeat != 0)
            {
                calculate();
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 4;
                repeat = repeat + 1;
                Label.Text = number1.ToString();
            }
            else
            {
                number1 = double.Parse(Screen.Text);
                Screen.Clear();
                operation = 4;
                Label.Text = number1.ToString();
                repeat = repeat + 1;
            }
        }

        private void calculate()
        {
            switch (operation)
            {
                case 1:
                    
                        number2 = number1 + double.Parse(Screen.Text);
                        Screen.Text = number2.ToString();
                    
                    break;
                case 2:
                    
                        number2 = number1 - double.Parse(Screen.Text);
                        Screen.Text = number2.ToString();
                    
                    break;
                case 3:
                    
                        number2 = number1 * double.Parse(Screen.Text);
                        Screen.Text = number2.ToString();
                    
                    break;
                case 4:
                   
                        number2 = number1 / double.Parse(Screen.Text);
                        Screen.Text = number2.ToString();
                    
                    break;
                default:
                    break;
            }
        }

        private void ≈quals_Click(object sender, EventArgs e)
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
                Screen.Text = Label.Text;
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

            if (Screen.Text.Length != 0)
            {
                string text = Screen.Text;
                text = text.Substring(0, text.Length - 1);
                Screen.Text = text;
                repeat = 0;
            }
            


        }
        private void Sign_Click(object sender, EventArgs e)
        {
            double n;
            n = double.Parse(Screen.Text);
            n = n * -1;
            Screen.Text = n.ToString();
            repeat = 0;
        }







    }
}