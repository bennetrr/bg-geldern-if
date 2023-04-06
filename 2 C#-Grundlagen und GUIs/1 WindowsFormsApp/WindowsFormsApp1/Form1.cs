using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text;
            if (textBox1.Text == "Darian")
            {
                text = "Nein!";
            }
            else
            {
                text = $@"Hallo {textBox1.Text}!";
            }

            throw new NullReferenceException();
            
            button1.Text = text;
        }
    }
}