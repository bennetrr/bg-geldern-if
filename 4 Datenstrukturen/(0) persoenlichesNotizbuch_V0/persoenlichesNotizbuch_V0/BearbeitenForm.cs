using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace persoenlichesNotizbuch_V0
{
    public partial class BearbeitenForm : Form
    {
        private Notizbuch meinNotizbuch;
        private int index;

        public BearbeitenForm()
        {
            InitializeComponent();
        }

        public BearbeitenForm(Notizbuch meinNotizbuch, int index)
        {
            InitializeComponent();
            this.meinNotizbuch = meinNotizbuch;
            this.index = index;
            notizTextBox.Text = meinNotizbuch.ZeigeNotiz(index);
            speichernButton.Enabled = true;
        }

		void NotizTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (notizTextBox.Text != "") 
            {
            	if (e.KeyCode == Keys.Enter) ErsetzeNotiz();
            }           
            else
            {
            	speichernButton.Enabled = false;
            }
        }
        
        private void speichernButton_Click(object sender, EventArgs e)
        {
        	ErsetzeNotiz();
        }
        
		void SpeichernButtonKeyDown(object sender, KeyEventArgs e)
		{
			ErsetzeNotiz();
		}

        private void ErsetzeNotiz()
        {
            meinNotizbuch.ErsetzeNotiz(index, notizTextBox.Text);
            this.Close();        
        }		
    }
}