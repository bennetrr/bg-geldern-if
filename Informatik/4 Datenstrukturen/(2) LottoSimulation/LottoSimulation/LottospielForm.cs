using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LottoSimulation
{
    public partial class LottospielForm : Form
    {
        private Lottospiel lottospiel = new Lottospiel();

        public LottospielForm()
        {
            InitializeComponent();
        }

        private void abonnementStartButton_Click(object sender, EventArgs e)
        {
            GuiAktivieren(false);
        }

        private void spielenBis6richtigeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            anzahlSpieleTextBox.Enabled = !anzahlSpieleTextBox.Enabled;
        }

        private void abonnementStartButton_EnabledChanged(object sender, EventArgs e)
        {
            long anzahlSpiele;
            if (!abonnementStartButton.Enabled)
            {
                byte[] tipp = new byte[6];
                long[] spielstatistik;

                // Lese: Tippschein
                string[] tippAlsString = tippTextBox.Text.Split('.');
                for (int i = 0; i < 6; i++)
                {
                    tipp[i] = Convert.ToByte(tippAlsString[i]);
                }

                // Abonnement starten
                if (spielenBis6richtigeCheckBox.Checked)
                {
                    spielstatistik = lottospiel.StarteAbonnement(tipp);
                }
                else
                {
                    anzahlSpiele = Convert.ToInt64(anzahlSpieleTextBox.Text.Replace(".",""));
                    spielstatistik = lottospiel.StarteAbonnement(tipp, anzahlSpiele);
                }

                // Ausgabe der Spielstatistik
                anzahlSpiele = 0;
                for (int i = 0; i < 7; i++)
                {
                    ergebnisListBox.Items.Add("Spiele mit " + i.ToString() + " richtigen: " + spielstatistik[i].ToString("#,##0"));
                    anzahlSpiele = anzahlSpiele + spielstatistik[i];
                }
                anzahlSpieleTextBox.Text = anzahlSpiele.ToString("#,##0");
                GuiAktivieren(true);
            }
        }

        private void GuiAktivieren(bool aktivieren)
        {
            if (!aktivieren)
            {
                ergebnisListBox.Items.Clear();
                anzahlSpieleTextBox.Enabled = false;
            }
            else
            {
                anzahlSpieleTextBox.Enabled = !spielenBis6richtigeCheckBox.Checked;
            }
            tippTextBox.Enabled = aktivieren;
            spielenBis6richtigeCheckBox.Enabled = aktivieren;
            abonnementStartButton.Enabled = aktivieren;
        }
    }
}