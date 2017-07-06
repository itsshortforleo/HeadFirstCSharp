﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagementSystem
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            cbWorkerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });

            queen = new Queen(workers);
        }

        private void btnAssignThisJobToABee_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(cbWorkerBeeJob.Text, (int)nudShifts.Value) == false)
            {
                MessageBox.Show("No workers available to do the job '"+ cbWorkerBeeJob.Text+"'", "The queen bee says...");
            }
            else
            {
                MessageBox.Show("The job '" + cbWorkerBeeJob.Text + "' will be done in " + nudShifts.Value + " shifts", "The queen bee says...");
            }

        }

        private void btnWorkTheNextShift_Click(object sender, EventArgs e)
        {
            tbReport.Text = queen.WorkTheNextShift();
        }
    }
}
