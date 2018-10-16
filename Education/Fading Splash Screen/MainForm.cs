using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Zastavka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tmrMain = new System.Windows.Forms.Timer() { Interval = 10 };
            this.Opacity = 0;
            tmrMain.Tick += (os, ea) =>
            {
                this.Opacity += 0.005;
                if (this.Opacity == 1)
                {
                    tmrMain.Stop();
                    this.Opacity = 0;
                    Thread.Sleep(20);
                    var mBox = MessageBox.Show("Вы просмотрели картинку!", "Конец!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            };
            tmrMain.Start();

        }
    }
}
