namespace Digitaluhr_V2
{
    partial class WeckStoppUhrForm
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
	        this.components = new System.ComponentModel.Container();
	        this.taktgeberTimer = new System.Windows.Forms.Timer(this.components);
	        this.stoppuhrStartenUndStoppenButton = new System.Windows.Forms.Button();
	        this.resetStoppuhrButton = new System.Windows.Forms.Button();
	        this.groupBox3 = new System.Windows.Forms.GroupBox();
	        this.wecksekundeNumericUpDown = new System.Windows.Forms.NumericUpDown();
	        this.weckminuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
	        this.weckstundeNumericUpDown = new System.Windows.Forms.NumericUpDown();
	        this.weckerEinschaltenCheckBox = new System.Windows.Forms.CheckBox();
	        this.groupBox4 = new System.Windows.Forms.GroupBox();
	        this.sekundeNumericUpDown = new System.Windows.Forms.NumericUpDown();
	        this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
	        this.stundeNumericUpDown = new System.Windows.Forms.NumericUpDown();
	        this.einstellungenGroupBox = new System.Windows.Forms.GroupBox();
	        this.einstellungenCheckBox = new System.Windows.Forms.CheckBox();
	        this.schlummernButton = new System.Windows.Forms.Button();
	        this.uhrzeitLabel = new System.Windows.Forms.Label();
	        this.groupBox7 = new System.Windows.Forms.GroupBox();
	        this.weckerGroupBox = new System.Windows.Forms.GroupBox();
	        this.alarmAusButton = new System.Windows.Forms.Button();
	        this.weckzeitLabel = new System.Windows.Forms.Label();
	        this.groupBox1 = new System.Windows.Forms.GroupBox();
	        this.stoppuhrLabel = new System.Windows.Forms.Label();
	        this.groupBox3.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.wecksekundeNumericUpDown)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize) (this.weckminuteNumericUpDown)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize) (this.weckstundeNumericUpDown)).BeginInit();
	        this.groupBox4.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.sekundeNumericUpDown)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize) (this.minuteNumericUpDown)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize) (this.stundeNumericUpDown)).BeginInit();
	        this.einstellungenGroupBox.SuspendLayout();
	        this.groupBox7.SuspendLayout();
	        this.weckerGroupBox.SuspendLayout();
	        this.groupBox1.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // taktgeberTimer
	        // 
	        this.taktgeberTimer.Enabled = true;
	        this.taktgeberTimer.Interval = 1000;
	        this.taktgeberTimer.Tick += new System.EventHandler(this.taktgeberTimer_Tick);
	        // 
	        // stoppuhrStartenUndStoppenButton
	        // 
	        this.stoppuhrStartenUndStoppenButton.Location = new System.Drawing.Point(14, 17);
	        this.stoppuhrStartenUndStoppenButton.Name = "stoppuhrStartenUndStoppenButton";
	        this.stoppuhrStartenUndStoppenButton.Size = new System.Drawing.Size(75, 23);
	        this.stoppuhrStartenUndStoppenButton.TabIndex = 7;
	        this.stoppuhrStartenUndStoppenButton.Text = "Start";
	        this.stoppuhrStartenUndStoppenButton.UseVisualStyleBackColor = true;
	        this.stoppuhrStartenUndStoppenButton.Click += new System.EventHandler(this.stoppuhrStartenUndStoppenButton_Click);
	        // 
	        // resetStoppuhrButton
	        // 
	        this.resetStoppuhrButton.Location = new System.Drawing.Point(98, 17);
	        this.resetStoppuhrButton.Name = "resetStoppuhrButton";
	        this.resetStoppuhrButton.Size = new System.Drawing.Size(75, 23);
	        this.resetStoppuhrButton.TabIndex = 9;
	        this.resetStoppuhrButton.Text = "Reset";
	        this.resetStoppuhrButton.UseVisualStyleBackColor = true;
	        this.resetStoppuhrButton.Click += new System.EventHandler(this.resetStoppuhrButton_Click);
	        // 
	        // groupBox3
	        // 
	        this.groupBox3.Controls.Add(this.wecksekundeNumericUpDown);
	        this.groupBox3.Controls.Add(this.weckminuteNumericUpDown);
	        this.groupBox3.Controls.Add(this.weckstundeNumericUpDown);
	        this.groupBox3.Controls.Add(this.weckerEinschaltenCheckBox);
	        this.groupBox3.Location = new System.Drawing.Point(278, 17);
	        this.groupBox3.Name = "groupBox3";
	        this.groupBox3.Size = new System.Drawing.Size(257, 50);
	        this.groupBox3.TabIndex = 11;
	        this.groupBox3.TabStop = false;
	        this.groupBox3.Text = "Wecker";
	        // 
	        // wecksekundeNumericUpDown
	        // 
	        this.wecksekundeNumericUpDown.Location = new System.Drawing.Point(92, 17);
	        this.wecksekundeNumericUpDown.Maximum = new decimal(new int[] {59, 0, 0, 0});
	        this.wecksekundeNumericUpDown.Name = "wecksekundeNumericUpDown";
	        this.wecksekundeNumericUpDown.Size = new System.Drawing.Size(35, 20);
	        this.wecksekundeNumericUpDown.TabIndex = 10;
	        this.wecksekundeNumericUpDown.ValueChanged += new System.EventHandler(this.wecksekundeNumericUpDown_ValueChanged);
	        // 
	        // weckminuteNumericUpDown
	        // 
	        this.weckminuteNumericUpDown.Location = new System.Drawing.Point(55, 17);
	        this.weckminuteNumericUpDown.Maximum = new decimal(new int[] {59, 0, 0, 0});
	        this.weckminuteNumericUpDown.Name = "weckminuteNumericUpDown";
	        this.weckminuteNumericUpDown.Size = new System.Drawing.Size(35, 20);
	        this.weckminuteNumericUpDown.TabIndex = 9;
	        this.weckminuteNumericUpDown.ValueChanged += new System.EventHandler(this.weckminuteNnumericUpDown_ValueChanged);
	        // 
	        // weckstundeNumericUpDown
	        // 
	        this.weckstundeNumericUpDown.Location = new System.Drawing.Point(18, 17);
	        this.weckstundeNumericUpDown.Maximum = new decimal(new int[] {23, 0, 0, 0});
	        this.weckstundeNumericUpDown.Name = "weckstundeNumericUpDown";
	        this.weckstundeNumericUpDown.Size = new System.Drawing.Size(35, 20);
	        this.weckstundeNumericUpDown.TabIndex = 8;
	        this.weckstundeNumericUpDown.ValueChanged += new System.EventHandler(this.weckstundeNumericUpDown_ValueChanged);
	        // 
	        // weckerEinschaltenCheckBox
	        // 
	        this.weckerEinschaltenCheckBox.AutoSize = true;
	        this.weckerEinschaltenCheckBox.Location = new System.Drawing.Point(141, 19);
	        this.weckerEinschaltenCheckBox.Name = "weckerEinschaltenCheckBox";
	        this.weckerEinschaltenCheckBox.Size = new System.Drawing.Size(90, 17);
	        this.weckerEinschaltenCheckBox.TabIndex = 7;
	        this.weckerEinschaltenCheckBox.Text = "Eingeschaltet";
	        this.weckerEinschaltenCheckBox.UseVisualStyleBackColor = true;
	        this.weckerEinschaltenCheckBox.CheckedChanged += new System.EventHandler(this.weckerEinschaltenCheckBox_CheckedChanged);
	        // 
	        // groupBox4
	        // 
	        this.groupBox4.Controls.Add(this.sekundeNumericUpDown);
	        this.groupBox4.Controls.Add(this.minuteNumericUpDown);
	        this.groupBox4.Controls.Add(this.stundeNumericUpDown);
	        this.groupBox4.Location = new System.Drawing.Point(14, 17);
	        this.groupBox4.Name = "groupBox4";
	        this.groupBox4.Size = new System.Drawing.Size(258, 50);
	        this.groupBox4.TabIndex = 12;
	        this.groupBox4.TabStop = false;
	        this.groupBox4.Text = "Uhr";
	        // 
	        // sekundeNumericUpDown
	        // 
	        this.sekundeNumericUpDown.Location = new System.Drawing.Point(90, 17);
	        this.sekundeNumericUpDown.Maximum = new decimal(new int[] {59, 0, 0, 0});
	        this.sekundeNumericUpDown.Name = "sekundeNumericUpDown";
	        this.sekundeNumericUpDown.Size = new System.Drawing.Size(35, 20);
	        this.sekundeNumericUpDown.TabIndex = 2;
	        this.sekundeNumericUpDown.ValueChanged += new System.EventHandler(this.sekundeNumericUpDown_ValueChanged);
	        // 
	        // minuteNumericUpDown
	        // 
	        this.minuteNumericUpDown.Location = new System.Drawing.Point(53, 17);
	        this.minuteNumericUpDown.Maximum = new decimal(new int[] {59, 0, 0, 0});
	        this.minuteNumericUpDown.Name = "minuteNumericUpDown";
	        this.minuteNumericUpDown.Size = new System.Drawing.Size(35, 20);
	        this.minuteNumericUpDown.TabIndex = 1;
	        this.minuteNumericUpDown.ValueChanged += new System.EventHandler(this.minuteNumericUpDown_ValueChanged);
	        // 
	        // stundeNumericUpDown
	        // 
	        this.stundeNumericUpDown.Location = new System.Drawing.Point(16, 17);
	        this.stundeNumericUpDown.Maximum = new decimal(new int[] {23, 0, 0, 0});
	        this.stundeNumericUpDown.Name = "stundeNumericUpDown";
	        this.stundeNumericUpDown.Size = new System.Drawing.Size(35, 20);
	        this.stundeNumericUpDown.TabIndex = 0;
	        this.stundeNumericUpDown.ValueChanged += new System.EventHandler(this.stundeNumericUpDown_ValueChanged);
	        // 
	        // einstellungenGroupBox
	        // 
	        this.einstellungenGroupBox.Controls.Add(this.groupBox4);
	        this.einstellungenGroupBox.Controls.Add(this.groupBox3);
	        this.einstellungenGroupBox.Location = new System.Drawing.Point(13, 207);
	        this.einstellungenGroupBox.Name = "einstellungenGroupBox";
	        this.einstellungenGroupBox.Size = new System.Drawing.Size(550, 81);
	        this.einstellungenGroupBox.TabIndex = 13;
	        this.einstellungenGroupBox.TabStop = false;
	        this.einstellungenGroupBox.Text = "Einstellungen";
	        // 
	        // einstellungenCheckBox
	        // 
	        this.einstellungenCheckBox.AutoSize = true;
	        this.einstellungenCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
	        this.einstellungenCheckBox.Checked = true;
	        this.einstellungenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.einstellungenCheckBox.Location = new System.Drawing.Point(474, 294);
	        this.einstellungenCheckBox.Name = "einstellungenCheckBox";
	        this.einstellungenCheckBox.Size = new System.Drawing.Size(89, 17);
	        this.einstellungenCheckBox.TabIndex = 0;
	        this.einstellungenCheckBox.Text = "Einstellungen";
	        this.einstellungenCheckBox.UseVisualStyleBackColor = true;
	        this.einstellungenCheckBox.CheckedChanged += new System.EventHandler(this.einstellungenCheckBox_CheckedChanged);
	        // 
	        // schlummernButton
	        // 
	        this.schlummernButton.Location = new System.Drawing.Point(98, 17);
	        this.schlummernButton.Name = "schlummernButton";
	        this.schlummernButton.Size = new System.Drawing.Size(75, 23);
	        this.schlummernButton.TabIndex = 15;
	        this.schlummernButton.Text = "Schlummern";
	        this.schlummernButton.UseVisualStyleBackColor = true;
	        this.schlummernButton.Click += new System.EventHandler(this.schlummernButton_Click);
	        // 
	        // uhrzeitLabel
	        // 
	        this.uhrzeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
	        this.uhrzeitLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
	        this.uhrzeitLabel.Location = new System.Drawing.Point(19, 16);
	        this.uhrzeitLabel.Name = "uhrzeitLabel";
	        this.uhrzeitLabel.Size = new System.Drawing.Size(512, 108);
	        this.uhrzeitLabel.TabIndex = 16;
	        this.uhrzeitLabel.Text = "00: 00 : 00";
	        this.uhrzeitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	        // 
	        // groupBox7
	        // 
	        this.groupBox7.Controls.Add(this.uhrzeitLabel);
	        this.groupBox7.Location = new System.Drawing.Point(13, 12);
	        this.groupBox7.Name = "groupBox7";
	        this.groupBox7.Size = new System.Drawing.Size(550, 133);
	        this.groupBox7.TabIndex = 22;
	        this.groupBox7.TabStop = false;
	        this.groupBox7.Text = "Uhr";
	        // 
	        // weckerGroupBox
	        // 
	        this.weckerGroupBox.Controls.Add(this.alarmAusButton);
	        this.weckerGroupBox.Controls.Add(this.schlummernButton);
	        this.weckerGroupBox.Controls.Add(this.weckzeitLabel);
	        this.weckerGroupBox.Location = new System.Drawing.Point(291, 151);
	        this.weckerGroupBox.Name = "weckerGroupBox";
	        this.weckerGroupBox.Size = new System.Drawing.Size(272, 50);
	        this.weckerGroupBox.TabIndex = 21;
	        this.weckerGroupBox.TabStop = false;
	        this.weckerGroupBox.Text = "Wecker";
	        // 
	        // alarmAusButton
	        // 
	        this.alarmAusButton.Location = new System.Drawing.Point(14, 17);
	        this.alarmAusButton.Name = "alarmAusButton";
	        this.alarmAusButton.Size = new System.Drawing.Size(75, 23);
	        this.alarmAusButton.TabIndex = 18;
	        this.alarmAusButton.Text = "Alarm aus";
	        this.alarmAusButton.UseVisualStyleBackColor = true;
	        this.alarmAusButton.Click += new System.EventHandler(this.AlarmAusButtonClick);
	        // 
	        // weckzeitLabel
	        // 
	        this.weckzeitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	        this.weckzeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
	        this.weckzeitLabel.Location = new System.Drawing.Point(182, 17);
	        this.weckzeitLabel.Name = "weckzeitLabel";
	        this.weckzeitLabel.Size = new System.Drawing.Size(75, 23);
	        this.weckzeitLabel.TabIndex = 19;
	        this.weckzeitLabel.Text = "00: 00 : 00";
	        this.weckzeitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	        // 
	        // groupBox1
	        // 
	        this.groupBox1.Controls.Add(this.stoppuhrStartenUndStoppenButton);
	        this.groupBox1.Controls.Add(this.resetStoppuhrButton);
	        this.groupBox1.Controls.Add(this.stoppuhrLabel);
	        this.groupBox1.Location = new System.Drawing.Point(13, 151);
	        this.groupBox1.Name = "groupBox1";
	        this.groupBox1.Size = new System.Drawing.Size(272, 50);
	        this.groupBox1.TabIndex = 20;
	        this.groupBox1.TabStop = false;
	        this.groupBox1.Text = "Stoppuhr";
	        // 
	        // stoppuhrLabel
	        // 
	        this.stoppuhrLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	        this.stoppuhrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
	        this.stoppuhrLabel.Location = new System.Drawing.Point(182, 17);
	        this.stoppuhrLabel.Name = "stoppuhrLabel";
	        this.stoppuhrLabel.Size = new System.Drawing.Size(75, 23);
	        this.stoppuhrLabel.TabIndex = 17;
	        this.stoppuhrLabel.Text = "00: 00 : 00";
	        this.stoppuhrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	        // 
	        // WeckStoppUhrForm
	        // 
	        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
	        this.ClientSize = new System.Drawing.Size(582, 335);
	        this.Controls.Add(this.einstellungenCheckBox);
	        this.Controls.Add(this.groupBox7);
	        this.Controls.Add(this.weckerGroupBox);
	        this.Controls.Add(this.einstellungenGroupBox);
	        this.Controls.Add(this.groupBox1);
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
	        this.MaximizeBox = false;
	        this.MinimizeBox = false;
	        this.Name = "WeckStoppUhrForm";
	        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	        this.Text = "Digitaluhr";
	        this.TopMost = true;
	        this.groupBox3.ResumeLayout(false);
	        this.groupBox3.PerformLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.wecksekundeNumericUpDown)).EndInit();
	        ((System.ComponentModel.ISupportInitialize) (this.weckminuteNumericUpDown)).EndInit();
	        ((System.ComponentModel.ISupportInitialize) (this.weckstundeNumericUpDown)).EndInit();
	        this.groupBox4.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize) (this.sekundeNumericUpDown)).EndInit();
	        ((System.ComponentModel.ISupportInitialize) (this.minuteNumericUpDown)).EndInit();
	        ((System.ComponentModel.ISupportInitialize) (this.stundeNumericUpDown)).EndInit();
	        this.einstellungenGroupBox.ResumeLayout(false);
	        this.groupBox7.ResumeLayout(false);
	        this.weckerGroupBox.ResumeLayout(false);
	        this.groupBox1.ResumeLayout(false);
	        this.ResumeLayout(false);
	        this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer taktgeberTimer;
        private System.Windows.Forms.Button stoppuhrStartenUndStoppenButton;
        private System.Windows.Forms.Button resetStoppuhrButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox weckerEinschaltenCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox einstellungenGroupBox;
        private System.Windows.Forms.CheckBox einstellungenCheckBox;
        private System.Windows.Forms.Button schlummernButton;
        private System.Windows.Forms.NumericUpDown sekundeNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown stundeNumericUpDown;
        private System.Windows.Forms.NumericUpDown wecksekundeNumericUpDown;
        private System.Windows.Forms.NumericUpDown weckminuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown weckstundeNumericUpDown;
        private System.Windows.Forms.Label uhrzeitLabel;
        private System.Windows.Forms.Label stoppuhrLabel;
        private System.Windows.Forms.Label weckzeitLabel;
        private System.Windows.Forms.Button alarmAusButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox weckerGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

