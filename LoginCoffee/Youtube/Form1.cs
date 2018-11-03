using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace Youtube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login form = new Login();
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            this.Opacity = 0.85;
        }
    }
}
