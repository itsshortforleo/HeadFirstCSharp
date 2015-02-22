using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithJoeAndBob
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }
        public Form1()
        {
            InitializeComponent();
            // Initialize joe and bob here!
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob" };
            UpdateForm();
        }

        private void btnGive10ToJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void btnReceive5FromBob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash>=10)
            {
                joe.Cash -= bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe doesn't have enough money to give to Bob.");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash>=5)
            {
                bob.Cash -= joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob doesn't have enough money to give to Joe.");
               
            }
        }
    }
}
