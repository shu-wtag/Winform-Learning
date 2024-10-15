namespace CalculatorUsingWinform
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Num1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Num1TextBox = new TextBox();
            Num2Textbox = new TextBox();
            OperatorTextBox = new TextBox();
            ResultTextBox = new TextBox();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.AutoSize = true;
            Num1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Num1.Location = new Point(221, 73);
            Num1.Name = "Num1";
            Num1.Size = new Size(65, 21);
            Num1.TabIndex = 0;
            Num1.Text = "Num1: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 123);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Num2: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(199, 173);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 0;
            label2.Text = "Operator: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 226);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 0;
            label3.Text = "Result:";
            // 
            // Num1TextBox
            // 
            Num1TextBox.Location = new Point(313, 73);
            Num1TextBox.Name = "Num1TextBox";
            Num1TextBox.Size = new Size(100, 23);
            Num1TextBox.TabIndex = 1;
            // 
            // Num2Textbox
            // 
            Num2Textbox.Location = new Point(313, 125);
            Num2Textbox.Name = "Num2Textbox";
            Num2Textbox.Size = new Size(100, 23);
            Num2Textbox.TabIndex = 1;
            // 
            // OperatorTextBox
            // 
            OperatorTextBox.Location = new Point(313, 173);
            OperatorTextBox.Name = "OperatorTextBox";
            OperatorTextBox.Size = new Size(100, 23);
            OperatorTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(313, 228);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(100, 23);
            ResultTextBox.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultTextBox);
            Controls.Add(OperatorTextBox);
            Controls.Add(Num2Textbox);
            Controls.Add(Num1TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Num1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Num1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Num1TextBox;
        private TextBox Num2Textbox;
        private TextBox OperatorTextBox;
        private TextBox ResultTextBox;
    }
}