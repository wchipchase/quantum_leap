using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap
{
    interface IEvents
    {
        string _Location { get; }
        string _Date { get; }
        string _Host { get; }
    }
}
