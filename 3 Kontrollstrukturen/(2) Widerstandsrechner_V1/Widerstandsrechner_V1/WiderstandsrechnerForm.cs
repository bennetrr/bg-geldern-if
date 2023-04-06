using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Widerstandsrechner_V1
{
    public partial class WiderstandsrechnerForm : Form
    {
        public WiderstandsrechnerForm()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            char einheit = '\u03A9';

            // Lese: Querschnitt, Länge, Material
            double querschnitt = Convert.ToDouble(querschnittTextBox.Text);
            double laenge = Convert.ToDouble(laengeTextBox.Text);
            string material = materialComboBox.Text;

            // Ausgabe: Widerstandswert
            widerstandswertLabel.Text = Elektrotechnik.Widerstand_V1(querschnitt, laenge, material).ToString("F2")+" "+einheit;
        }

        private void WiderstandsrechnerForm_Load(object sender, EventArgs e)
        {
            materialComboBox.SelectedIndex = 0;
        }
    }
}