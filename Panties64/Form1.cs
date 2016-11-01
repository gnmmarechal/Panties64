using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panties64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        private void encodeButton_Click(object sender, EventArgs e)
        {
            string originalstring = inputBox.Text;
            while (Convert.ToInt32(timesBox.Text) > 0)
            {
                outputBox.Text = Base64Encode(inputBox.Text);
                inputBox.Text = outputBox.Text;
                timesBox.Text = Convert.ToString(Convert.ToInt64(timesBox.Text) - 1);
            }
            inputBox.Text = originalstring;
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string originalstring = inputBox.Text;
            while(Convert.ToInt32(timesBox.Text) > 0)
            {
                outputBox.Text = Base64Decode(inputBox.Text);
                inputBox.Text = outputBox.Text;
                timesBox.Text = Convert.ToString(Convert.ToInt64(timesBox.Text) - 1);
            }
            inputBox.Text = originalstring;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timesBox.Text = "1";
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timesBox.Text = Convert.ToString(Convert.ToInt64(timesBox.Text) + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timesBox.Text = Convert.ToString(Convert.ToInt64(timesBox.Text) - 1);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timesBox.Text = "1";
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt64(timesBox.Text) == 0)
            {
                decreaseTimes.Enabled = false;
            }
            else
            {
                decreaseTimes.Enabled = true;
            }
        }
    }
}
