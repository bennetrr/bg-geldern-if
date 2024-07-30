using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Widerstandsrechner_V0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            // Lese: Querschnitt, Länge, Materialkonstante
            double querschnitt = Convert.ToDouble(querschnittTextBox.Text);
            double laenge = Convert.ToDouble(laengeTextBox.Text);
            double materialkonstante = Convert.ToDouble(materialkonstanteTextBox.Text);

            // Ausgabe: Widerstandswert
            widerstandswertLabel.Text = Elektrotechnik.Widerstand_V0(querschnitt, laenge, materialkonstante).ToString("F2") + " Ohm";
        }
    }
}