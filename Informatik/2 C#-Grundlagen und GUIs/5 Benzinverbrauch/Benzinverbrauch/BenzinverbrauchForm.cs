using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Benzinverbrauch
{
    public partial class BenzinverbrauchForm : Form
    {
        public BenzinverbrauchForm()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            double strecke, benzin;

            try
            {
                strecke = Convert.ToDouble(streckeTextBox.Text);
                benzin = Convert.ToDouble(mengeTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Einer der eingegebenen Werte ist keine Zahl!", "Benzinverbrauchsrechner");
                return;
            }

            double verbrauch = benzin / (strecke / 100);

            verbrauchLabel.Text = "Benzinverbrauch: " + verbrauch.ToString("0.000") + "l/100km";
        }
    }
}