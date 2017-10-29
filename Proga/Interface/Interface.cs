using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    interface Interface
    {
        IEnumerable<Sweet> Items { get; }
        void Add(Sweet sweets);
        void Sort();
        IEnumerable<Sweet> FindCandyByCalories(int min, int max);
        int GiftWeight();
    }
}
