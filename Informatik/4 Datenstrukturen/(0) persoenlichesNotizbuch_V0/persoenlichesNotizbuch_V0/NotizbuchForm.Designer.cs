namespace persoenlichesNotizbuch_V0
{
    partial class NotizbuchForm
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
	        this.neuButton = new System.Windows.Forms.Button();
	        this.groupBox2 = new System.Windows.Forms.GroupBox();
	        this.bearbeitenButton = new System.Windows.Forms.Button();
	        this.suchenButton = new System.Windows.Forms.Button();
	        this.notizListBox = new System.Windows.Forms.ListBox();
	        this.alleLoeschenButton = new System.Windows.Forms.Button();
	        this.loeschenButton = new System.Windows.Forms.Button();
	        this.groupBox2.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // neuButton
	        // 
	        this.neuButton.Location = new System.Drawing.Point(384, 32);
	        this.neuButton.Name = "neuButton";
	        this.neuButton.Size = new System.Drawing.Size(128, 34);
	        this.neuButton.TabIndex = 0;
	        this.neuButton.Text = "Neu";
	        this.neuButton.Click += new System.EventHandler(this.neuButton_Click);
	        this.neuButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NeuButtonKeyDown);
	        // 
	        // groupBox2
	        // 
	        this.groupBox2.Controls.Add(this.bearbeitenButton);
	        this.groupBox2.Controls.Add(this.suchenButton);
	        this.groupBox2.Controls.Add(this.neuButton);
	        this.groupBox2.Controls.Add(this.notizListBox);
	        this.groupBox2.Controls.Add(this.alleLoeschenButton);
	        this.groupBox2.Controls.Add(this.loeschenButton);
	        this.groupBox2.Location = new System.Drawing.Point(21, 18);
	        this.groupBox2.Name = "groupBox2";
	        this.groupBox2.Size = new System.Drawing.Size(537, 254);
	        this.groupBox2.TabIndex = 12;
	        this.groupBox2.TabStop = false;
	        this.groupBox2.Text = "Notizen";
	        // 
	        // bearbeitenButton
	        // 
	        this.bearbeitenButton.Enabled = false;
	        this.bearbeitenButton.Location = new System.Drawing.Point(384, 72);
	        this.bearbeitenButton.Name = "bearbeitenButton";
	        this.bearbeitenButton.Size = new System.Drawing.Size(128, 33);
	        this.bearbeitenButton.TabIndex = 1;
	        this.bearbeitenButton.Text = "Bearbeiten";
	        this.bearbeitenButton.Click += new System.EventHandler(this.bearbeitenButton_Click);
	        this.bearbeitenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BearbeitenButtonKeyDown);
	        // 
	        // suchenButton
	        // 
	        this.suchenButton.Enabled = false;
	        this.suchenButton.Location = new System.Drawing.Point(384, 190);
	        this.suchenButton.Name = "suchenButton";
	        this.suchenButton.Size = new System.Drawing.Size(128, 34);
	        this.suchenButton.TabIndex = 4;
	        this.suchenButton.Text = "Suchen";
	        this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
	        this.suchenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuchenButtonKeyDown);
	        // 
	        // notizListBox
	        // 
	        this.notizListBox.ItemHeight = 20;
	        this.notizListBox.Location = new System.Drawing.Point(26, 32);
	        this.notizListBox.Name = "notizListBox";
	        this.notizListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
	        this.notizListBox.ScrollAlwaysVisible = true;
	        this.notizListBox.Size = new System.Drawing.Size(332, 164);
	        this.notizListBox.TabIndex = 5;
	        this.notizListBox.SelectedIndexChanged += new System.EventHandler(this.notizListBox_SelectedIndexChanged);
	        this.notizListBox.DoubleClick += new System.EventHandler(this.NotizListBoxDoubleClick);
	        this.notizListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotizListBoxKeyDown);
	        // 
	        // alleLoeschenButton
	        // 
	        this.alleLoeschenButton.Enabled = false;
	        this.alleLoeschenButton.Location = new System.Drawing.Point(384, 151);
	        this.alleLoeschenButton.Name = "alleLoeschenButton";
	        this.alleLoeschenButton.Size = new System.Drawing.Size(128, 33);
	        this.alleLoeschenButton.TabIndex = 3;
	        this.alleLoeschenButton.Text = "Alle löschen";
	        this.alleLoeschenButton.Click += new System.EventHandler(this.alleLoeschenButton_Click);
	        this.alleLoeschenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlleLoeschenButtonKeyDown);
	        // 
	        // loeschenButton
	        // 
	        this.loeschenButton.Enabled = false;
	        this.loeschenButton.Location = new System.Drawing.Point(384, 111);
	        this.loeschenButton.Name = "loeschenButton";
	        this.loeschenButton.Size = new System.Drawing.Size(128, 34);
	        this.loeschenButton.TabIndex = 2;
	        this.loeschenButton.Text = "Löschen";
	        this.loeschenButton.Click += new System.EventHandler(this.loeschenButton_Click);
	        this.loeschenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoeschenButtonKeyDown);
	        // 
	        // NotizbuchForm
	        // 
	        this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
	        this.ClientSize = new System.Drawing.Size(564, 269);
	        this.Controls.Add(this.groupBox2);
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
	        this.MaximizeBox = false;
	        this.Name = "NotizbuchForm";
	        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
	        this.Text = "persoenlichesNotizbuch";
	        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NotizbuchForm_FormClosed);
	        this.groupBox2.ResumeLayout(false);
	        this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button neuButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox notizListBox;
        private System.Windows.Forms.Button alleLoeschenButton;
        private System.Windows.Forms.Button loeschenButton;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.Button bearbeitenButton;
    }
}