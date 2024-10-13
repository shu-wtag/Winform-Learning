namespace CalculatorUsingWinform;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Clear = new Button();
        ResultTextBox = new TextBox();
        Result = new Label();
        OperatorTextBox = new TextBox();
        Operator = new Label();
        Num2TextBox = new TextBox();
        Num2 = new Label();
        Num1TextBox = new TextBox();
        Num1 = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // Clear
        // 
        Clear.BackColor = SystemColors.ButtonHighlight;
        Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Clear.Location = new Point(443, 317);
        Clear.Name = "Clear";
        Clear.Size = new Size(75, 35);
        Clear.TabIndex = 4;
        Clear.Text = "Clear";
        Clear.UseVisualStyleBackColor = false;
        Clear.Click += Clear_Click;
        // 
        // ResultTextBox
        // 
        ResultTextBox.BackColor = SystemColors.InactiveCaption;
        ResultTextBox.Location = new Point(428, 376);
        ResultTextBox.Name = "ResultTextBox";
        ResultTextBox.Size = new Size(100, 23);
        ResultTextBox.TabIndex = 19;
        // 
        // Result
        // 
        Result.AutoSize = true;
        Result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Result.Location = new Point(293, 374);
        Result.Name = "Result";
        Result.Size = new Size(53, 21);
        Result.TabIndex = 18;
        Result.Text = "Result";
        // 
        // OperatorTextBox
        // 
        OperatorTextBox.BackColor = SystemColors.Info;
        OperatorTextBox.Location = new Point(428, 263);
        OperatorTextBox.Name = "OperatorTextBox";
        OperatorTextBox.Size = new Size(100, 23);
        OperatorTextBox.TabIndex = 2;
        // 
        // Operator
        // 
        Operator.AutoSize = true;
        Operator.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Operator.Location = new Point(273, 261);
        Operator.Name = "Operator";
        Operator.Size = new Size(73, 21);
        Operator.TabIndex = 16;
        Operator.Text = "Operator";
        // 
        // Num2TextBox
        // 
        Num2TextBox.BackColor = SystemColors.Info;
        Num2TextBox.Location = new Point(428, 197);
        Num2TextBox.Name = "Num2TextBox";
        Num2TextBox.Size = new Size(100, 23);
        Num2TextBox.TabIndex = 1;
        // 
        // Num2
        // 
        Num2.AutoSize = true;
        Num2.Font = new Font("Segoe UI", 12F);
        Num2.Location = new Point(292, 195);
        Num2.Name = "Num2";
        Num2.Size = new Size(54, 21);
        Num2.TabIndex = 14;
        Num2.Text = "Num2";
        // 
        // Num1TextBox
        // 
        Num1TextBox.BackColor = SystemColors.Info;
        Num1TextBox.Location = new Point(428, 144);
        Num1TextBox.Name = "Num1TextBox";
        Num1TextBox.Size = new Size(100, 23);
        Num1TextBox.TabIndex = 0;
        // 
        // Num1
        // 
        Num1.AutoSize = true;
        Num1.Font = new Font("Segoe UI", 12F);
        Num1.Location = new Point(292, 142);
        Num1.Name = "Num1";
        Num1.Size = new Size(54, 21);
        Num1.TabIndex = 12;
        Num1.Text = "Num1";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(314, 51);
        label1.Name = "label1";
        label1.Size = new Size(146, 35);
        label1.TabIndex = 11;
        label1.Text = "Calculator";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        ClientSize = new Size(800, 450);
        Controls.Add(Clear);
        Controls.Add(ResultTextBox);
        Controls.Add(Result);
        Controls.Add(OperatorTextBox);
        Controls.Add(Operator);
        Controls.Add(Num2TextBox);
        Controls.Add(Num2);
        Controls.Add(Num1TextBox);
        Controls.Add(Num1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button Clear;
    private Button Calculate;
    private TextBox ResultTextBox;
    private Label Result;
    private TextBox OperatorTextBox;
    private Label Operator;
    private TextBox Num2TextBox;
    private Label Num2;
    private TextBox Num1TextBox;
    private Label Num1;
    private Label label1;
}
