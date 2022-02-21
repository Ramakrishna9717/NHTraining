using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day_21_Project_2.ServiceReference1;

namespace Day_21_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
            int n = Convert.ToInt32(textBox1.Text);

            AlgebraSoapClient obj = new AlgebraSoapClient();

            textBox2.Text = obj.Factorial(n).ToString();


            Console.ReadLine();


        }
    }
}
