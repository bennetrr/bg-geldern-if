using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SchuelerverwaltungProjekt
{
    public partial class SchuelerverwaltungForm : Form
    {
        private Schuelerverwaltung schuelerverwaltung;

        public SchuelerverwaltungForm()
        {
            InitializeComponent();
            schuelerverwaltung = new Schuelerverwaltung();
        }

        private void anmeldenButton_Click(object sender, EventArgs e)
        {
            schuelerverwaltung.SchuelerAnmelden(vornameTextBox.Text,
                                                nameTextBox.Text,
                                                geburtsdatumTextBox.Text);
            vornameTextBox.Clear();
            nameTextBox.Clear();
            geburtsdatumTextBox.Clear();
            schuelerListBoxAktualisieren();
            anmeldenButtonAktivierungsstatusAktualisieren();
            suchenButton.Enabled = schuelerverwaltung.AnzahlSchueler() > 0;
        }

        private void korrigierenButton_Click(object sender, EventArgs e)
        {
            KorrekturForm korrekturForm = new KorrekturForm(schuelerverwaltung, schuelerListBox.SelectedIndex);
            korrekturForm.ShowDialog();
            schuelerListBoxAktualisieren();
            korrigierenButton.Enabled = false;
            loeschenButton.Enabled = false;
        }

        private void loeschenButton_Click(object sender, EventArgs e)
        {
            schuelerverwaltung.SchuelerLoeschen(schuelerListBox.SelectedIndex);
            schuelerListBoxAktualisieren();
            korrigierenButton.Enabled = false;
            loeschenButton.Enabled = false;
            suchenButton.Enabled = schuelerverwaltung.AnzahlSchueler() > 0;
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            SuchenForm suchenForm = new SuchenForm(schuelerverwaltung);
            suchenForm.ShowDialog();
            schuelerListBoxAktualisieren();
        }

        private void schuelerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (schuelerListBox.SelectedIndex > -1)
            {
                korrigierenButton.Enabled = true;
                loeschenButton.Enabled = true;
            }
        }

        private void vornameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            anmeldenButtonAktivierungsstatusAktualisieren();
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            anmeldenButtonAktivierungsstatusAktualisieren();
        }

        private void geburtsdatumTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            anmeldenButtonAktivierungsstatusAktualisieren();
        }

        private void schuelerListBoxAktualisieren()
        {
            schuelerListBox.Items.Clear();
            for (int i = 0; i < schuelerverwaltung.AnzahlSchueler(); i++)
            {
                schuelerListBox.Items.Add(schuelerverwaltung.SchuelerName(i) + ", " +
                                          schuelerverwaltung.SchuelerVorname(i) + " (" +
                                          schuelerverwaltung.SchuelerGeburtsdatum(i) + ")");
            }            
        }

        private void anmeldenButtonAktivierungsstatusAktualisieren()
        {
            if ((vornameTextBox.Text != "") && (nameTextBox.Text != "") && (geburtsdatumTextBox.Text != ""))
            {
                anmeldenButton.Enabled = true;
            }
            else
            {
                anmeldenButton.Enabled = false;
            }
        }

        private void SchuelerverwaltungForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                anmeldenButton_Click(sender, e);
            }
        }

        private void geburtsdatumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                anmeldenButton_Click(sender, e);
            }
        }
    }
}
