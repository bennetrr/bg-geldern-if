namespace Kapitalrechner
{
    partial class KapitalrechnerForm
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
            this.kapitalTextBox = new System.Windows.Forms.TextBox();
            this.zinssatzTextBox = new System.Windows.Forms.TextBox();
            this.laufzeitTextBox = new System.Windows.Forms.TextBox();
            this.kapitalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.berechnenButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zeitLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kapitalTextBox
            // 
            this.kapitalTextBox.Location = new System.Drawing.Point(117, 22);
            this.kapitalTextBox.Name = "kapitalTextBox";
            this.kapitalTextBox.Size = new System.Drawing.Size(88, 20);
            this.kapitalTextBox.TabIndex = 0;
            this.kapitalTextBox.Text = "100";
            // 
            // zinssatzTextBox
            // 
            this.zinssatzTextBox.Location = new System.Drawing.Point(117, 55);
            this.zinssatzTextBox.Name = "zinssatzTextBox";
            this.zinssatzTextBox.Size = new System.Drawing.Size(88, 20);
            this.zinssatzTextBox.TabIndex = 1;
            this.zinssatzTextBox.Text = "1";
            // 
            // laufzeitTextBox
            // 
            this.laufzeitTextBox.Location = new System.Drawing.Point(117, 88);
            this.laufzeitTextBox.Name = "laufzeitTextBox";
            this.laufzeitTextBox.Size = new System.Drawing.Size(88, 20);
            this.laufzeitTextBox.TabIndex = 2;
            this.laufzeitTextBox.Text = "1";
            // 
            // kapitalLabel
            // 
            this.kapitalLabel.Location = new System.Drawing.Point(13, 24);
            this.kapitalLabel.Name = "kapitalLabel";
            this.kapitalLabel.Size = new System.Drawing.Size(192, 16);
            this.kapitalLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kapital in €";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zinssatz in %";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Laufzeit in Jahren";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.berechnenButton);
            this.groupBox1.Controls.Add(this.laufzeitTextBox);
            this.groupBox1.Controls.Add(this.zinssatzTextBox);
            this.groupBox1.Controls.Add(this.kapitalTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // berechnenButton
            // 
            this.berechnenButton.Location = new System.Drawing.Point(117, 121);
            this.berechnenButton.Name = "berechnenButton";
            this.berechnenButton.Size = new System.Drawing.Size(88, 23);
            this.berechnenButton.TabIndex = 10;
            this.berechnenButton.Text = "Berechnen";
            this.berechnenButton.Click += new System.EventHandler(this.berechnenButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zeitLabel);
            this.groupBox2.Controls.Add(this.kapitalLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // zeitLabel
            // 
            this.zeitLabel.Location = new System.Drawing.Point(13, 48);
            this.zeitLabel.Name = "zeitLabel";
            this.zeitLabel.Size = new System.Drawing.Size(192, 16);
            this.zeitLabel.TabIndex = 4;
            // 
            // KapitalrechnerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(242, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KapitalrechnerForm";
            this.Text = "Kapitalrechner";
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
        private System.Windows.Forms.Label kapitalLabel;
        private System.Windows.Forms.Label zeitLabel;
        private System.Windows.Forms.TextBox kapitalTextBox;
        private System.Windows.Forms.TextBox zinssatzTextBox;
        private System.Windows.Forms.TextBox laufzeitTextBox;
    }
}