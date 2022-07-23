using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BakuLondonTask
{
    public partial class Form1 : Form
    {
        Timer timer =new Timer();
        int az_uk = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();

            //clock.Text = DateTime.Now.ToLongTimeString();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.AddHours(-az_uk).ToLongTimeString();
        }

        private void Time_Click(object sender, EventArgs e)
        {
            if (Time.Text == "London")
            {
                Time.Text = "Baku";
                az_uk = 3;
                MessageBox.Show("Test");
                //clock.Text = newDate.ToLongTimeString();
            }
            else
            {
                Time.Text = "London";
                az_uk = 0 ;
            }
        }
    }
}
