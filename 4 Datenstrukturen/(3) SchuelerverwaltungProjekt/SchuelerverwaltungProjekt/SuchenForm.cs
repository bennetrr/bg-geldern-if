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
    public partial class SuchenForm : Form
    {
        private Schuelerverwaltung schuelerverwaltung;

        public SuchenForm(Schuelerverwaltung schuelerverwaltung)
        {
            InitializeComponent();
            this.schuelerverwaltung = schuelerverwaltung;
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            suchergebnisListBox.Items.Clear();
            List<Schueler> suchergebnis = schuelerverwaltung.SchuelerSuchen(suchenTextBox.Text);
            foreach (Schueler schueler in suchergebnis)
            {
                suchergebnisListBox.Items.Add(
                    schueler.Name + ", " + schueler.Vorname + " (" + schueler.Geburtsdatum + ")");
            }
        }

        private void suchenTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            suchenButton.Enabled = suchenTextBox.Text != "";
        }

        private void schliessenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suchenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                suchenButton_Click(sender, e);
            }
        }
    }
}
