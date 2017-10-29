using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Gift:Interface
    {
        private ICollection<Sweet> items;

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
            var temp = items.OrderBy(x => x.Cost).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }
        public IEnumerable<Sweet> FindCandyByCalories(int min, int max)
        {
            return items.Where(x => (x.Calories >= min) && (x.Calories<= max)).ToList();
        }
        public IEnumerable<Sweet> Items
        {
            get { return this.items; }
        }

    }
}
