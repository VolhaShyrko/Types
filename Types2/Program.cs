using System.Collections.Generic;

namespace Types2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Store!");
            Console.WriteLine("Here is the goods list we can offer:\r\n");

            List<GoodInfo> list = GetGoodslist();
            foreach (GoodInfo item in list)
            {
                Console.WriteLine(string.Format("Item = {0} : Quantity = {1} : Price = {2} ", item.Good, item.Quantity, item.Price));
            }

            
            Console.ReadKey();

        }

        private static List<GoodInfo> GetGoodslist()
        {
            List<GoodInfo> list = new List<GoodInfo>
                                      {
                                          new GoodInfo("Book", 12.49M, 1),
                                          new GoodInfo("Music CD", 14.99M, 1),
                                          new GoodInfo("Chocolate Bar", 8.5M, 1)
                                      };

            return list;
        }
    }
}
