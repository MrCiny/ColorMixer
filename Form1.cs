using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        int redStep = 1;
        int greenStep = 1;
        int blueStep = 1;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomRed_Click(object sender, EventArgs e)
        {
            red = rand.Next(0, 256);
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
            RedValue.Text = red.ToString();
            RedSlider.Value = red;
        }

        private void RandomGreen_Click(object sender, EventArgs e)
        {
            green = rand.Next(0, 256);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
            GreenValue.Text = green.ToString();
            GreenSlider.Value = green;
        }

        private void RandomBlue_Click(object sender, EventArgs e)
        {
            blue = rand.Next(0, 256);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
            BlueValue.Text = blue.ToString();
            BlueSlider.Value = blue;
        }

        private void RandomMix_Click(object sender, EventArgs e)
        {
            red = rand.Next(0, 256);
            green = rand.Next(0, 256);
            blue = rand.Next(0, 256);

            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);

            BlueValue.Text = blue.ToString();
            RedValue.Text = red.ToString();
            GreenValue.Text = green.ToString();

            GreenSlider.Value = green;
            RedSlider.Value = red;
            BlueSlider.Value = blue;
        }

        private void RedSlider_Scroll(object sender, EventArgs e)
        {
            UpdateRed();
        }

        private void GreenSlider_Scroll(object sender, EventArgs e)
        {
            UpdateGreen();

        }

        private void BlueSlider_Scroll(object sender, EventArgs e)
        {
            UpdateBlue();
        }

        private void RedTimer_Tick(object sender, EventArgs e)
        {
            RedSlider.Value += redStep;
            if (RedSlider.Value == RedSlider.Maximum || RedSlider.Value == RedSlider.Minimum)
            {
                redStep *= -1;
            }
            UpdateRed();
        }

        private void UpdateRed()
        {
            red = RedSlider.Value;
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
            RedValue.Text = red.ToString();
        }

        private void UpdateGreen()
        {
            green = GreenSlider.Value;
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
            GreenValue.Text = green.ToString();
        }
        private void UpdateBlue()
        {
            blue = BlueSlider.Value;
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
            BlueValue.Text = blue.ToString();
        }

        private void RedTimerStart_Click(object sender, EventArgs e)
        {
            RedTimer.Interval = 20;
            RedTimer.Start();
        }

        private void BlueTimerStart_Click(object sender, EventArgs e)
        {
            BlueTimer.Interval = 20;
            BlueTimer.Start();
        }

        private void BlueTimer_Tick(object sender, EventArgs e)
        {
            BlueSlider.Value += blueStep;
            if (BlueSlider.Value == BlueSlider.Maximum || BlueSlider.Value == BlueSlider.Minimum)
            {
                blueStep *= -1;
            }
            UpdateBlue();
        }

        private void GreenTimerStart_Click(object sender, EventArgs e)
        {
            GreenTimer.Interval = 20;
            GreenTimer.Start();
        }

        private void GreenTimer_Tick(object sender, EventArgs e)
        {
            GreenSlider.Value += greenStep;
            if (GreenSlider.Value == GreenSlider.Maximum || GreenSlider.Value == GreenSlider.Minimum)
            {
                greenStep *= -1;
            }
            UpdateGreen();
        }
    }
}
