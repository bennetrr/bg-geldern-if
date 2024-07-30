using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace persoenlichesNotizbuch_V0
{
    public partial class NeuForm : Form
    {
        private Notizbuch meinNotizbuch;

        public NeuForm()
        {
            InitializeComponent();
        }

        public NeuForm(Notizbuch meinNotizbuch)
        {
            InitializeComponent();
            this.meinNotizbuch = meinNotizbuch;
        }

        void NotizTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (notizTextBox.Text != "")
            {
            	speichernButton.Enabled = true;
            	if (e.KeyCode == Keys.Enter) SpeichereNotiz();
            }
            else
            {
            	speichernButton.Enabled = false;
            }
        }
        
        private void speichernButton_Click(object sender, EventArgs e)
        {
        	SpeichereNotiz();
        }        

		void SpeichernButtonKeyDown(object sender, KeyEventArgs e)
		{
			SpeichereNotiz();
		}
        
        private void SpeichereNotiz()
        {
            meinNotizbuch.SpeichereNotiz(notizTextBox.Text);
            this.Close();        
        }
    }
}