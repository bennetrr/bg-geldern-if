using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TickTackToe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            // Create elements
            this.buttonReset = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            for (int i = 0; i < 9; i++)
            {
                ticTacToeButtons.Add(new Button());
            }
            
            this.SuspendLayout();
            
            // Locations for the buttons
            List<Point> locs = new List<Point>();
            locs.Add(new Point(12, 12));
            locs.Add(new Point(108, 12));
            locs.Add(new Point(204, 12));
            locs.Add(new Point(12, 108));
            locs.Add(new Point(108, 108));
            locs.Add(new Point(204, 108));
            locs.Add(new Point(12, 204));
            locs.Add(new Point(108, 204));
            locs.Add(new Point(204, 204));
            
            // Set button properties
            for (int i = 0; i < ticTacToeButtons.Count; i++)
            {
                var b = ticTacToeButtons[i];
                b.Location = locs[i];
                b.Name = "button" + i.ToString();
                b.Size = new Size(90, 90);
                b.UseVisualStyleBackColor = true;
                b.MouseClick += ButtonClicked;
            }

            // Reset button
            this.buttonReset.Location = new System.Drawing.Point(12, 316);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(282, 90);
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.MouseClick += ResetClicked;
            
            // Next player label
            this.label.Location = new System.Drawing.Point(12, 416);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(282, 21);
            this.label.Text = "Nächster Spieler: X";
            
            // Main form
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(309, 446);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            
            // Add elements to the form
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label);
            foreach (var button in ticTacToeButtons)
            {
                this.Controls.Add(button);
            }
            
            this.ResumeLayout(false);
        }

        private Button buttonReset;
        private List<Button> ticTacToeButtons = new List<Button>();
        private Label label;
    }
}