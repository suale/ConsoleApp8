using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class TeacherScheduler : ISheduler
    {
        public void SchedulePlan()
        {
            Console.WriteLine("Öğretmen planlaması yapıldı.");
        }
    }
}
