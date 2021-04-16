using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelime_oyunu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.adYolla;
            label6.Text = Form1.kalanYolla;
            label7.Text = Form1.puanYolla;
            label8.Text = Form1.Tarihyolla;
            label9.Text = Form1.saatYolla;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
