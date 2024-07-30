namespace Widerstandsrechner_V0
{
    partial class Form1
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
            this.querschnittTextBox = new System.Windows.Forms.TextBox();
            this.laengeTextBox = new System.Windows.Forms.TextBox();
            this.widerstandswertLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialkonstanteTextBox = new System.Windows.Forms.TextBox();
            this.berechnenButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // querschnittTextBox
            // 
            this.querschnittTextBox.Location = new System.Drawing.Point(196, 22);
            this.querschnittTextBox.Name = "querschnittTextBox";
            this.querschnittTextBox.Size = new System.Drawing.Size(88, 20);
            this.querschnittTextBox.TabIndex = 0;
            this.querschnittTextBox.Text = "1,5";
            // 
            // laengeTextBox
            // 
            this.laengeTextBox.Location = new System.Drawing.Point(196, 55);
            this.laengeTextBox.Name = "laengeTextBox";
            this.laengeTextBox.Size = new System.Drawing.Size(88, 20);
            this.laengeTextBox.TabIndex = 1;
            this.laengeTextBox.Text = "100";
            // 
            // widerstandswertLabel
            // 
            this.widerstandswertLabel.Location = new System.Drawing.Point(196, 24);
            this.widerstandswertLabel.Name = "widerstandswertLabel";
            this.widerstandswertLabel.Size = new System.Drawing.Size(88, 20);
            this.widerstandswertLabel.TabIndex = 3;
            this.widerstandswertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Querschnitt in mm²";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Länge in m";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materialkonstante in m/(Ohm*mm²) oder Ohm*mm²/m";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialkonstanteTextBox);
            this.groupBox1.Controls.Add(this.berechnenButton);
            this.groupBox1.Controls.Add(this.laengeTextBox);
            this.groupBox1.Controls.Add(this.querschnittTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // materialkonstanteTextBox
            // 
            this.materialkonstanteTextBox.Location = new System.Drawing.Point(196, 88);
            this.materialkonstanteTextBox.Name = "materialkonstanteTextBox";
            this.materialkonstanteTextBox.Size = new System.Drawing.Size(88, 20);
            this.materialkonstanteTextBox.TabIndex = 11;
            this.materialkonstanteTextBox.Text = "56";
            // 
            // berechnenButton
            // 
            this.berechnenButton.Location = new System.Drawing.Point(196, 121);
            this.berechnenButton.Name = "berechnenButton";
            this.berechnenButton.Size = new System.Drawing.Size(88, 23);
            this.berechnenButton.TabIndex = 10;
            this.berechnenButton.Text = "Berechnen";
            this.berechnenButton.Click += new System.EventHandler(this.berechnenButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.widerstandswertLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 55);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Widerstandswert";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(322, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Widerstandsrechner";
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
        private System.Windows.Forms.Button berechnenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox querschnittTextBox;
        private System.Windows.Forms.TextBox laengeTextBox;
        private System.Windows.Forms.Label widerstandswertLabel;
        private System.Windows.Forms.TextBox materialkonstanteTextBox;
    }
}