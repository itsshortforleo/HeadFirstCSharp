using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        int MinimumBet = 5;
        public bool RaceStarted = false;
        Random MyRandomizer = new Random();
        
        Guy joe = new Guy();
        Guy bob = new Guy();
        Guy al = new Guy();
        Guy[] GuyArray = new Guy[3];
        Greyhound[] GreyhoundArray = new Greyhound[4];
        public Form1()
        {
            
            InitializeComponent();
            //bool HasRaceStarted = false;
            
            GuyArray[0] = joe = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = rbJoeRadioButton,MyLabel=lblJoeBetLabel, MyBet = null};
            GuyArray[1] = bob = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = rbBobRadioButton, MyLabel = lblBobBetLabel, MyBet = null };
            GuyArray[2] = al = new Guy() { Name = "Al", Cash = 45, MyRadioButton = rbAlRadioButton, MyLabel = lblAlBetLabel, MyBet = null };
            for (int i = 0; i < GuyArray.Length; i++)
            {
                GuyArray[i].ClearBet();
            }

            UpdateLabels();
            
            GreyhoundArray[0] = new Greyhound() 
            { 
                MyPictureBox = pbDogNumber1, 
                StartingPosition = pbDogNumber1.Left, 
                RacetrackLength = pbRacetrack.Width - pbDogNumber1.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pbDogNumber2,
                StartingPosition = pbDogNumber2.Left,
                RacetrackLength = pbRacetrack.Width - pbDogNumber2.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pbDogNumber3,
                StartingPosition = pbDogNumber3.Left,
                RacetrackLength = pbRacetrack.Width - pbDogNumber3.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pbDogNumber4,
                StartingPosition = pbDogNumber4.Left,
                RacetrackLength = pbRacetrack.Width - pbDogNumber4.Width,
                Randomizer = MyRandomizer
            };
            
        }
        public void UpdateLabels()
        {
            minimumBetLabel.Text = "Minimum bet: " + MinimumBet + " bucks";
            nudAmountOfMoneyBet.Minimum = (int)MinimumBet;
            // Assigns checkedRadioButton's text value to the name label text value
            lblName.Text=joe.Name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #"+(i+1) +" won the race!","We have a winner");
                    for (int j = 0; j < GuyArray.Length; j++)
                    {
                        GuyArray[j].Collect(i);
                    }
                    for (int k = 0; k < GreyhoundArray.Length; k++)
                    {
                        GreyhoundArray[k].TakeStartingPosition();
                    }
                    GreyhoundArray[i].TakeStartingPosition();
                    RaceStarted = false;
                    break;
                }
            }
            
        }

        private void rbJoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = joe.Name;
        }

        private void rbBobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = bob.Name;
        }

        private void rbAlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = al.Name;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            if (RaceStarted==true)
            {
                timer1.Stop();
                MessageBox.Show("The race is already happening, idiot!", "Hold on");
            }
            RaceStarted = true;
            timer1.Start();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (RaceStarted==false)
            {
                for (int i = 0; i < GuyArray.Length; i++)
                {
                    if (GuyArray[i].MyRadioButton.Checked == true)
                    {
                        GuyArray[i].PlaceBet((int)nudAmountOfMoneyBet.Value, (int)nudDogToBetFor.Value);
                    }
                }
            }
            
        }

    }
}
