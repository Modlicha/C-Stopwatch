using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoper
{
    public partial class Form1Stoper : Form
    {
        private short _hours, _minutes, _seconds;
        public Form1Stoper()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;

            ShowTime();

            buttonStartLicz.Enabled = true;
        }

        private void buttonStartLicz_Click(object sender, EventArgs e)
        {
            buttonStartLicz.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTime();
            IncreaseSeconds();
        }

        private void IncreaseSeconds()
        {
            
            if (_seconds == 9)
            {
                _seconds = 0;
                IncreaseMinutes();
            }
            else
            {
                _seconds++;
            }
        }

        private void IncreaseMinutes()
        {
            if (_minutes == 59)
            {
                _minutes = 0;
                IncreaseHours();
            }
            else
            {
                _minutes++;
            }
        }

        private void IncreaseHours()
        {
            _hours++;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            buttonStartLicz.Enabled = false;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonStartLicz.Enabled = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is a typical stopwatch. All needed shortcuts are in the menu. Used classes in this project: textbox, timer, picturebox, button, menustrip. Maximum countdown time: 1 Hour.");
        }

        private void twórcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program is made by Bartlomiej Modliszewski.");
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1Stoper_Load(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStartLicz.Enabled = true;
            timer1.Enabled = false;
        }

        private void ShowTime()
        {
            hours.Text = _hours.ToString("00");
            minutes.Text = _minutes.ToString("00");
            seconds.Text = _seconds.ToString("00");
        }
    }
}
