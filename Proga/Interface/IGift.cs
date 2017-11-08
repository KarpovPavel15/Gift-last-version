using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    interface IGift
    {
        IEnumerable<Sweet> Items { get; }
        void Add(Sweet sweets);
        void Sort();
        IEnumerable<Sweet> FindSweetsInGiftByCalories(int min, int max);
        int GiftWeight();
    }
}
