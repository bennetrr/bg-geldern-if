using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace persoenlichesNotizbuch_V0
{
    public partial class SuchenForm : Form
    {
        private Notizbuch meinNotizbuch = new Notizbuch();

        public SuchenForm()
        {
            InitializeComponent();
        }

        public SuchenForm(Notizbuch meinNotizbuch)
        {
            InitializeComponent();
            this.meinNotizbuch = meinNotizbuch;
        }

		void SuchenTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (suchenTextBox.Text != "")
            {
            	suchenButton.Enabled = true;
            	if (e.KeyCode == Keys.Enter) SucheNotizen();
            }
            else
            {
            	suchenButton.Enabled = false;
            }
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
        	SucheNotizen();
        }
        
        private void SucheNotizen()
        {
            suchergebnisListBox.Items.Clear();
            List<string> suchergebnis = meinNotizbuch.SucheNotizen(suchenTextBox.Text);
            foreach (string notiz in suchergebnis)
            {
                suchergebnisListBox.Items.Add(notiz);
            }        
        }

        private void schliessenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
		void SchliessenButtonKeyDown(object sender, KeyEventArgs e)
		{
			this.Close();
		}
    }
}