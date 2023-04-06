namespace SchuelerverwaltungProjekt
{
    partial class SuchenForm
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
	        this.suchenButton = new System.Windows.Forms.Button();
	        this.suchenTextBox = new System.Windows.Forms.TextBox();
	        this.label1 = new System.Windows.Forms.Label();
	        this.groupBox2 = new System.Windows.Forms.GroupBox();
	        this.schliessenButton = new System.Windows.Forms.Button();
	        this.suchergebnisListBox = new System.Windows.Forms.ListBox();
	        this.groupBox1.SuspendLayout();
	        this.groupBox2.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // groupBox1
	        // 
	        this.groupBox1.Controls.Add(this.suchenButton);
	        this.groupBox1.Controls.Add(this.suchenTextBox);
	        this.groupBox1.Controls.Add(this.label1);
	        this.groupBox1.Location = new System.Drawing.Point(22, 15);
	        this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.groupBox1.Name = "groupBox1";
	        this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.groupBox1.Size = new System.Drawing.Size(454, 143);
	        this.groupBox1.TabIndex = 0;
	        this.groupBox1.TabStop = false;
	        this.groupBox1.Text = "Suchen";
	        // 
	        // suchenButton
	        // 
	        this.suchenButton.Enabled = false;
	        this.suchenButton.Location = new System.Drawing.Point(308, 72);
	        this.suchenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.suchenButton.Name = "suchenButton";
	        this.suchenButton.Size = new System.Drawing.Size(120, 35);
	        this.suchenButton.TabIndex = 4;
	        this.suchenButton.Text = "Suchen";
	        this.suchenButton.UseVisualStyleBackColor = true;
	        this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
	        // 
	        // suchenTextBox
	        // 
	        this.suchenTextBox.Location = new System.Drawing.Point(148, 32);
	        this.suchenTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.suchenTextBox.Name = "suchenTextBox";
	        this.suchenTextBox.Size = new System.Drawing.Size(277, 26);
	        this.suchenTextBox.TabIndex = 1;
	        this.suchenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.suchenTextBox_KeyPress);
	        this.suchenTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.suchenTextBox_KeyUp);
	        // 
	        // label1
	        // 
	        this.label1.AutoSize = true;
	        this.label1.Location = new System.Drawing.Point(26, 38);
	        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	        this.label1.Name = "label1";
	        this.label1.Size = new System.Drawing.Size(91, 20);
	        this.label1.TabIndex = 0;
	        this.label1.Text = "Suchbegriff";
	        // 
	        // groupBox2
	        // 
	        this.groupBox2.Controls.Add(this.schliessenButton);
	        this.groupBox2.Controls.Add(this.suchergebnisListBox);
	        this.groupBox2.Location = new System.Drawing.Point(24, 168);
	        this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.groupBox2.Name = "groupBox2";
	        this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.groupBox2.Size = new System.Drawing.Size(454, 235);
	        this.groupBox2.TabIndex = 1;
	        this.groupBox2.TabStop = false;
	        this.groupBox2.Text = "Schüler";
	        // 
	        // schliessenButton
	        // 
	        this.schliessenButton.Location = new System.Drawing.Point(308, 169);
	        this.schliessenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.schliessenButton.Name = "schliessenButton";
	        this.schliessenButton.Size = new System.Drawing.Size(120, 35);
	        this.schliessenButton.TabIndex = 7;
	        this.schliessenButton.Text = "Schließen";
	        this.schliessenButton.UseVisualStyleBackColor = true;
	        this.schliessenButton.Click += new System.EventHandler(this.schliessenButton_Click);
	        // 
	        // suchergebnisListBox
	        // 
	        this.suchergebnisListBox.FormattingEnabled = true;
	        this.suchergebnisListBox.ItemHeight = 20;
	        this.suchergebnisListBox.Location = new System.Drawing.Point(26, 32);
	        this.suchergebnisListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.suchergebnisListBox.Name = "suchergebnisListBox";
	        this.suchergebnisListBox.ScrollAlwaysVisible = true;
	        this.suchergebnisListBox.Size = new System.Drawing.Size(400, 104);
	        this.suchergebnisListBox.TabIndex = 5;
	        // 
	        // SuchenForm
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(496, 426);
	        this.Controls.Add(this.groupBox2);
	        this.Controls.Add(this.groupBox1);
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
	        this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
	        this.MaximizeBox = false;
	        this.Name = "SuchenForm";
	        this.Text = "Schuelerverwaltung";
	        this.groupBox1.ResumeLayout(false);
	        this.groupBox1.PerformLayout();
	        this.groupBox2.ResumeLayout(false);
	        this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.TextBox suchenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox suchergebnisListBox;
        private System.Windows.Forms.Button schliessenButton;
    }
}

