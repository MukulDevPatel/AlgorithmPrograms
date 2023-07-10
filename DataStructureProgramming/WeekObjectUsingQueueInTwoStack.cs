using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class WeekDays
    {
        public string Day { get; set; }
        public string Date { get; set; }

        public WeekDays(string day, string date)
        {
            Day = day;
            Date = date;
        }
    }

    public class Weeks
    {
        private LinkedList<WeekDays> days;

        public Weeks()
        {
            days = new LinkedList<WeekDays>();
        }

        public void AddDay(string day, string date)
        {
            WeekDays weekDays = new WeekDays(day, date);
            days.AddLast(weekDays);
        }

        public void Display()
        {
            foreach (WeekDays day in days)
            {
                Console.WriteLine(day.Day + " " + day.Date);
            }
        }
    }

    public class CalendarWeek
    {
        private LinkedList<Weeks> weeks;

        public CalendarWeek()
        {
            weeks = new LinkedList<Weeks>();
        }

        public void AddWeek(Weeks week)
        {
            weeks.AddLast(week);
        }

        public void Display()
        {
            foreach (Weeks week in weeks)
            {
                week.Display();
                Console.WriteLine();
            }
        }
    }
    public class WeekObjectUsingQueueInTwoStack
    {
        public static void WeekStackQueue()
        {
            // Create Week Object with WeekDay objects stored in a Queue
            Weeks week1 = new Weeks();
            week1.AddDay("Sun\t", "1");
            week1.AddDay("Mon\t", "2");
            week1.AddDay("Tue\t", "3");
            week1.AddDay("Wed\t", "");
            week1.AddDay("Thu\t", "5");
            week1.AddDay("Fri\t", "6");
            week1.AddDay("Sat\t", "7");

            Weeks week2 = new Weeks();
            week2.AddDay("Sun\t", "8");
            week2.AddDay("Mon\t", "9");
            week2.AddDay("Tue\t", "10");
            week2.AddDay("Wed\t", "11");
            week2.AddDay("Thu\t", "12");
            week2.AddDay("Fri\t", "");
            week2.AddDay("Sat\t", "14");

            // Create Calendar Object with Weeks stored in a Queue
            CalendarWeek calendar = new CalendarWeek();
            calendar.AddWeek(week1);
            calendar.AddWeek(week2);

            // Display the Calendar
            calendar.Display();
        }
    }
}
