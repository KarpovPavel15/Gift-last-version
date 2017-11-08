using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Show
    {
        public static void Outputinfo(List<Sweet> sweets)
        {
            foreach (Sweet sweet in sweets)
            {
                Console.WriteLine(sweet.ToString());
            }

        }
        public static void OutputinfoGift(IGift gift)
        {
            Console.WriteLine("Gift content: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("Name of product : {0}, Weight of product: {1}, Calories: {2}, Cost: {3},"
                    , i.Name, i.Weight, i.Calories, i.Cost);

            }
        }
    }
}
