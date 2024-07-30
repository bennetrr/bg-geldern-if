using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Praemienrechner
{
    public partial class PraemienrechnerForm : Form
    {
        public PraemienrechnerForm()
        {
            InitializeComponent();
        }

        private void berechnenButton_Click(object sender, EventArgs e)
        {
            double versicherungssumme;

            // Lese: Versicherungssumme
            versicherungssumme = Convert.ToDouble(textBox1.Text);

            // Ausgabe: Prämie
            label2.Text = Versicherung.Praemie(versicherungssumme).ToString("C"); 
        }

        private void beendenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}