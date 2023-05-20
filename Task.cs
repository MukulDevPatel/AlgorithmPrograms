using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Task
    {
        public int Deadline { get; }
        public int Duration { get; }

        public Task(int deadline, int duration)
        {
            Deadline = deadline;
            Duration = duration;
        }
    }
}
