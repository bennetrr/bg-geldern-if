using System;
using System.Windows.Forms;

namespace SchuelerverwaltungProjekt;

public partial class KorrekturForm : Form
{
    private readonly int _index;
    private readonly Schuelerverwaltung _schuelerverwaltung;

    public KorrekturForm()
    {
        InitializeComponent();
    }

    public KorrekturForm(Schuelerverwaltung schuelerverwaltung, int index)
    {
        InitializeComponent();
        _schuelerverwaltung = schuelerverwaltung;
        _index = index;
        vornameTextBox.Text = schuelerverwaltung.GetSchueler(index).Vorname;
        nameTextBox.Text = schuelerverwaltung.GetSchueler(index).Name;
        geburtsdatumTextBox.Text = schuelerverwaltung.GetSchueler(index).Geburtsdatum;
    }

    private void korrigierenButton_Click(object sender, EventArgs e)
    {
        _schuelerverwaltung.SchuelerKorrigieren(_index,
            vornameTextBox.Text,
            nameTextBox.Text,
            geburtsdatumTextBox.Text);
        Close();
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