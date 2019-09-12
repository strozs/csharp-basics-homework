using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
          * Origination:
          * Audi -> Germany
          * BMW -> Germany
          * Honda -> Japan
          * Mercedes -> Germany
          * VolksWagen -> Germany
          * Tesla -> USA
          */
        static void Main(string[] args)
        {
            string[] array = { "Audi->Germany", "BMW->Germany", "Honda->Japan", "Mercedes->Germany", "VolksWagen->Germany", "Mercedes->Germany", "Tesla->USA" };

            var list = new List<string>();
            var hash = new HashSet<string>();
            var dictionary = new Dictionary<string, string>();

            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i].Substring(0, array[i].IndexOf("->") ));
                hash.Add(array[i].Substring(0, array[i].IndexOf("->") ));
                if (!dictionary.ContainsKey(array[i].Substring(0, array[i].IndexOf("->") )))
                {
                    dictionary.Add(
                        array[i].Substring(0, array[i].IndexOf("->")), 
                        array[i].Substring(array[i].IndexOf("->") +2 ));
                }
            }

            Console.WriteLine("List: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("HashSet: ");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Dictionary: ");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            }

            Console.ReadKey();

            //todo - replace array with an List and print out the results --DONE--

            //todo - replace array with a HashSet and print out the results --DONE--

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results --DONE--
        }
    }
}
