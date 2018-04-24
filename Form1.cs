using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Character_counter
{
    public partial class Form1 : Form
    {
        public string Version = "Version 1.2D BETA";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = true;
            }
        }

        public int count = 3;

        private void button2_Click(object sender, EventArgs e)
        {
            if (text.Text.Length != 0)
            {
                Clipboard.SetText("[total_characters: " + text.Text.Count() + "] \r\n\r\n" + text.Text);


                Loopy(5);
                popup_txt.Visible = true;
            }
            else
            {
                MessageBox.Show("Text can't be 0(NULL)", "ALERT");
            }
        }

        #region Events

        void Loopy(int times)
        {
            count = times;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Start();
        }

        void timer1_tick(Object myObject, EventArgs myEventArgs)
        {
            count--;
            if (count == 0)
            {
                popup_txt.Visible = false;
                timer1.Stop();
            }



        }

        #endregion

        private void text_TextChanged(object sender, EventArgs e)
        {
            lbl_charCount.Text = Int32.Parse("" + text.Text.Length).ToString() + " characters";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_version.Text = Version;
        }
    }
}
