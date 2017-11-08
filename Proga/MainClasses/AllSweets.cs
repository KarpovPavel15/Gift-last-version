using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class AllSweets
    {
        static void Main(string[] args)
        {
            List<Fruit> fruit = new List<Fruit>();
            fruit.Add(new Fruit("Orange", 180, 100, 100, 0, 0));
            fruit.Add(new Fruit("Pineapple", 20, 190, 100, 0, 0));
            fruit.Add(new Fruit("Apple", 100, 299, 200, 80, 0));
            fruit.Add(new Fruit("Banana", 301, 199, 300, 80, 0));

            List<Wafer> wafer = new List<Wafer>();
            wafer.Add(new Wafer("Kroket", 212, 761, 200, "chocolate", "banana"));
            wafer.Add(new Wafer("Spartak", 17, 1761, 200, "milk", "apple"));
            wafer.Add(new Wafer("Slodch", 310, 61, 200, "fruits", "strawbary"));
            wafer.Add(new Wafer("Vitba", 15, 77, 200, "cream", "coconut"));

            List<Candy> candy = new List<Candy>();
            candy.Add(new Candy("Cow", 23, 123, 700, 200, "chocolate"));
            candy.Add(new Candy("Bee", 17, 77631, 400, 200, "glazyr"));
            candy.Add(new Candy("Kuzn", 30, 71, 200, 200, "konyak"));
            candy.Add(new Candy("Gryliazh", 15, 773, 200, 200, "cream"));

            List<Sweet> sweets = new List<Sweet>();
            IGift gift = new Gift();

            sweets.AddRange(fruit);
            sweets.AddRange(wafer);
            sweets.AddRange(candy);

            JSON.SerializationSweet(sweets);
            sweets = JSON.DeserializationSweet();

            sweets.Sort();
            Show.Outputinfo(sweets);

            int summWeight = 0;
            for (int i = 0; i < sweets.Count; i++)
            {
                summWeight += sweets[i].Weight;
            }
            Console.WriteLine("Weight of product:" + summWeight);

            gift.Add(new Candy("Kuzn", 30, 71, 200, 200, "konyak"));
            gift.Add(new Wafer("Spartak", 17, 1761, 200, "milk", "apple"));
            gift.Add(new Wafer("Slodch", 310, 61, 200, "fruits", "strawbary"));
            gift.Add(new Fruit("Banana", 301, 199, 300, 80, 0));
            gift.Add(new Fruit("Orange", 180, 100, 100, 0, 0));


            Console.WriteLine();
            gift.Sort();
            Show.OutputinfoGift(gift);
            Console.WriteLine();

            foreach (var items in gift.FindSweetsInGiftByCalories(0, 100))
            {
                Console.WriteLine("Name of product: {0}, Calories: {1}", items.Name, items.Calories);
            }
            Console.WriteLine();

            Console.WriteLine("Weight of gift: {0}", gift.GiftWeight());
            Console.ReadKey();
        }
    }


}
