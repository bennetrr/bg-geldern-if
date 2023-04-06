using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Swap
{
    public partial class SwapForm : Form
    {
        public SwapForm()
        {
            InitializeComponent();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            var zahl1 = Convert.ToDouble(obereTextBox.Text);
            var zahl2 = Convert.ToDouble(untereTextBox.Text);

            zahl1 = zahl1 + zahl2;
            zahl2 = zahl1 - zahl2;
            zahl1 = zahl1 - zahl2;

            obereTextBox.Text = zahl1.ToString();
            untereTextBox.Text = zahl2.ToString();
        }
    }
}