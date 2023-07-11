using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class CustomizeMessageUsingFunction
    {
        public static void CustomizeFunction()
        {
            // Read the input message
            string line = " Hello <<name>>, \nWe have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.\nPlease,let us know in case of any clarification. \nThank you BridgeLabz dd/MM/yyyy.";
            line = line.Replace("<<name>>", "Mukul");
            line = line.Replace("<<full name>>", "Mukul Dev Patel");
            line = line.Replace("91-xxxxxxxxxx", "91-5426795645");
            line = line.Replace("dd/MM/yyyy",DateTime.UtcNow.ToString("d"));
            Console.WriteLine(line);
        }
    }
}
