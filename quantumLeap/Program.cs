using System;
using quantumLeap.Leaps;

namespace quantumLeap
{
    class Program
    {
        static void Main(string[] args)
        {
            //var newLeap = new Events();
            //newLeap.addLeaper("Silvestre");

            var testLeap = new Leap();

            var personLeaper = testLeap.getLeaper();
            Console.WriteLine(personLeaper);

            var quantumLeap = testLeap.getEvent();
            Console.WriteLine($"{quantumLeap.Leaper} you have lept to, {quantumLeap.Date} {quantumLeap.Location}, you're apparently {quantumLeap.Host}");
        }
    }
}
