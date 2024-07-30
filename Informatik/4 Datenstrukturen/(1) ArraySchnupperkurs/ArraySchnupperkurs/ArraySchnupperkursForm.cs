using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArraySchnupperkurs
{
    public partial class ArraySchnupperkursForm : Form
    {
        private Zufallszahlen meineZufallszahlen;

        public ArraySchnupperkursForm()
        {
            InitializeComponent();
            meineZufallszahlen = new Zufallszahlen();
        }

        private void erzeugenButton_Click(object sender, EventArgs e)
        {
            if (meineZufallszahlen.Erzeugen((int)anzahlNumericUpDown.Value) != null)
            {
                // Zahlen erzeugen
                int[] zahlen = meineZufallszahlen.Erzeugen((int)anzahlNumericUpDown.Value);

                // Ausgabe des Ergebnisses
                zahlenListBox.Items.Clear();
                for (int i = 0; i < zahlen.Length; i++)
                {
                    zahlenListBox.Items.Add(zahlen[i]);
                }

                // BearbeitungsSteuerelemente aktivieren
                BearbeitungsSteuerelemente(true);
            }
            else
            {
                MessageBox.Show("Das Array zur Speicherung der Zufallszahlen wurde noch nicht erzeugt.", "ArraySchnupperkurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void summeButton_Click(object sender, EventArgs e)
        {
            // Summe der Zahlen ermitteln
            int summe = meineZufallszahlen.Summe();

            // Meldung des Ergebnisses
            string info = "Die Summe der Zahlen beträgt: " + summe.ToString();
            MessageBox.Show(info, "ArraySchnupperkurs", MessageBoxButtons.OK, MessageBoxIcon.Information);		
        }

        private void mittelwertButton_Click(object sender, EventArgs e)
        {
            // Mittelwert der Zahlen ermitteln
            double mittelwert = meineZufallszahlen.Mittelwert();

            // Meldung des Ergebnisses
            string info = "Der Mittelwert der Zahlen beträgt: " + mittelwert.ToString();
            MessageBox.Show(info, "ArraySchnupperkurs", MessageBoxButtons.OK, MessageBoxIcon.Information);		
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            // Größte Zahl ermitteln
            int max = meineZufallszahlen.Max();

            // Meldung des Ergebnisses
            string info = "Die größte Zahl ist: " + max.ToString();
            MessageBox.Show(info, "ArraySchnupperkurs", MessageBoxButtons.OK, MessageBoxIcon.Information);		
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            // Zahl suchen
            bool gefunden = meineZufallszahlen.Suchen((int)suchenNumericUpDown.Value);

            // Meldung des Suchergebnisses
            string info = "Die Zahl " + suchenNumericUpDown.Value + " wurde ";
            if (gefunden)
            {
                info = info + "gefunden!";
            }
            else
            {
                info = info + "nicht gefunden!";
            }
            MessageBox.Show(info, "ArraySchnupperkurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sortierenButton_Click(object sender, EventArgs e)
        {
            // Zahlen sortieren
            int[] zahlen = meineZufallszahlen.Sortieren(sortierreihenfolgeCheckBox.Checked);

            // Ausgabe der sortierten Zahlen
            zahlenListBox.Items.Clear();
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlenListBox.Items.Add(zahlen[i]);
            }
        }

        private void anzahlNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            erzeugenButton.Text = "Erzeuge " + anzahlNumericUpDown.Value + " Zahlen";
        }

        private void anzahlNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            erzeugenButton.Text = "Erzeuge " + anzahlNumericUpDown.Value + " Zahlen";		
        }

        private void suchenNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            suchenButton.Text = "Suche die Zahl " + suchenNumericUpDown.Value;
        }

        private void suchenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            suchenButton.Text = "Suche die Zahl " + suchenNumericUpDown.Value;
        }

        private void BearbeitungsSteuerelemente(bool aktiviert)
        {
            suchenNumericUpDown.Enabled = aktiviert;
            summeButton.Enabled = aktiviert;
            mittelwertButton.Enabled = aktiviert;
            maxButton.Enabled = aktiviert;
            suchenButton.Enabled = aktiviert;
            sortierreihenfolgeCheckBox.Enabled = aktiviert;
            sortierenButton.Enabled = aktiviert;
        }
    }
}