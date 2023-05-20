using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class TaskSchedule
    {
        public static void TaskScheduler()
        {
            Console.Write("Enter task number: ");
            int numTasks = int.Parse(Console.ReadLine());
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < numTasks; i++)
            {
                string[] input = Console.ReadLine().Split();
                int deadline = int.Parse(input[0]);
                int duration = int.Parse(input[1]);
                tasks.Add(new Task(deadline, duration));
            }

            // Sort tasks by deadline in ascending order
            tasks.Sort((t1, t2) => t1.Deadline.CompareTo(t2.Deadline));

            int currentCompletionTime = 0;
            int maxOvershoot = 0;

            foreach (Task task in tasks)
            {
                currentCompletionTime += task.Duration;
                int overshoot = Math.Max(0, currentCompletionTime - task.Deadline);
                maxOvershoot = Math.Max(maxOvershoot, overshoot);
            }

            Console.WriteLine("Maximum work done {0}", maxOvershoot);
        }
    }
}
