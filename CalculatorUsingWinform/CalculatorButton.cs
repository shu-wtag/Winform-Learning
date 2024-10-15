using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorUsingWinform
{
    public class CalculatorButton : Button
    {
        public string ButtonValue { get; set; } // Property to hold button value

        public CalculatorButton()
        {
            // Set default properties for the button
            this.Size = new Size(100, 40); 
            this.BackColor = Color.LightGray; 
            this.Font = new Font("Arial", 14, FontStyle.Bold); 
            this.FlatStyle = FlatStyle.Flat;
        }

        // Override the OnPaint method to customize drawing
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent); // Call base method to handle default painting

            // Draw the button value
            TextRenderer.DrawText(pevent.Graphics, ButtonValue, this.Font, this.ClientRectangle, this.ForeColor);
        }

        // Override OnClick to trigger a custom event with the button value
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e); // Call the base click event

            // Raise an event with the button value
            ButtonClicked?.Invoke(this, new EventArgs()); // Custom event to notify button click
        }

        // Custom event for button clicks
        public event EventHandler ButtonClicked;
    }

}
