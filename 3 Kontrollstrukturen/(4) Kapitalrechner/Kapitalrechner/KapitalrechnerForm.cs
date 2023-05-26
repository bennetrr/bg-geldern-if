using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kapitalrechner
{
    public partial class KapitalrechnerForm : Form
    {
        public KapitalrechnerForm()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            double kapital, zinssatz;
            int laufzeit;

            // Lese: Kapital, Zinssatz und Laufzeit
            kapital = Convert.ToDouble(kapitalTextBox.Text);
            zinssatz = Convert.ToDouble(zinssatzTextBox.Text);
            laufzeit = Convert.ToInt32(laufzeitTextBox.Text);

            // Ausgabe: Endkapital und Zeit bis zur Kapitalverdopplung
            kapitalLabel.Text = "Endkapital: "+Kapital.Endkapital(kapital, zinssatz, laufzeit).ToString("C");
            zeitLabel.Text = "Kapitalverdopplung nach: "+Kapital.LaufzeitBisKapitalverdopplung(kapital, zinssatz).ToString("F0")+" Jahren";
        }
    }
}