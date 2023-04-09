namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1, number2;
        int operation, repeat = 0;
        bool end = false;
        bool dot = true;
        bool size = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void Zero_Click(object sender, EventArgs e)   // c# regex, ñàéò regex101
        {
            if (size == true)
            {
                if (end == true)
                {
                    Screen.Text = "";
                    end = false;
                }
                Screen.Text = Screen.Text + Zero.Text;
            }

            

        }

       

        private void Number_Click(object sender, EventArgs e)
        {
            if (size == true)
            {
                if (end == true)
                {
                    Screen.Text = "";
                    end = false;
                }
                var tmp = sender as Button;
                Screen.Text = Screen.Text + tmp.Text;
            }
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (size == true)
            {
                if ((double.TryParse(Screen.Text, out number1) == true) && dot == true)
                {
                    if (end == true)
                    {
                        Screen.Text = "";
                        end = false;
                    }
                    Screen.Text = Screen.Text + Dot.Text;
                    dot = false;

                }
            }
            
        }
        private void Plus_Click(object sender, EventArgs e)
        { if (Screen.Text != "")
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
                dot = true;
                size = true;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "")
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
                dot = true;
                size = true;

            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "")
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
                dot = true;
                size = true;

            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "")
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
                dot = true;
                size = true;

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
                Screen.Text = Label.Text;
                Label.Text = "";
                end = true;
                repeat = 0;
            }
            dot = true;
            size = true;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Label.Text = "";
            repeat = 0;
            dot = true;
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            if (Screen.Text != "" && double.Parse(Screen.Text) > 9999999999999)
            {
                size = false;
            }
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