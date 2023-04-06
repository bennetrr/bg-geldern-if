using System;
using System.Windows.Forms;

namespace SchuelerverwaltungProjekt;

public partial class SchuelerverwaltungForm : Form
{
    private readonly Schuelerverwaltung _schuelerverwaltung;

    public SchuelerverwaltungForm()
    {
        InitializeComponent();
        _schuelerverwaltung = new Schuelerverwaltung();
    }

    private void anmeldenButton_Click(object sender, EventArgs e)
    {
        _schuelerverwaltung.SchuelerAnmelden(
            vornameTextBox.Text,
            nameTextBox.Text,
            geburtsdatumTextBox.Text
        );
        vornameTextBox.Clear();
        nameTextBox.Clear();
        geburtsdatumTextBox.Clear();
        SchuelerListBoxAktualisieren();
        AnmeldenButtonAktivierungsstatusAktualisieren();
        suchenButton.Enabled = _schuelerverwaltung.AnzahlSchueler() > 0;
    }

    private void korrigierenButton_Click(object sender, EventArgs e)
    {
        var korrekturForm = new KorrekturForm(_schuelerverwaltung, schuelerListBox.SelectedIndex);
        korrekturForm.ShowDialog();
        SchuelerListBoxAktualisieren();
        korrigierenButton.Enabled = false;
        loeschenButton.Enabled = false;
    }

    private void loeschenButton_Click(object sender, EventArgs e)
    {
        _schuelerverwaltung.SchuelerLoeschen(schuelerListBox.SelectedIndex);
        SchuelerListBoxAktualisieren();
        korrigierenButton.Enabled = false;
        loeschenButton.Enabled = false;
        suchenButton.Enabled = _schuelerverwaltung.AnzahlSchueler() > 0;
    }

    private void suchenButton_Click(object sender, EventArgs e)
    {
        var suchenForm = new SuchenForm(_schuelerverwaltung);
        suchenForm.ShowDialog();
        SchuelerListBoxAktualisieren();
    }

    private void schuelerListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (schuelerListBox.SelectedIndex > -1)
        {
            korrigierenButton.Enabled = true;
            loeschenButton.Enabled = true;
        }
    }

    private void vornameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        AnmeldenButtonAktivierungsstatusAktualisieren();
    }

    private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        AnmeldenButtonAktivierungsstatusAktualisieren();
    }

    private void geburtsdatumTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        AnmeldenButtonAktivierungsstatusAktualisieren();
    }

    private void SchuelerListBoxAktualisieren()
    {
        schuelerListBox.Items.Clear();
        for (var i = 0; i < _schuelerverwaltung.AnzahlSchueler(); i++)
            schuelerListBox.Items.Add(
                $"{_schuelerverwaltung.GetSchueler(i).Name}, {_schuelerverwaltung.GetSchueler(i).Vorname} ({_schuelerverwaltung.GetSchueler(i).Geburtsdatum})"
            );
    }

    private void AnmeldenButtonAktivierungsstatusAktualisieren()
    {
        if (vornameTextBox.Text != "" && nameTextBox.Text != "" && geburtsdatumTextBox.Text != "")
            anmeldenButton.Enabled = true;
        else
            anmeldenButton.Enabled = false;
    }

    private void SchuelerverwaltungForm_Enter(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char) Keys.Enter) anmeldenButton_Click(sender, e);
    }

    private void geburtsdatumTextBox_Enter(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char) Keys.Enter) anmeldenButton_Click(sender, e);
    }
}