using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Temperaturumrechner_V1
{
    public partial class TemperaturumrechnerForm : Form
    {
        public TemperaturumrechnerForm()
        {
            InitializeComponent();
        }

        private void beendenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TemperaturumrechnerForm_Load(object sender, EventArgs e)
        {
            einheitComboBox.SelectedIndex = 0;
            gesuchteEinheitComboBox.SelectedIndex = 1;
        }

        private void gesuchteEinheitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuiAktualisieren();
        }

        private void einheitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuiAktualisieren();
        }

        private void wertTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            GuiAktualisieren();
        }

        private void GuiAktualisieren()
        {
            try
            {
                // Lese: Temperaturwert, Temperatureinheit und gesuchte Temperatureinheit
                double wert = Convert.ToDouble(wertTextBox.Text);
                string einheit = einheitComboBox.Text;
                string gesuchteEinheit = gesuchteEinheitComboBox.Text;

                // Ausgabe: umgerechneter Temperaturwert
                gesuchterWertLabel.Text = " = " + Physik.Temperatur(wert, einheit, gesuchteEinheit).ToString("F2");
            }
            catch(Exception ausnahme)
            {
                gesuchterWertLabel.Text = "";
                if (wertTextBox.Text != "")
                {
                    MessageBox.Show(ausnahme.Message, "Fehler");
                    wertTextBox.Clear();
                }
            }
        }
    }
}