using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchuelerverwaltungProjekt
{
    public partial class KorrekturForm : Form
    {
        private Schuelerverwaltung schuelerverwaltung;
        private int index;

        public KorrekturForm()
        {
            InitializeComponent();
        }

        public KorrekturForm(Schuelerverwaltung schuelerverwaltung, int index)
        {
            InitializeComponent();
            this.schuelerverwaltung = schuelerverwaltung;
            this.index = index;
            vornameTextBox.Text = schuelerverwaltung.SchuelerVorname(index);
            nameTextBox.Text = schuelerverwaltung.SchuelerName(index);
            geburtsdatumTextBox.Text = schuelerverwaltung.SchuelerGeburtsdatum(index);
        }

        private void korrigierenButton_Click(object sender, EventArgs e)
        {
            schuelerverwaltung.SchuelerKorrigieren(index,
                                                   vornameTextBox.Text,
                                                   nameTextBox.Text,
                                                   geburtsdatumTextBox.Text);
            this.Close();
        }

        private void vornameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            korrigierenButton.Enabled = vornameTextBox.Text != "";
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            korrigierenButton.Enabled = nameTextBox.Text != "";
        }

        private void geburtsdatumTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            korrigierenButton.Enabled = geburtsdatumTextBox.Text != "";
        }
    }
}