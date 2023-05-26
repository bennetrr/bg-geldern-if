using System;
using System.Windows.Forms;

namespace HeizungsProjekt
{
    public partial class HeizungForm : Form
    {
        private Heizung _heizung;
        public HeizungForm()
        {
            InitializeComponent();
            _heizung = new Heizung();
            RenderDisplay();
        }

        private void RenderDisplay()
        {
            labelTemp.Text = _heizung.Temperatur.ToString("0") + " °C";
            textSchrittweite.Text = _heizung.Schrittweite.ToString("0");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _heizung.Kaelter();
            RenderDisplay();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _heizung.Waermer();
            RenderDisplay();
        }

        private void textSchrittweite_TextChanged(object sender, EventArgs e)
        {
            if (textSchrittweite.Text == "" || textSchrittweite.Text == "-") return;
            try
            {
                _heizung.Schrittweite = Convert.ToInt32(textSchrittweite.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Die eingegebene Schrittweite ist keine Zahl", "Heizung: Fehler");
            }
            
        }
    }
}