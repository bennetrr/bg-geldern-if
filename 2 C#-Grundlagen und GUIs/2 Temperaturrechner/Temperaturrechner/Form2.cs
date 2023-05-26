using System;
using System.Windows.Forms;

namespace Temperaturrechner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            double inputTemp, outputTemp;

            // Get the values entered by the user

            if (textBox1.Text == "" || textBox1.Text == "-") return;
            
            try
            {
                inputTemp = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Der eingetragene Wert ist keine Zahl", "Temperaturumrechner");
                return;
            }

            var inputUnit = comboBox1.Text;
            var outputUnit = comboBox2.Text;
            
            // Calculate the result
            switch (inputUnit)
            {
                case "°C":
                    switch (outputUnit)
                    {
                        case "°C":
                            outputTemp = inputTemp;
                            break;
                        case "°F":
                            outputTemp = inputTemp * 1.8 + 32;
                            break;
                        case "K":
                            outputTemp = inputTemp + 273.15;
                            break;
                        default:
                            MessageBox.Show("Die angegebene Einheit wurde nicht erkannt!");
                            return;
                    }
                    break;
                
                case "°F":
                    switch (outputUnit)
                    {
                        case "°C":
                            outputTemp = (inputTemp - 32) * (5.0/9);
                            break;
                        case "°F":
                            outputTemp = inputTemp;
                            break;
                        case "K":
                            outputTemp = (inputTemp + 459.67) * (5.0/9);
                            break;
                        default:
                            MessageBox.Show("Die angegebene Einheit wurde nicht erkannt!");
                            return;
                    }
                    break;
                
                case "K":
                    switch (outputUnit)
                    {
                        case "°C":
                            outputTemp = inputTemp - 273.15;
                            break;
                        case "°F":
                            outputTemp = inputTemp * (9/5.0) - 459.67 ;
                            break;
                        case "K":
                            outputTemp = inputTemp;
                            break;
                        default:
                            MessageBox.Show("Die angegebene Einheit wurde nicht erkannt!");
                            return;
                    }
                    break;
                
                default:
                    MessageBox.Show("Die angegebene Einheit wurde nicht erkannt!");
                    return;
            }

            textBox2.Text = outputTemp.ToString("0.00");
        }
    }
}