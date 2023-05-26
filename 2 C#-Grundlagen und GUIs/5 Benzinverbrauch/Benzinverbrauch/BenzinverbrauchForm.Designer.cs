namespace Benzinverbrauch
{
    partial class BenzinverbrauchForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.streckeTextBox = new System.Windows.Forms.TextBox();
            this.mengeTextBox = new System.Windows.Forms.TextBox();
            this.verbrauchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.berechnenButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // streckeTextBox
            // 
            this.streckeTextBox.Location = new System.Drawing.Point(250, 35);
            this.streckeTextBox.Name = "streckeTextBox";
            this.streckeTextBox.Size = new System.Drawing.Size(129, 26);
            this.streckeTextBox.TabIndex = 0;
            this.streckeTextBox.Text = "100";
            // 
            // mengeTextBox
            // 
            this.mengeTextBox.Location = new System.Drawing.Point(250, 82);
            this.mengeTextBox.Name = "mengeTextBox";
            this.mengeTextBox.Size = new System.Drawing.Size(129, 26);
            this.mengeTextBox.TabIndex = 1;
            this.mengeTextBox.Text = "8";
            // 
            // verbrauchLabel
            // 
            this.verbrauchLabel.Location = new System.Drawing.Point(26, 35);
            this.verbrauchLabel.Name = "verbrauchLabel";
            this.verbrauchLabel.Size = new System.Drawing.Size(350, 23);
            this.verbrauchLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gefahrene Strecke in km";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Getankte Benzinmenge in l";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.berechnenButton);
            this.groupBox1.Controls.Add(this.mengeTextBox);
            this.groupBox1.Controls.Add(this.streckeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // berechnenButton
            // 
            this.berechnenButton.Location = new System.Drawing.Point(250, 129);
            this.berechnenButton.Name = "berechnenButton";
            this.berechnenButton.Size = new System.Drawing.Size(129, 33);
            this.berechnenButton.TabIndex = 10;
            this.berechnenButton.Text = "Berechnen";
            this.berechnenButton.Click += new System.EventHandler(this.berechnenButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.verbrauchLabel);
            this.groupBox2.Location = new System.Drawing.Point(18, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 82);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // BenzinverbrauchForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(437, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BenzinverbrauchForm";
            this.Text = "Benzinverbrauch";
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
        private System.Windows.Forms.TextBox streckeTextBox;
        private System.Windows.Forms.TextBox mengeTextBox;
        private System.Windows.Forms.Label verbrauchLabel;
        private System.Windows.Forms.Button berechnenButton;
    }
}

