using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap
{
    interface IEvents
    {
        string Location { get; set; }
        string Date { get; set; }
        string Host { get; set; } 
    }
}
