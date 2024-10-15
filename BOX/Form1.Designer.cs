namespace BOX
{
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
            Combo = new ComboBox();
            SuspendLayout();
            // 
            // Combo
            // 
            Combo.FormattingEnabled = true;
            Combo.Items.AddRange(new object[] { "Mango", "Banana", "Cherry", "Apple", "Grape", "Blueberry" });
            Combo.Location = new Point(324, 129);
            Combo.Name = "Combo";
            Combo.Size = new Size(313, 23);
            Combo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Combo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Combo;
    }
}
