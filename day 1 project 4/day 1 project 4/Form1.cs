using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_1_project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(textBox1.Text);
            int sn = Convert.ToInt32(textBox2.Text);
            int power = Convert.ToInt32(Math(fn, sn));

            TextBox3.text = power.ToString();
        }
    }
}
