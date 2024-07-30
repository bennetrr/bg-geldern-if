namespace Funktionsrechner
{
    partial class FunktionsrechnerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kgVButton = new System.Windows.Forms.Button();
            this.primButton = new System.Windows.Forms.Button();
            this.x_hoch_yButton = new System.Windows.Forms.Button();
            this.ggTButton = new System.Windows.Forms.Button();
            this.fakButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ergebnisLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kgVButton);
            this.groupBox1.Controls.Add(this.primButton);
            this.groupBox1.Controls.Add(this.x_hoch_yButton);
            this.groupBox1.Controls.Add(this.ggTButton);
            this.groupBox1.Controls.Add(this.fakButton);
            this.groupBox1.Controls.Add(this.sqrtButton);
            this.groupBox1.Controls.Add(this.yTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.xTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // kgVButton
            // 
            this.kgVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgVButton.ForeColor = System.Drawing.Color.Red;
            this.kgVButton.Location = new System.Drawing.Point(98, 88);
            this.kgVButton.Name = "kgVButton";
            this.kgVButton.Size = new System.Drawing.Size(75, 24);
            this.kgVButton.TabIndex = 6;
            this.kgVButton.Text = "kgV(x, y)";
            this.kgVButton.Click += new System.EventHandler(this.kgVButton_Click);
            // 
            // primButton
            // 
            this.primButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primButton.ForeColor = System.Drawing.Color.Red;
            this.primButton.Location = new System.Drawing.Point(98, 122);
            this.primButton.Name = "primButton";
            this.primButton.Size = new System.Drawing.Size(75, 24);
            this.primButton.TabIndex = 8;
            this.primButton.Text = "Prim(x)";
            this.primButton.Click += new System.EventHandler(this.primButton_Click);
            // 
            // x_hoch_yButton
            // 
            this.x_hoch_yButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_hoch_yButton.ForeColor = System.Drawing.Color.Red;
            this.x_hoch_yButton.Location = new System.Drawing.Point(98, 54);
            this.x_hoch_yButton.Name = "x_hoch_yButton";
            this.x_hoch_yButton.Size = new System.Drawing.Size(75, 24);
            this.x_hoch_yButton.TabIndex = 4;
            this.x_hoch_yButton.Text = "x^y";
            this.x_hoch_yButton.Click += new System.EventHandler(this.x_hoch_yButton_Click);
            // 
            // ggTButton
            // 
            this.ggTButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggTButton.ForeColor = System.Drawing.Color.Red;
            this.ggTButton.Location = new System.Drawing.Point(13, 88);
            this.ggTButton.Name = "ggTButton";
            this.ggTButton.Size = new System.Drawing.Size(75, 24);
            this.ggTButton.TabIndex = 5;
            this.ggTButton.Text = "ggT(x, y)";
            this.ggTButton.Click += new System.EventHandler(this.ggTButton_Click);
            // 
            // fakButton
            // 
            this.fakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fakButton.ForeColor = System.Drawing.Color.Red;
            this.fakButton.Location = new System.Drawing.Point(13, 122);
            this.fakButton.Name = "fakButton";
            this.fakButton.Size = new System.Drawing.Size(75, 24);
            this.fakButton.TabIndex = 7;
            this.fakButton.Text = "x!";
            this.fakButton.Click += new System.EventHandler(this.fakButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.ForeColor = System.Drawing.Color.Red;
            this.sqrtButton.Location = new System.Drawing.Point(13, 54);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(75, 24);
            this.sqrtButton.TabIndex = 3;
            this.sqrtButton.Text = "Sqrt(x)";
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(112, 24);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(61, 20);
            this.yTextBox.TabIndex = 2;
            this.yTextBox.Text = "1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(98, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(27, 24);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(61, 20);
            this.xTextBox.TabIndex = 1;
            this.xTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ergebnisLabel);
            this.groupBox2.Location = new System.Drawing.Point(10, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 48);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // ergebnisLabel
            // 
            this.ergebnisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ergebnisLabel.Location = new System.Drawing.Point(11, 14);
            this.ergebnisLabel.Name = "ergebnisLabel";
            this.ergebnisLabel.Size = new System.Drawing.Size(162, 20);
            this.ergebnisLabel.TabIndex = 11;
            this.ergebnisLabel.Text = "1";
            this.ergebnisLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FunktionsrechnerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(209, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FunktionsrechnerForm";
            this.Text = "Funktionsrechner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kgVButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ergebnisLabel;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Button primButton;
        private System.Windows.Forms.Button ggTButton;
        private System.Windows.Forms.Button fakButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button x_hoch_yButton;
    }
}

