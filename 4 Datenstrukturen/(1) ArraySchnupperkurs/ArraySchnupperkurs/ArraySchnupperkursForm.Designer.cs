namespace ArraySchnupperkurs
{
    partial class ArraySchnupperkursForm
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
            this.erzeugenButton = new System.Windows.Forms.Button();
            this.sortierenButton = new System.Windows.Forms.Button();
            this.suchenButton = new System.Windows.Forms.Button();
            this.zahlenListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anzahlNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxButton = new System.Windows.Forms.Button();
            this.summeButton = new System.Windows.Forms.Button();
            this.mittelwertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sortierreihenfolgeCheckBox = new System.Windows.Forms.CheckBox();
            this.suchenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anzahlNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suchenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // erzeugenButton
            // 
            this.erzeugenButton.Location = new System.Drawing.Point(216, 24);
            this.erzeugenButton.Name = "erzeugenButton";
            this.erzeugenButton.Size = new System.Drawing.Size(160, 23);
            this.erzeugenButton.TabIndex = 0;
            this.erzeugenButton.Text = "Erzeuge 100 Zahlen";
            this.erzeugenButton.Click += new System.EventHandler(this.erzeugenButton_Click);
            // 
            // sortierenButton
            // 
            this.sortierenButton.Enabled = false;
            this.sortierenButton.Location = new System.Drawing.Point(216, 296);
            this.sortierenButton.Name = "sortierenButton";
            this.sortierenButton.Size = new System.Drawing.Size(160, 23);
            this.sortierenButton.TabIndex = 2;
            this.sortierenButton.Text = "Zahlen sortieren";
            this.sortierenButton.Click += new System.EventHandler(this.sortierenButton_Click);
            // 
            // suchenButton
            // 
            this.suchenButton.Enabled = false;
            this.suchenButton.Location = new System.Drawing.Point(216, 264);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(160, 23);
            this.suchenButton.TabIndex = 3;
            this.suchenButton.Text = "Suche die Zahl 10";
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // zahlenListBox
            // 
            this.zahlenListBox.ColumnWidth = 50;
            this.zahlenListBox.Location = new System.Drawing.Point(16, 23);
            this.zahlenListBox.MultiColumn = true;
            this.zahlenListBox.Name = "zahlenListBox";
            this.zahlenListBox.Size = new System.Drawing.Size(360, 134);
            this.zahlenListBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anzahlNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.erzeugenButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zufallszahlen erzeugen";
            // 
            // anzahlNumericUpDown
            // 
            this.anzahlNumericUpDown.Location = new System.Drawing.Point(104, 25);
            this.anzahlNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.anzahlNumericUpDown.Name = "anzahlNumericUpDown";
            this.anzahlNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.anzahlNumericUpDown.TabIndex = 8;
            this.anzahlNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.anzahlNumericUpDown.ValueChanged += new System.EventHandler(this.anzahlNumericUpDown_ValueChanged);
            this.anzahlNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anzahlNumericUpDown_KeyUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl Zahlen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxButton);
            this.groupBox2.Controls.Add(this.summeButton);
            this.groupBox2.Controls.Add(this.mittelwertButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sortierreihenfolgeCheckBox);
            this.groupBox2.Controls.Add(this.suchenNumericUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.zahlenListBox);
            this.groupBox2.Controls.Add(this.sortierenButton);
            this.groupBox2.Controls.Add(this.suchenButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 328);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zufallszahlen bearbeiten";
            // 
            // maxButton
            // 
            this.maxButton.Enabled = false;
            this.maxButton.Location = new System.Drawing.Point(216, 232);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(160, 23);
            this.maxButton.TabIndex = 15;
            this.maxButton.Text = "Größte Zahl";
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // summeButton
            // 
            this.summeButton.Enabled = false;
            this.summeButton.Location = new System.Drawing.Point(216, 168);
            this.summeButton.Name = "summeButton";
            this.summeButton.Size = new System.Drawing.Size(160, 23);
            this.summeButton.TabIndex = 14;
            this.summeButton.Text = "Summe der Zahlen";
            this.summeButton.Click += new System.EventHandler(this.summeButton_Click);
            // 
            // mittelwertButton
            // 
            this.mittelwertButton.Enabled = false;
            this.mittelwertButton.Location = new System.Drawing.Point(216, 200);
            this.mittelwertButton.Name = "mittelwertButton";
            this.mittelwertButton.Size = new System.Drawing.Size(160, 23);
            this.mittelwertButton.TabIndex = 13;
            this.mittelwertButton.Text = "Mittelwert der Zahlen";
            this.mittelwertButton.Click += new System.EventHandler(this.mittelwertButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aufsteigend sortieren";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sortierreihenfolgeCheckBox
            // 
            this.sortierreihenfolgeCheckBox.Checked = true;
            this.sortierreihenfolgeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortierreihenfolgeCheckBox.Enabled = false;
            this.sortierreihenfolgeCheckBox.Location = new System.Drawing.Point(162, 296);
            this.sortierreihenfolgeCheckBox.Name = "sortierreihenfolgeCheckBox";
            this.sortierreihenfolgeCheckBox.Size = new System.Drawing.Size(16, 23);
            this.sortierreihenfolgeCheckBox.TabIndex = 10;
            this.sortierreihenfolgeCheckBox.Text = "checkBox1";
            this.sortierreihenfolgeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // suchenNumericUpDown
            // 
            this.suchenNumericUpDown.Enabled = false;
            this.suchenNumericUpDown.Location = new System.Drawing.Point(104, 265);
            this.suchenNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.suchenNumericUpDown.Name = "suchenNumericUpDown";
            this.suchenNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.suchenNumericUpDown.TabIndex = 9;
            this.suchenNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.suchenNumericUpDown.ValueChanged += new System.EventHandler(this.suchenNumericUpDown_ValueChanged);
            this.suchenNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.suchenNumericUpDown_KeyUp);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suche die Zahl";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(408, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ArraySchnupperkurs";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anzahlNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suchenNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button erzeugenButton;
        private System.Windows.Forms.Button sortierenButton;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.NumericUpDown anzahlNumericUpDown;
        private System.Windows.Forms.NumericUpDown suchenNumericUpDown;
        private System.Windows.Forms.ListBox zahlenListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sortierreihenfolgeCheckBox;
        private System.Windows.Forms.Button mittelwertButton;
        private System.Windows.Forms.Button summeButton;
        private System.Windows.Forms.Button maxButton;
    }
}

