namespace SchuelerverwaltungProjekt
{
    partial class SchuelerverwaltungForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anmeldenButton = new System.Windows.Forms.Button();
            this.geburtsdatumTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suchenButton = new System.Windows.Forms.Button();
            this.loeschenButton = new System.Windows.Forms.Button();
            this.schuelerListBox = new System.Windows.Forms.ListBox();
            this.korrigierenButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anmeldenButton);
            this.groupBox1.Controls.Add(this.geburtsdatumTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.vornameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(454, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schüleranmeldung";
            // 
            // anmeldenButton
            // 
            this.anmeldenButton.Enabled = false;
            this.anmeldenButton.Location = new System.Drawing.Point(308, 180);
            this.anmeldenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anmeldenButton.Name = "anmeldenButton";
            this.anmeldenButton.Size = new System.Drawing.Size(120, 35);
            this.anmeldenButton.TabIndex = 4;
            this.anmeldenButton.Text = "Anmelden";
            this.anmeldenButton.UseVisualStyleBackColor = true;
            this.anmeldenButton.Click += new System.EventHandler(this.anmeldenButton_Click);
            // 
            // geburtsdatumTextBox
            // 
            this.geburtsdatumTextBox.Location = new System.Drawing.Point(148, 131);
            this.geburtsdatumTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.geburtsdatumTextBox.Name = "geburtsdatumTextBox";
            this.geburtsdatumTextBox.Size = new System.Drawing.Size(277, 26);
            this.geburtsdatumTextBox.TabIndex = 3;
            this.geburtsdatumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.geburtsdatumTextBox_KeyPress);
            this.geburtsdatumTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.geburtsdatumTextBox_KeyUp);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 82);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(277, 26);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyUp);
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Location = new System.Drawing.Point(148, 32);
            this.vornameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(277, 26);
            this.vornameTextBox.TabIndex = 1;
            this.vornameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vornameTextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geburtsdatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suchenButton);
            this.groupBox2.Controls.Add(this.loeschenButton);
            this.groupBox2.Controls.Add(this.schuelerListBox);
            this.groupBox2.Controls.Add(this.korrigierenButton);
            this.groupBox2.Location = new System.Drawing.Point(22, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(454, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schüler";
            // 
            // suchenButton
            // 
            this.suchenButton.Enabled = false;
            this.suchenButton.Location = new System.Drawing.Point(308, 169);
            this.suchenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(120, 35);
            this.suchenButton.TabIndex = 7;
            this.suchenButton.Text = "Suchen";
            this.suchenButton.UseVisualStyleBackColor = true;
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // loeschenButton
            // 
            this.loeschenButton.Enabled = false;
            this.loeschenButton.Location = new System.Drawing.Point(166, 169);
            this.loeschenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loeschenButton.Name = "loeschenButton";
            this.loeschenButton.Size = new System.Drawing.Size(120, 35);
            this.loeschenButton.TabIndex = 6;
            this.loeschenButton.Text = "Löschen";
            this.loeschenButton.UseVisualStyleBackColor = true;
            this.loeschenButton.Click += new System.EventHandler(this.loeschenButton_Click);
            // 
            // schuelerListBox
            // 
            this.schuelerListBox.FormattingEnabled = true;
            this.schuelerListBox.ItemHeight = 20;
            this.schuelerListBox.Location = new System.Drawing.Point(26, 32);
            this.schuelerListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schuelerListBox.Name = "schuelerListBox";
            this.schuelerListBox.ScrollAlwaysVisible = true;
            this.schuelerListBox.Size = new System.Drawing.Size(400, 104);
            this.schuelerListBox.TabIndex = 5;
            this.schuelerListBox.SelectedIndexChanged += new System.EventHandler(this.schuelerListBox_SelectedIndexChanged);
            // 
            // korrigierenButton
            // 
            this.korrigierenButton.Enabled = false;
            this.korrigierenButton.Location = new System.Drawing.Point(26, 169);
            this.korrigierenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.korrigierenButton.Name = "korrigierenButton";
            this.korrigierenButton.Size = new System.Drawing.Size(120, 35);
            this.korrigierenButton.TabIndex = 5;
            this.korrigierenButton.Text = "Korrigieren";
            this.korrigierenButton.UseVisualStyleBackColor = true;
            this.korrigierenButton.Click += new System.EventHandler(this.korrigierenButton_Click);
            // 
            // SchuelerverwaltungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SchuelerverwaltungForm";
            this.Text = "Schuelerverwaltung";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SchuelerverwaltungForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button anmeldenButton;
        private System.Windows.Forms.TextBox geburtsdatumTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button korrigierenButton;
        private System.Windows.Forms.ListBox schuelerListBox;
        private System.Windows.Forms.Button loeschenButton;
        private System.Windows.Forms.Button suchenButton;
    }
}

