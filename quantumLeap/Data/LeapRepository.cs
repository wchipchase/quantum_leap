using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quantumLeap.Leaps;

namespace QuantumLeap
{
    class LeapRepository
    {
        static List<Events> _leaps = new List<Events>();

        static int Budget { get; set; }

        public List<Events> GetLeaps()
        {
            return _leaps;
        }

        internal void SaveNewLeap(Events quantumLeap)
        {
            quantumLeap.Id = Guid.NewGuid();
            _leaps.Add(quantumLeap);
        }

        //public Leap Update(Guid leapId, string host, string leaper, string date, string location)
        //{
        //    var leap = _leaps.First(x => x.Id == leapId);

        //    leap.Date = date;
        //    leap.Host = host;
        //    leap.Leaper = leaper;
        //    leap.Location = location;

        //    return leap;
        //}


        public int currentAvailableBudget()
        {
            return Budget;
        }
        public void saveBudget(int updatedBudget)
        {
            Budget = updatedBudget;
        }
    }
}