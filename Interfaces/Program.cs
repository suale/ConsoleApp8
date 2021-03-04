using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

           
            StudentScheduler studentScheduler = new StudentScheduler();
            ISheduler teacherScheduler = new TeacherScheduler();

            studentScheduler.SchedulePlan();
            teacherScheduler.SchedulePlan();

            SchedulerManager schedulerManager = new SchedulerManager();
            schedulerManager.SchedulePerson(teacherScheduler);





            Console.ReadLine();
        }
    }
}
