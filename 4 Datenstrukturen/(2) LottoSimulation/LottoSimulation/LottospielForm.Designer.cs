namespace LottoSimulation
{
    partial class LottospielForm
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
            this.abonnementStartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anzahlSpieleTextBox = new System.Windows.Forms.TextBox();
            this.tippTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spielenBis6richtigeCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ergebnisListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // abonnementStartButton
            // 
            this.abonnementStartButton.Location = new System.Drawing.Point(15, 129);
            this.abonnementStartButton.Name = "abonnementStartButton";
            this.abonnementStartButton.Size = new System.Drawing.Size(187, 23);
            this.abonnementStartButton.TabIndex = 2;
            this.abonnementStartButton.Text = "Abonnement starten";
            this.abonnementStartButton.Click += new System.EventHandler(this.abonnementStartButton_Click);
            this.abonnementStartButton.EnabledChanged += new System.EventHandler(this.abonnementStartButton_EnabledChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anzahlSpieleTextBox);
            this.groupBox1.Controls.Add(this.tippTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.spielenBis6richtigeCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.abonnementStartButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lottoschein";
            // 
            // anzahlSpieleTextBox
            // 
            this.anzahlSpieleTextBox.Location = new System.Drawing.Point(101, 49);
            this.anzahlSpieleTextBox.Name = "anzahlSpieleTextBox";
            this.anzahlSpieleTextBox.Size = new System.Drawing.Size(101, 20);
            this.anzahlSpieleTextBox.TabIndex = 4;
            this.anzahlSpieleTextBox.Text = "1";
            // 
            // tippTextBox
            // 
            this.tippTextBox.Location = new System.Drawing.Point(101, 19);
            this.tippTextBox.Name = "tippTextBox";
            this.tippTextBox.Size = new System.Drawing.Size(101, 20);
            this.tippTextBox.TabIndex = 3;
            this.tippTextBox.Text = "11.22.33.44.48.49";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Spielen bis 6 richtige";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spielenBis6richtigeCheckBox
            // 
            this.spielenBis6richtigeCheckBox.AutoSize = true;
            this.spielenBis6richtigeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spielenBis6richtigeCheckBox.Location = new System.Drawing.Point(187, 82);
            this.spielenBis6richtigeCheckBox.Name = "spielenBis6richtigeCheckBox";
            this.spielenBis6richtigeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.spielenBis6richtigeCheckBox.TabIndex = 7;
            this.spielenBis6richtigeCheckBox.UseVisualStyleBackColor = true;
            this.spielenBis6richtigeCheckBox.CheckedChanged += new System.EventHandler(this.spielenBis6richtigeCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzahl Spiele";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ihr Tipp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ergebnisListBox);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 170);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // ergebnisListBox
            // 
            this.ergebnisListBox.Location = new System.Drawing.Point(15, 18);
            this.ergebnisListBox.Name = "ergebnisListBox";
            this.ergebnisListBox.Size = new System.Drawing.Size(187, 134);
            this.ergebnisListBox.TabIndex = 0;
            // 
            // LottoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 194);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LottoForm";
            this.Text = "LottoSimulation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abonnementStartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tippTextBox;
        private System.Windows.Forms.TextBox anzahlSpieleTextBox;
        private System.Windows.Forms.ListBox ergebnisListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox spielenBis6richtigeCheckBox;
        private System.Windows.Forms.Label label3;
    }
}

