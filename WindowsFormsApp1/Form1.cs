using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calculate(int.Parse(textBox1.Text)).ToString();
        }
        public static long Calculate(int amount)
        {
            return Enumerable.Range(0, amount).Select(i => (long)Math.Sqrt(i)).Sum();
        }
    }
}
