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

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Skiny zadarmo, počkej pro vyzvednutí odměny!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            while (true)
                MessageBox.Show("Skiny zadarmo, počkej pro vyzvednutí odměny!");
        }
    }
}
