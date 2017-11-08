using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Gift : IGift
    {
        public ICollection<Sweet> items;

        public Gift()
        {
            items = new List<Sweet>();
        }
        public int GiftWeight()
        {
            return items.Sum(x => x.Weight);
        }
        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }
        public void Sort()
        {
            items = items.OrderBy(x => x.Cost).ToList();
        }
        public IEnumerable<Sweet> FindSweetsInGiftByCalories(int min, int max)
        {
            return items.Where(x => (x.Calories >= min) && (x.Calories <= max)).ToList();
        }

        public IEnumerable<Sweet> Items
        {
            get { return items; }
        }

    }
}
