namespace persoenlichesNotizbuch_V0
{
    partial class BearbeitenForm
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.notizTextBox = new System.Windows.Forms.TextBox();
        	this.speichernButton = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(16, 24);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(31, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Notiz";
        	// 
        	// notizTextBox
        	// 
        	this.notizTextBox.Location = new System.Drawing.Point(94, 21);
        	this.notizTextBox.Name = "notizTextBox";
        	this.notizTextBox.Size = new System.Drawing.Size(208, 20);
        	this.notizTextBox.TabIndex = 0;
        	this.notizTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotizTextBoxKeyDown);
        	// 
        	// speichernButton
        	// 
        	this.speichernButton.Enabled = false;
        	this.speichernButton.Location = new System.Drawing.Point(222, 57);
        	this.speichernButton.Name = "speichernButton";
        	this.speichernButton.Size = new System.Drawing.Size(80, 23);
        	this.speichernButton.TabIndex = 1;
        	this.speichernButton.Text = "Speichern";
        	this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
        	this.speichernButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpeichernButtonKeyDown);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.speichernButton);
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.notizTextBox);
        	this.groupBox1.Location = new System.Drawing.Point(12, 14);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(319, 97);
        	this.groupBox1.TabIndex = 5;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Bearbeiten";
        	// 
        	// BearbeitenForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(342, 124);
        	this.Controls.Add(this.groupBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.MaximizeBox = false;
        	this.Name = "BearbeitenForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        	this.Text = "persoenlichesNotizbuch";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notizTextBox;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}