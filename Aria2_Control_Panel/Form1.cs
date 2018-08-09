using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aria2_Control_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Aria2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("aria2c.vbs");
        }

        private void Stop_Aria2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Stop.bat");
        }

        private void Restart_Aria2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("restart.bat");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
