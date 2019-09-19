using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantumLeap
{
    class LeapRepository
    {
        static List<Leap> _leaps = new List<Leap>();

        public List<Leap> GetLeaps()
        {
            return _leaps;
        }

        public void SaveNewLeap(Leap newLeap)
        {
            newLeap.Id = Guid.NewGuid();
            _leaps.Add(newLeap);
        }

        public Leap Update(Guid leapId, string host, string leaper, string date, string location)
        {
            var leap = _leaps.First(x => x.Id == leapId);

            leap.Date = date;
            leap.Host = host;
            leap.Leaper = leaper;
            leap.Location = location;

            return leap;
        }
    }

    internal class Leap
    {
        public Guid Id { get; set; }
        public string Host { get; set; }
        public string Leaper { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
    }
}