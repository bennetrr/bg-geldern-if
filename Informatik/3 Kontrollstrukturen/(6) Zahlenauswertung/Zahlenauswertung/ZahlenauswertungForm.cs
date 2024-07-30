using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zahlenauswertung
{
    public partial class ZahlenauswertungForm : Form
    {
        public ZahlenauswertungForm()
        {
            InitializeComponent();
        }

        private void berechneButton_Click(object sender, EventArgs e)
        {
            // Lese: Zahl1, Zahl2, Zahl3
            double zahl1 = Convert.ToDouble(zahl1TextBox.Text);
            double zahl2 = Convert.ToDouble(zahl2TextBox.Text);
            double zahl3 = Convert.ToDouble(zahl3TextBox.Text);

            // Berechnung des Mittelwertes und des Maximums
            double mittelwert = Statistik.Mittelwert(zahl1, zahl2, zahl3);
            double maximum = Statistik.Maximum();
            maximum = Statistik.Maximum();

            // Ausgabe: Mittelwert und Maximum
            mittelwertLabel.Text = "Mittelwert = "+mittelwert.ToString("F2");
            maximumLabel.Text = "Maximum = "+maximum.ToString();
        }
    }
}