using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Show
    {
        public static void outputinfo(List<Sweet> AllSweet)
        {
            foreach(Sweet swt in AllSweet)
            {
                Console.WriteLine(swt.ToString());
            }
        }
        public static void outputinfoGift(Interface gift)
        {
            Console.WriteLine("Набор конфет: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Колории: {2}, Цена: {3},"
                    , i.Name, i.Weight, i.Calories, i.Cost);

            }
        }
    }
}
