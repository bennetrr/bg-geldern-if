using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace persoenlichesNotizbuch_V0
{
    public partial class NotizbuchForm : Form
    {
        private Notizbuch meinNotizbuch = new Notizbuch();

        public NotizbuchForm()
        {
            InitializeComponent();
            meinNotizbuch.AusDateiLesen();
            GuiAktualisieren();
        }
        
		void NeuButtonKeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) Neu(); }

		private void neuButton_Click(object sender, EventArgs e) { Neu(); }
        
        private void Neu()
        {
            NeuForm neuForm = new NeuForm(meinNotizbuch);
            neuForm.ShowDialog();
            GuiAktualisieren();        
        }

		void BearbeitenButtonKeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) Bearbeiten(); }

		private void bearbeitenButton_Click(object sender, EventArgs e) { Bearbeiten(); }

		private void NotizListBoxDoubleClick(object sender, EventArgs e) { Bearbeiten(); }        

		void NotizListBoxKeyDown(object sender, KeyEventArgs e) { if ((notizListBox.SelectedIndex > -1)&&(e.KeyCode == Keys.Enter)) Bearbeiten(); }
		
		private void Bearbeiten()
		{
		    BearbeitenForm korrekturForm = new BearbeitenForm(meinNotizbuch, notizListBox.SelectedIndex);
            korrekturForm.ShowDialog();
            bearbeitenButton.Enabled = false;
            GuiAktualisieren();
		}

        private void notizListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bearbeitenButton.Enabled = loeschenButton.Enabled = (notizListBox.SelectedIndex > -1);
        }

		void LoeschenButtonKeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) Loeschen(); }

		private void loeschenButton_Click(object sender, EventArgs e) { Loeschen(); }

		private void Loeschen()
        {
            switch (MessageBox.Show("Möchten Sie die ausgewählte Notiz löschen?",
                    "persoenlichesNotizbuch", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    meinNotizbuch.LoescheNotiz(notizListBox.SelectedIndex);
                    bearbeitenButton.Enabled = false;
                    GuiAktualisieren();
                    break;
                default:
                    break;
            }
        }			
		
		void AlleLoeschenButtonKeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) AlleLoeschen(); }

		private void alleLoeschenButton_Click(object sender, EventArgs e) { AlleLoeschen(); }
        
		private void AlleLoeschen()
		{
            switch (MessageBox.Show("Möchten Sie alle Notizen löschen?",
             "persoenlichesNotizbuch", MessageBoxButtons.YesNo,
             MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    meinNotizbuch.LoescheAlleNotizen();
                    bearbeitenButton.Enabled = false;
                    GuiAktualisieren();
                    break;
            }
        }

		void SuchenButtonKeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) Suchen(); }

		private void suchenButton_Click(object sender, EventArgs e) { Suchen(); }
        
		private void Suchen()
		{
            SuchenForm suchenForm = new SuchenForm(meinNotizbuch);
            suchenForm.ShowDialog();
        }

        private void NotizListBoxFuellen()
        {
            notizListBox.Items.Clear();
            for (int index = 0; index < meinNotizbuch.AnzahlNotizen(); index++)
            {
                notizListBox.Items.Add(meinNotizbuch.ZeigeNotiz(index));
            }
        }

        private void GuiAktualisieren()
        {
            NotizListBoxFuellen();
            loeschenButton.Enabled = false;
            if (meinNotizbuch.AnzahlNotizen() == 0)
            {
                alleLoeschenButton.Enabled = suchenButton.Enabled = false;
            }
            else
            {
                alleLoeschenButton.Enabled = suchenButton.Enabled = true;
            }
        }

        private void NotizbuchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            meinNotizbuch.InDateiSpeichern();
        }
    }
}