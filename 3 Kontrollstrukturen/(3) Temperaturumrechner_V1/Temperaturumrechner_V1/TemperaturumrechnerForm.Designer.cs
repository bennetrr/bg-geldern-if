namespace Temperaturumrechner_V1
{
    partial class TemperaturumrechnerForm
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
            this.wertTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gesuchteEinheitComboBox = new System.Windows.Forms.ComboBox();
            this.beendenButton = new System.Windows.Forms.Button();
            this.gesuchterWertLabel = new System.Windows.Forms.Label();
            this.einheitComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperaturwert";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wertTextBox
            // 
            this.wertTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wertTextBox.Location = new System.Drawing.Point(119, 20);
            this.wertTextBox.Name = "wertTextBox";
            this.wertTextBox.Size = new System.Drawing.Size(72, 20);
            this.wertTextBox.TabIndex = 1;
            this.wertTextBox.Text = "0";
            this.wertTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.wertTextBox_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gesuchteEinheitComboBox);
            this.groupBox1.Controls.Add(this.beendenButton);
            this.groupBox1.Controls.Add(this.gesuchterWertLabel);
            this.groupBox1.Controls.Add(this.einheitComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.wertTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gesuchteEinheitComboBox
            // 
            this.gesuchteEinheitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gesuchteEinheitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesuchteEinheitComboBox.Items.AddRange(new object[] {
            "°C",
            "°F",
            "K"});
            this.gesuchteEinheitComboBox.Location = new System.Drawing.Point(207, 60);
            this.gesuchteEinheitComboBox.Name = "gesuchteEinheitComboBox";
            this.gesuchteEinheitComboBox.Size = new System.Drawing.Size(72, 21);
            this.gesuchteEinheitComboBox.Sorted = true;
            this.gesuchteEinheitComboBox.TabIndex = 4;
            this.gesuchteEinheitComboBox.SelectedIndexChanged += new System.EventHandler(this.gesuchteEinheitComboBox_SelectedIndexChanged);
            // 
            // beendenButton
            // 
            this.beendenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenButton.Location = new System.Drawing.Point(207, 123);
            this.beendenButton.Name = "beendenButton";
            this.beendenButton.Size = new System.Drawing.Size(72, 23);
            this.beendenButton.TabIndex = 5;
            this.beendenButton.Text = "Beenden";
            this.beendenButton.Click += new System.EventHandler(this.beendenButton_Click);
            // 
            // gesuchterWertLabel
            // 
            this.gesuchterWertLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gesuchterWertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesuchterWertLabel.Location = new System.Drawing.Point(119, 60);
            this.gesuchterWertLabel.Name = "gesuchterWertLabel";
            this.gesuchterWertLabel.Size = new System.Drawing.Size(72, 20);
            this.gesuchterWertLabel.TabIndex = 3;
            this.gesuchterWertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // einheitComboBox
            // 
            this.einheitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.einheitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einheitComboBox.Items.AddRange(new object[] {
            "°C",
            "°F",
            "K"});
            this.einheitComboBox.Location = new System.Drawing.Point(207, 20);
            this.einheitComboBox.Name = "einheitComboBox";
            this.einheitComboBox.Size = new System.Drawing.Size(72, 21);
            this.einheitComboBox.Sorted = true;
            this.einheitComboBox.TabIndex = 2;
            this.einheitComboBox.SelectedIndexChanged += new System.EventHandler(this.einheitComboBox_SelectedIndexChanged);
            // 
            // TemperaturumrechnerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(315, 180);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TemperaturumrechnerForm";
            this.Text = "Temperaturumrechner";
            this.Load += new System.EventHandler(this.TemperaturumrechnerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox wertTextBox;
        private System.Windows.Forms.Label gesuchterWertLabel;
        private System.Windows.Forms.ComboBox einheitComboBox;
        private System.Windows.Forms.ComboBox gesuchteEinheitComboBox;
        private System.Windows.Forms.Button beendenButton;
    }
}

