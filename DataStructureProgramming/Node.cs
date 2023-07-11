using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class Nodes
    {
        public string Value { get; set; }
        public Nodes Next { get; set; }

        public Nodes(string data)
        {
            Value = data;
            Next = null;
        }
    }
}
