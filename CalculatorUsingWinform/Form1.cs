namespace CalculatorUsingWinform;

public partial class Form1 : Form
{
    public static string Text1;
    public static string Text2;
    public static string Text3;
    public static string Text4;

    public Form1()
    {
        InitializeComponent();
        CalculatorButton button1 = new CalculatorButton
        {
            ButtonValue = "Calculate", 
            Location = new Point(273, 317) 
        };

        //  ButtonClicked event
        button1.ButtonClicked += Calculate_Click;

        // Add the custom button to the form
        this.Controls.Add(button1);

    }

    private void Calculate_Click(object sender, EventArgs e)
    {
        if (Num1TextBox.Text == "" && Num2TextBox.Text == "")
        {
            Num1errorProvider.SetError(this.Num1TextBox, "Fields are empty.");
            //MessageBox.Show("Fields are empty.");
        }
        else if (Num1TextBox.Text == "")
        {
            Num1errorProvider.SetError(this.Num1TextBox, "First Operand is missing.");
            //MessageBox.Show("First Operand is missing.");
        }
        else if (Num2TextBox.Text == "")
        {
            Num1errorProvider.Clear();

            Num2errorProvider.SetError(this.Num2TextBox, "Second Operand is missing.");
            //MessageBox.Show("Second Operand is missing.");
        }
        else if (!int.TryParse(Num1TextBox.Text, out int number1) || !int.TryParse(Num2TextBox.Text, out int number2)) //Check if the inputs are int number or not
        {
            MessageBox.Show("Enter the valid input.");
        }
        else
        {
            if (OperatorTextBox.Text == "")
            {
                MessageBox.Show("Enter the operator.");
            }
            else if (OperatorTextBox.Text == "+")
            {
                var sum = int.Parse(Num1TextBox.Text) + int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "-")
            {
                var sum = int.Parse(Num1TextBox.Text) - int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "*")
            {
                var sum = int.Parse(Num1TextBox.Text) * int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "/")
            {
                var sum = int.Parse(Num1TextBox.Text) / int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "%")
            {
                var sum = int.Parse(Num1TextBox.Text) % int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "^")
            {
                var sum = int.Parse(Num1TextBox.Text) ^ int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "&")
            {
                var sum = int.Parse(Num1TextBox.Text) & int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else if (OperatorTextBox.Text == "|")
            {
                var sum = int.Parse(Num1TextBox.Text) + int.Parse(Num2TextBox.Text);
                ResultTextBox.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid operator.");
            }
        }
    }

    private void Clear_Click(object sender, EventArgs e)
    {
        Num1TextBox.Clear();
        Num2TextBox.Clear();
        OperatorTextBox.Clear();
        ResultTextBox.Clear();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Text1 = Num1TextBox.Text;
        Text2 = Num2TextBox.Text;
        Text3 = OperatorTextBox.Text;
        Text4 = ResultTextBox.Text;

        Form2 f2 = new Form2();
        f2.Show();
    }
}
