using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber=0;

        public Queen(Worker[] workers)
        {
            this.Workers = workers;
            //this.ShiftNumber = 1;
        }

        public int ShiftNumber { get => shiftNumber; set => shiftNumber = value; }
        internal Worker[] Workers { get => workers; set => workers = value; }

        public bool AssignWork(string jobToBePerformed, int numberOfShifts)
        {
            foreach (var worker in Workers)
            {
                if (worker.DoThisJob(jobToBePerformed, numberOfShifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            ShiftNumber += 1;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                {
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                }
                if (String.IsNullOrEmpty(workers[i].GetCurrentJob()))
                {
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                }
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].GetCurrentJob() + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
                    }
                    else
                    {
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].GetCurrentJob() + "' after this shift\r\n";

                    }
                }
            }
            return report;
        }
    }
}
