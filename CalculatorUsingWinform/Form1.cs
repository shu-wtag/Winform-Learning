namespace CalculatorUsingWinform;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        CalculatorButton button1 = new CalculatorButton
        {
            ButtonValue = "Calculate", // Set button value
            Location = new Point(273, 317) // Set button location
        };

        // Subscribe to the ButtonClicked event
        button1.ButtonClicked += Calculate_Click;

        // Add the custom button to the form
        this.Controls.Add(button1);

    }

    private void Calculate_Click(object sender, EventArgs e)
    {
        if (Num1TextBox.Text == "" && Num2TextBox.Text == "")
        {
            MessageBox.Show("Fields are empty.");
        }
        else if (Num1TextBox.Text == "")
        {
            MessageBox.Show("First Operand is missing.");
        }
        else if (Num2TextBox.Text == "")
        {
            MessageBox.Show("Second Operand is missing.");
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
}
