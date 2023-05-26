using System;
using System.Windows.Forms;

namespace Debugging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variablendeklaration
            double tempCelsius, tempFahrenheit, tempKelvin;

            // Lese: Temperatur in °Celsius
            var benutzereingabe = textBox2.Text;
            if (benutzereingabe == "" || benutzereingabe == "-") return;

            try
            {
                tempCelsius = Convert.ToDouble(benutzereingabe);
            }
            catch (FormatException)
            {
                MessageBox.Show("Der eingegebene Wert ist keine Zahl", "Temperaturumrechner");
                return;
            }

            /* Umrechnung der in der Einheit °Celsius eingelesenen Temperatur
             * in die Temperatureinheitensysteme "°Fahrenheit" und "Kelvin".
             */
            tempFahrenheit = 1.8 * tempCelsius + 32;
            tempKelvin = tempCelsius + 273.15;

            // Ausgabe: Temperatur in °Fahrenheit und Kelvin
            label3.Text = "= " + tempFahrenheit.ToString("0.00") + " °F" + " = " + tempKelvin.ToString("0.00") + " K";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}