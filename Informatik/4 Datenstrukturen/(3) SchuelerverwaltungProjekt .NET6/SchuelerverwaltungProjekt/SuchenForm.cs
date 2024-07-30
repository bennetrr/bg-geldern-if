using System;
using System.Windows.Forms;

namespace SchuelerverwaltungProjekt;

public partial class SuchenForm : Form
{
    private readonly Schuelerverwaltung _schuelerverwaltung;

    public SuchenForm(Schuelerverwaltung schuelerverwaltung)
    {
        InitializeComponent();
        _schuelerverwaltung = schuelerverwaltung;
    }

    private void suchenButton_Click(object sender, EventArgs e)
    {
        suchergebnisListBox.Items.Clear();
        var suchergebnis = _schuelerverwaltung.SchuelerSuchen(suchenTextBox.Text);
        foreach (var schueler in suchergebnis)
            suchergebnisListBox.Items.Add(
                $"{schueler.Name}, {schueler.Vorname} ({schueler.Geburtsdatum})"
            );
    }

    private void suchenTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        suchenButton.Enabled = suchenTextBox.Text != "";
    }

    private void schliessenButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void suchenTextBox_Enter(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char) Keys.Enter) suchenButton_Click(sender, e);
    }
}