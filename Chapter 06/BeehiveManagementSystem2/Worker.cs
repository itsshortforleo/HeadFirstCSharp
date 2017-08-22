using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem2
{
    class Worker : Bee
    {
        private string currentJob="";
        private int shiftsToWork;
        private int shiftsWorked;
        const double honeyUnitsPerShiftWorked = .65;

        private string[] jobsICanDo;

        public string GetCurrentJob()
        {
            return currentJob;
        }

        public string[] JobsICanDo { get => jobsICanDo; set => jobsICanDo = value; }
        public int ShiftsLeft { get => (shiftsToWork - shiftsWorked); }

        public Worker(string[] jobsICanDo, double weightMg) : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string jobToBePerformed, int numberOfShifts)
        {
            if (String.IsNullOrEmpty(currentJob) && JobsICanDo.Contains(jobToBePerformed)) 
            {
                currentJob = jobToBePerformed;
                this.shiftsToWork = numberOfShifts;
                shiftsWorked = 0;
                return true;
            }
            return false;
        }

        public bool DidYouFinish()
        {
            shiftsToWork -= 1;
            shiftsWorked++;
            if (shiftsToWork == 0)
            {
                currentJob = string.Empty;
                shiftsWorked = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyUnitsPerShiftWorked;
            return consumption;
        }
    }


}
