using System;
using quantumLeap.Leaps;

namespace quantumLeap
{
    class Program
    {
        static void Main(string[] args)
        {

            var testLeap = new Leap();

            var quantumLeap = testLeap.addLeaperToEvent();
            Console.WriteLine($"{quantumLeap.Leaper} you have lept to, {quantumLeap.Date} {quantumLeap.Location}, you're apparently {quantumLeap.Host}");
        }
    }
}
