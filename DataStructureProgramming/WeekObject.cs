using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class WeekDay
    {
        public string Day { get; set; }
        public string Date { get; set; }
    }

    public class Week
    {
        public Queue<WeekDay> Days { get; set; }

        public Week()
        {
            Days = new Queue<WeekDay>();
        }
    }

    public class Calendar
    {
        public Queue<Week> Weeks { get; set; }

        public Calendar()
        {
            Weeks = new Queue<Week>();
        }

        public void AddWeek(Week week)
        {
            Weeks.Enqueue(week);
        }

        public void DisplayCalendar()
        {
            foreach (var week in Weeks)
            {
                foreach (var day in week.Days)
                {
                    Console.WriteLine($"{day.Day}: {day.Date}");
                }
                Console.WriteLine();
            }
        }
    }
    public class WeekObject
    {
        public static void WeekPresent()
        {
            // Create Week Object
            Week week = new Week();

            // Create WeekDay Objects and add them to the Week Object
            WeekDay monday = new WeekDay { Day = "Monday", Date = "1" };
            WeekDay tuesday = new WeekDay { Day = "Tuesday", Date = "2" };
            WeekDay wednesday = new WeekDay { Day = "Wednesday", Date = "" }; // No date
            WeekDay thursday = new WeekDay { Day = "Thursday", Date = "4" };
            WeekDay friday = new WeekDay { Day = "Friday", Date = "5" };
            WeekDay saturday = new WeekDay { Day = "Saturday", Date = "6" };
            WeekDay sunday = new WeekDay { Day = "Sunday", Date = "7" };

            week.Days.Enqueue(monday);
            week.Days.Enqueue(tuesday);
            week.Days.Enqueue(wednesday);
            week.Days.Enqueue(thursday);
            week.Days.Enqueue(friday);
            week.Days.Enqueue(saturday);
            week.Days.Enqueue(sunday);

            // Create Calendar Object
            Calendar calendar = new Calendar();

            // Add Week Object to the Calendar
            calendar.AddWeek(week);

            // Display the Calendar
            calendar.DisplayCalendar();
        }
    }
}
