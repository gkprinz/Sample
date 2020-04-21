using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(DateTime.Now.ToString("HH")), j = 1;
            Random random = new Random();
            TimeSpan start = TimeSpan.FromHours(i + j);
            j++;
            TimeSpan end = TimeSpan.FromHours(i + j);
            int maxMinutes = (int)((end - start).TotalMinutes);

            int minutes = random.Next(maxMinutes);
            TimeSpan t = start.Add(TimeSpan.FromMinutes(minutes));
            File.AppendAllText("D:/test.txt", DateTime.Now.ToString() + Environment.NewLine);

            while (true)
            {
                TimeSpan tm = TimeSpan.FromHours(DateTime.Now.Hour);
                tm = tm.Add(TimeSpan.FromMinutes(DateTime.Now.Minute));
                if (tm >= t)
                {
                    start = TimeSpan.FromHours(i + j);
                    j++;
                    end = TimeSpan.FromHours(i + j);
                    maxMinutes = (int)((end - start).TotalMinutes);

                    minutes = random.Next(maxMinutes);
                    t = start.Add(TimeSpan.FromMinutes(minutes));
                    File.AppendAllText("D:/test.txt", DateTime.Now.ToString() + Environment.NewLine);
                }
                Thread.Sleep(1000);
            }

        }
    }
}
