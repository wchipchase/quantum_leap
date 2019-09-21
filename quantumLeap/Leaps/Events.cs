using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap.Leaps
{
    class Events : IEvents
    {
        public string Location { get; set; }
        public string Date { get; set; }
        public string Host { get; set; }
        public string Leaper { get; set; }

        public void addLeaper(string person)
        {
            Leaper = person;
            Console.WriteLine(Leaper);
        }
    }
}
