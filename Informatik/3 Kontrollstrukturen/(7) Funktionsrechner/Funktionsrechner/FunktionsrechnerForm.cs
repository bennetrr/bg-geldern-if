using System;
using System.Windows.Forms;

namespace Funktionsrechner
{
    public partial class FunktionsrechnerForm : Form
    {
        public FunktionsrechnerForm()
        {
            InitializeComponent();
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double x;
            if (X_to_Double(out x)) ergebnisLabel.Text = "Sqrt(" + xTextBox.Text + ") = " + MathExt.Wurzel(x);
        }

        private void x_hoch_yButton_Click(object sender, EventArgs e)
        {
            double x;
            int y;
            if (X_to_Double(out x) && Y_to_Int(out y))
                ergebnisLabel.Text =
                    xTextBox.Text + "^" + yTextBox.Text + " = " + MathExt.Potenz(x, y); // Oder: Math.Pow(x, y)
        }

        private void ggTButton_Click(object sender, EventArgs e)
        {
            ulong x, y;
            if (X_to_uLong(out x) && Y_to_uLong(out y))
                try
                {
                    ergebnisLabel.Text = "ggT(" + xTextBox.Text + ", " + yTextBox.Text + ") = " + MathExt.GgT(x, y);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("x und y müssen größer als 0 und nicht gleich sein!", "Funktionsrechner");
                }
        }

        private void kgVButton_Click(object sender, EventArgs e)
        {
            ulong x, y;
            if (X_to_uLong(out x) && Y_to_uLong(out y))
                ergebnisLabel.Text = "kgV(" + xTextBox.Text + ", " + yTextBox.Text + ") = " + MathExt.KgV(x, y);
        }


        private void fakButton_Click(object sender, EventArgs e)
        {
            ulong x;
            if (X_to_uLong(out x)) ergebnisLabel.Text = xTextBox.Text + "! = " + MathExt.Fak(x);
        }

        private void primButton_Click(object sender, EventArgs e)
        {
            ulong x;
            if (X_to_uLong(out x)) ergebnisLabel.Text = "Prim(" + xTextBox.Text + ") = " + MathExt.Prim(x);
        }

        private bool X_to_Double(out double x)
        {
            try
            {
                x = Convert.ToDouble(xTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("x-Wert", ausnahme);
                x = 0;
                return false;
            }
        }

        private bool X_to_Long(out long x)
        {
            try
            {
                x = Convert.ToInt64(xTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("x-Wert", ausnahme);
                x = 0;
                return false;
            }
        }

        private bool X_to_uLong(out ulong x)
        {
            try
            {
                x = Convert.ToUInt64(xTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("x-Wert", ausnahme);
                x = 0;
                return false;
            }
        }

        private bool Y_to_Double(out double y)
        {
            try
            {
                y = Convert.ToDouble(yTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("y-Wert", ausnahme);
                y = 0;
                return false;
            }
        }

        private bool Y_to_Int(out int y)
        {
            try
            {
                y = Convert.ToInt32(yTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("y-Wert", ausnahme);
                y = 0;
                return false;
            }
        }

        private bool Y_to_Long(out long y)
        {
            try
            {
                y = Convert.ToInt64(yTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("y-Wert", ausnahme);
                y = 0;
                return false;
            }
        }

        private bool Y_to_uLong(out ulong y)
        {
            try
            {
                y = Convert.ToUInt64(yTextBox.Text);
                return true;
            }
            catch (Exception ausnahme)
            {
                Fehlermeldung("y-Wert", ausnahme);
                y = 0;
                return false;
            }
        }

        private void Fehlermeldung(string info, Exception ausnahme)
        {
            MessageBox.Show(info + ": " + ausnahme.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}