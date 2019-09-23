  using System;
using System.Collections.Generic;
using System.Text;
using QuantumLeap;

namespace quantumLeap.Leaps
{
    class Leap
    {
        List<string> leapers = new List<string>()
        {
            "Sam Beckett",
            "Silvestre Luna",
            "Wayne Chipchase",
            "Saul Solano"
        };

        public List<Events> leaps = new List<Events>()
        {
            new Events {Location = "Dealey Plaza, Dallas, Texas", Date = "November 22, 1963", Host = "John Connally"},
            new Events {Location = "Kennedy Space Center, Florida", Date = "April 11, 1970", Host = "Jim Lovell"},
            new Events {Location = "Democratic National Committee headquarters at the Watergate office complex in Washington, D.C DC", Date = "June 17, 1971", Host = "Alfred Baldwin"},
            new Events {Location = "Southampton England", Date = "April 10, 1912", Host = "Edward J. Smith"},
            new Events {Location = "Lexington, Massachusetts", Date = "December 21, 1734 ", Host = "Paul Revere"},
            new Events {Location = "Petersburg, Virginia", Date = "April 1, 1865", Host = "General Grant"},
            new Events {Location = "Ford's Theatre, Washington, D.C", Date = "April 14, 1865", Host = "John Wilkes Booth"},
            new Events {Location = "San Francisco harbor", Date = "January 18, 1911", Host = "Eugene B. Ely"},
            new Events {Location = "Boston laboratory", Date = "March 10, 1876", Host = "Alexander Graham Bell"},
            new Events {Location = "The Civil Rights march on Washington, D.C.", Date = "August 28, 1963", Host = "Dr. Martin Luther King"}
        };

        public string getLeaper()
        {
            var random = new Random();

            int index = random.Next(leapers.Count);

            var currentLeaper = leapers[index];

            return currentLeaper;
        }

        public Events getEvent()
        {
            var random = new Random();

            int index = random.Next(leaps.Count);

            var currentEvent = leaps[index];
            
            return currentEvent;
        }

        public Events createALeap()
        {
            var aLeap = getEvent();

            aLeap.AddLeaper(getLeaper());

            aLeap.isPutRight = !aLeap.isPutRight;

            return aLeap;
        }

    }
}
