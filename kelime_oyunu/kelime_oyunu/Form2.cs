﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelime_oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string adGonder;
        private void button1_Click(object sender, EventArgs e)
        {
            adGonder = textBox1.Text;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
