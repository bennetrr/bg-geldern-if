using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Umsatzsteuerberechnung
{
    public partial class UmsatzsteuerberechnungForm : Form
    {
        public UmsatzsteuerberechnungForm()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            double rechnungsbetrag, umsatzsteuerInProzent;
            // Lese: Rechnungsbetrag und Umsatzsteuersatz
            try
            {
                rechnungsbetrag = Convert.ToDouble(rechnungsbetragTextBox.Text);
                umsatzsteuerInProzent = Convert.ToDouble(umsatzsteuersatzTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ein eingegebener Wert ist keine Zahl!", "Umsatzsteuerberechnung");
                return;
            }

            // Berechnung des Nettobetrags
            var nettobetrag = rechnungsbetrag * 100 / (umsatzsteuerInProzent + 100);

            // Ausgabe: Nettobetrag
            nettobetragLabel.Text = "Nettobetrag:" + nettobetrag.ToString("C");
        }
    }
}
 