﻿using System;
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
    public partial class Sumator : Form
    {
        public Sumator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = Decimal.Parse(this.textBox1.Text);
            var num2 = Decimal.Parse(this.textBox2.Text);
            var sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }
    }
}
