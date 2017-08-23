using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem2
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }

        bool LookForEnemies();
        bool SharpenStinger(int length);

    }
}
