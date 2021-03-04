using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class StudentScheduler : ISheduler
    {
        public void SchedulePlan()
        {
            Console.WriteLine("Öğrenci planlaması yapıldı.");
        }

       
    }
}
