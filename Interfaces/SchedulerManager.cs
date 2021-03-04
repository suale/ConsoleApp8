using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SchedulerManager
    {
        public void SchedulePerson(ISheduler sheduler)
        {
            sheduler.SchedulePlan();
        }

    }
}
