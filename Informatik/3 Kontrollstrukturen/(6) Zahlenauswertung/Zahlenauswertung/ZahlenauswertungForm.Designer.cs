namespace Zahlenauswertung
{
    partial class ZahlenauswertungForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.zahl1TextBox = new System.Windows.Forms.TextBox();
            this.zahl2TextBox = new System.Windows.Forms.TextBox();
            this.zahl3TextBox = new System.Windows.Forms.TextBox();
            this.mittelwertLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.berechneButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zahl1TextBox
            // 
            this.zahl1TextBox.Location = new System.Drawing.Point(72, 24);
            this.zahl1TextBox.Name = "zahl1TextBox";
            this.zahl1TextBox.Size = new System.Drawing.Size(88, 20);
            this.zahl1TextBox.TabIndex = 0;
            this.zahl1TextBox.Text = "100";
            // 
            // zahl2TextBox
            // 
            this.zahl2TextBox.Location = new System.Drawing.Point(72, 58);
            this.zahl2TextBox.Name = "zahl2TextBox";
            this.zahl2TextBox.Size = new System.Drawing.Size(88, 20);
            this.zahl2TextBox.TabIndex = 1;
            this.zahl2TextBox.Text = "1";
            // 
            // zahl3TextBox
            // 
            this.zahl3TextBox.Location = new System.Drawing.Point(72, 92);
            this.zahl3TextBox.Name = "zahl3TextBox";
            this.zahl3TextBox.Size = new System.Drawing.Size(88, 20);
            this.zahl3TextBox.TabIndex = 2;
            this.zahl3TextBox.Text = "1";
            // 
            // mittelwertLabel
            // 
            this.mittelwertLabel.Location = new System.Drawing.Point(13, 24);
            this.mittelwertLabel.Name = "mittelwertLabel";
            this.mittelwertLabel.Size = new System.Drawing.Size(147, 16);
            this.mittelwertLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zahl 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zahl 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zahl 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.berechneButton);
            this.groupBox1.Controls.Add(this.zahl3TextBox);
            this.groupBox1.Controls.Add(this.zahl2TextBox);
            this.groupBox1.Controls.Add(this.zahl1TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // berechneButton
            // 
            this.berechneButton.Location = new System.Drawing.Point(72, 126);
            this.berechneButton.Name = "berechneButton";
            this.berechneButton.Size = new System.Drawing.Size(88, 23);
            this.berechneButton.TabIndex = 10;
            this.berechneButton.Text = "Berechnen";
            this.berechneButton.Click += new System.EventHandler(this.berechneButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maximumLabel);
            this.groupBox2.Controls.Add(this.mittelwertLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // maximumLabel
            // 
            this.maximumLabel.Location = new System.Drawing.Point(13, 48);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(147, 16);
            this.maximumLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(194, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zahlenauswertung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button berechneButton;
        private System.Windows.Forms.TextBox zahl1TextBox;
        private System.Windows.Forms.TextBox zahl2TextBox;
        private System.Windows.Forms.TextBox zahl3TextBox;
        private System.Windows.Forms.Label mittelwertLabel;
        private System.Windows.Forms.Label maximumLabel;
    }
}