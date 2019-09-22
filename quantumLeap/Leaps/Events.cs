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
        public bool isPutRight { get; set; }

        public void AddLeaper(string person)
        {
            Leaper = person;
            Console.WriteLine(Leaper);
        }

        public void UpdateIsPutRight(bool isPutRightValue)
        {
            isPutRight = isPutRightValue;
        }
    }
}
