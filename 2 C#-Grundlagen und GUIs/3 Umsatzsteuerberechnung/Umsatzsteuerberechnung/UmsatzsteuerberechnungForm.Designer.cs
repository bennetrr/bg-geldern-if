namespace Umsatzsteuerberechnung
{
    partial class UmsatzsteuerberechnungForm
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
            this.rechnungsbetragTextBox = new System.Windows.Forms.TextBox();
            this.umsatzsteuersatzTextBox = new System.Windows.Forms.TextBox();
            this.nettobetragLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.berechnenButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.umsatzsteuerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rechnungsbetragTextBox
            // 
            this.rechnungsbetragTextBox.Location = new System.Drawing.Point(138, 19);
            this.rechnungsbetragTextBox.Name = "rechnungsbetragTextBox";
            this.rechnungsbetragTextBox.Size = new System.Drawing.Size(82, 20);
            this.rechnungsbetragTextBox.TabIndex = 0;
            this.rechnungsbetragTextBox.Text = "0";
            // 
            // umsatzsteuersatzTextBox
            // 
            this.umsatzsteuersatzTextBox.Location = new System.Drawing.Point(138, 52);
            this.umsatzsteuersatzTextBox.Name = "umsatzsteuersatzTextBox";
            this.umsatzsteuersatzTextBox.Size = new System.Drawing.Size(82, 20);
            this.umsatzsteuersatzTextBox.TabIndex = 1;
            this.umsatzsteuersatzTextBox.Text = "19";
            // 
            // nettobetragLabel
            // 
            this.nettobetragLabel.Location = new System.Drawing.Point(17, 22);
            this.nettobetragLabel.Name = "nettobetragLabel";
            this.nettobetragLabel.Size = new System.Drawing.Size(203, 20);
            this.nettobetragLabel.TabIndex = 3;
            this.nettobetragLabel.Text = "Nettobetrag";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rechnungsbetrag in €";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Umsatzsteuersatz in %";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.berechnenButton);
            this.groupBox1.Controls.Add(this.umsatzsteuersatzTextBox);
            this.groupBox1.Controls.Add(this.rechnungsbetragTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // berechnenButton
            // 
            this.berechnenButton.Location = new System.Drawing.Point(138, 85);
            this.berechnenButton.Name = "berechnenButton";
            this.berechnenButton.Size = new System.Drawing.Size(82, 23);
            this.berechnenButton.TabIndex = 10;
            this.berechnenButton.Text = "Berechnen";
            this.berechnenButton.Click += new System.EventHandler(this.berechnenButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.umsatzsteuerLabel);
            this.groupBox2.Controls.Add(this.nettobetragLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 84);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // umsatzsteuerLabel
            // 
            this.umsatzsteuerLabel.Location = new System.Drawing.Point(17, 51);
            this.umsatzsteuerLabel.Name = "umsatzsteuerLabel";
            this.umsatzsteuerLabel.Size = new System.Drawing.Size(203, 20);
            this.umsatzsteuerLabel.TabIndex = 4;
            this.umsatzsteuerLabel.Text = "Umsatzsteuer";
            // 
            // UmsatzsteuerberechnungForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(260, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UmsatzsteuerberechnungForm";
            this.Text = "Umsatzsteuerberechnung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button berechnenButton;
        private System.Windows.Forms.Label nettobetragLabel;
        private System.Windows.Forms.TextBox rechnungsbetragTextBox;
        private System.Windows.Forms.TextBox umsatzsteuersatzTextBox;
        private System.Windows.Forms.Label umsatzsteuerLabel;
    }
}