﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    
    public partial class Form1 : Form
    {
        Elephant lucinda, lloyd;
        public Form1()
        {
            lucinda = new Elephant(){Name="Lucinda", EarSize=33};
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;
            MessageBox.Show("Objects swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
