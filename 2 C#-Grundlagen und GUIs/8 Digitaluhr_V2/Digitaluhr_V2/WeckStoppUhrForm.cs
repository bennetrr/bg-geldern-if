using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Digitaluhr_V2
{
    public partial class WeckStoppUhrForm : Form
    {
        private readonly SoundPlayer player;
        private readonly WeckStoppUhr uhr;
        private bool alarmAusgelöst;

        public WeckStoppUhrForm()
        {
            InitializeComponent();
            einstellungenCheckBox.Checked = false;
            uhr = new WeckStoppUhr();
            alarmAusgelöst = false;
            player = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
        }

        private void einstellungenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            einstellungenGroupBox.Visible = einstellungenCheckBox.Checked;
        }

        private void RenderDisplay()
        {
            uhrzeitLabel.Text = uhr.Uhr_gibUhrzeit();
            stoppuhrLabel.Text = uhr.Stoppuhr_gibStoppuhrzeit();
            weckzeitLabel.Text = uhr.Wecker_gibWeckzeit();
        }

        private void PlaySound()
        {
            alarmAusgelöst = true;
            player.PlayLooping();
            uhrzeitLabel.ForeColor = Color.Red;
        }

        private void StopSound()
        {
            alarmAusgelöst = false;
            player.Stop();
            uhrzeitLabel.ForeColor = Color.Black;
        }

        private void taktgeberTimer_Tick(object sender, EventArgs e)
        {
            uhr.ErhoeheZeit();
            if (uhr.Wecker_gibAlarm() && !alarmAusgelöst)
            {
                PlaySound();
                Console.Out.WriteLine("Wecker klingelt");
            }

            RenderDisplay();
        }

        private void stoppuhrStartenUndStoppenButton_Click(object sender, EventArgs e)
        {
            if (uhr.Stoppuhr_gibStoppuhrLaeuft())
            {
                uhr.Stoppuhr_stoppen();
                stoppuhrStartenUndStoppenButton.Text = "Starten";
            }
            else
            {
                uhr.Stoppuhr_starten();
                stoppuhrStartenUndStoppenButton.Text = "Stoppen";
            }
        }

        private void resetStoppuhrButton_Click(object sender, EventArgs e)
        {
            uhr.Stoppuhr_reset();
            stoppuhrStartenUndStoppenButton.Text = "Starten";
        }

        private void weckerEinschaltenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (weckerEinschaltenCheckBox.Checked) uhr.Wecker_einschalten();
            else uhr.Wecker_ausschalten();
        }

        private void schlummernButton_Click(object sender, EventArgs e)
        {
            uhr.Wecker_schlummern();
            StopSound();
        }

        private void AlarmAusButtonClick(object sender, EventArgs e)
        {
            uhr.wecker_AlarmAusschalten();
            StopSound();
        }

        private void stundeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UhrzeitEinlesen();
        }

        private void minuteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UhrzeitEinlesen();
        }

        private void sekundeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UhrzeitEinlesen();
        }

        private void UhrzeitEinlesen()
        {
            var stunde = (int) stundeNumericUpDown.Value;
            var minute = (int) minuteNumericUpDown.Value;
            var sekunde = (int) sekundeNumericUpDown.Value;

            uhr.Uhr_setzeUhrzeit(stunde, minute, sekunde);
        }

        private void weckstundeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            WeckzeitEinlesen();
        }

        private void weckminuteNnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            WeckzeitEinlesen();
        }

        private void wecksekundeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            WeckzeitEinlesen();
        }

        private void WeckzeitEinlesen()
        {
            var stunde = (int) weckstundeNumericUpDown.Value;
            var minute = (int) weckminuteNumericUpDown.Value;
            var sekunde = (int) wecksekundeNumericUpDown.Value;

            uhr.Wecker_setzeWeckzeit(stunde, minute, sekunde);
        }
    }
}