using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_6
{//zadatak 2
    interface IAbstractBoxIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
