namespace Swap
{
    partial class SwapForm
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
            this.obereTextBox = new System.Windows.Forms.TextBox();
            this.untereTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.swapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // obereTextBox
            // 
            this.obereTextBox.Location = new System.Drawing.Point(72, 24);
            this.obereTextBox.Name = "obereTextBox";
            this.obereTextBox.Size = new System.Drawing.Size(88, 20);
            this.obereTextBox.TabIndex = 1;
            this.obereTextBox.Text = "47";
            // 
            // untereTextBox
            // 
            this.untereTextBox.Location = new System.Drawing.Point(72, 64);
            this.untereTextBox.Name = "untereTextBox";
            this.untereTextBox.Size = new System.Drawing.Size(88, 20);
            this.untereTextBox.TabIndex = 3;
            this.untereTextBox.Text = "11";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zahl 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(24, 104);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(136, 23);
            this.swapButton.TabIndex = 4;
            this.swapButton.Text = "Und los!";
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // SwapForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(184, 150);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.untereTextBox);
            this.Controls.Add(this.obereTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SwapForm";
            this.Text = "Swap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox obereTextBox;
        private System.Windows.Forms.TextBox untereTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button swapButton;
    }
}

