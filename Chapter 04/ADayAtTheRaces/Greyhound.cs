using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; // How long the racetrack is
        public PictureBox MyPictureBox = null; // My PictureBox object
        public int Location = 0; // My Location on the racetrack
        public Random Randomizer; // An instance of Random
        public bool PulledHamstring = false;
        public int PulledHamstringCounter = 0;
        
        public bool Run()
        {
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form like this:
            //      MyPictureBox.Left = StartingPosition + Location;
            // Return true if I won the race
            Location=Randomizer.Next(9);
            if (Location>=4)
            {
                // Pulled hamstring
                PulledHamstring = true;

                MyPictureBox.Left = MyPictureBox.Left + StartingPosition;
                PulledHamstringCounter++;
            }
            if (PulledHamstring==true && PulledHamstringCounter<=3)
            {
                MyPictureBox.Left = MyPictureBox.Left + StartingPosition;
                PulledHamstringCounter++;
            }
            else
            {
                PulledHamstring = false;
                MyPictureBox.Left = MyPictureBox.Left + StartingPosition + Location;
            }
            
            if (MyPictureBox.Left>=RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TakeStartingPosition()
        { 
            // Reset my location to 0 and PictureBox to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }

    }
}
