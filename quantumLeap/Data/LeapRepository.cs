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


        //public List<Leap> GetLeaps()
        //{
        //    return _leaps;
        //}

        //public void SaveNewLeap(Leap newLeap)
        //{
        //    newLeap.Id = Guid.NewGuid();
        //    _leaps.Add(newLeap);
        //}
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

    //internal class Leap
    //{
    //    public Guid Id { get; set; }
    //    public string Host { get; set; }
    //    public string Leaper { get; set; }
    //    public string Date { get; set; }
    //    public string Location { get; set; }

    }