namespace persoenlichesNotizbuch_V0
{
    partial class SuchenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.suchenButton = new System.Windows.Forms.Button();
        	this.suchenTextBox = new System.Windows.Forms.TextBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.suchergebnisListBox = new System.Windows.Forms.ListBox();
        	this.schliessenButton = new System.Windows.Forms.Button();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// suchenButton
        	// 
        	this.suchenButton.Enabled = false;
        	this.suchenButton.Location = new System.Drawing.Point(222, 57);
        	this.suchenButton.Name = "suchenButton";
        	this.suchenButton.Size = new System.Drawing.Size(80, 23);
        	this.suchenButton.TabIndex = 1;
        	this.suchenButton.Text = "Suchen";
        	this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
        	// 
        	// suchenTextBox
        	// 
        	this.suchenTextBox.Location = new System.Drawing.Point(94, 21);
        	this.suchenTextBox.Name = "suchenTextBox";
        	this.suchenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.suchenTextBox.Size = new System.Drawing.Size(208, 20);
        	this.suchenTextBox.TabIndex = 0;
        	this.suchenTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuchenTextBoxKeyDown);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.suchenTextBox);
        	this.groupBox1.Controls.Add(this.suchenButton);
        	this.groupBox1.Location = new System.Drawing.Point(12, 14);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(319, 97);
        	this.groupBox1.TabIndex = 11;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Suchen";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(16, 24);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(61, 13);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Suchbegriff";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.suchergebnisListBox);
        	this.groupBox2.Controls.Add(this.schliessenButton);
        	this.groupBox2.Location = new System.Drawing.Point(12, 120);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(319, 215);
        	this.groupBox2.TabIndex = 12;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Suchergebnis";
        	// 
        	// suchergebnisListBox
        	// 
        	this.suchergebnisListBox.Location = new System.Drawing.Point(16, 22);
        	this.suchergebnisListBox.Name = "suchergebnisListBox";
        	this.suchergebnisListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
        	this.suchergebnisListBox.ScrollAlwaysVisible = true;
        	this.suchergebnisListBox.Size = new System.Drawing.Size(208, 134);
        	this.suchergebnisListBox.TabIndex = 16;
        	// 
        	// schliessenButton
        	// 
        	this.schliessenButton.Location = new System.Drawing.Point(222, 177);
        	this.schliessenButton.Name = "schliessenButton";
        	this.schliessenButton.Size = new System.Drawing.Size(80, 23);
        	this.schliessenButton.TabIndex = 2;
        	this.schliessenButton.Text = "Schließen";
        	this.schliessenButton.Click += new System.EventHandler(this.schliessenButton_Click);
        	this.schliessenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SchliessenButtonKeyDown);
        	// 
        	// SuchenForm
        	// 
        	this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        	this.ClientSize = new System.Drawing.Size(342, 346);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.MaximizeBox = false;
        	this.Name = "SuchenForm";
        	this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        	this.Text = "persoenlichesNotizbuch";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.TextBox suchenTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox suchergebnisListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schliessenButton;
    }
}