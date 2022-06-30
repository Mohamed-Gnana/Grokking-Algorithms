using System;

namespace SimpleHashTableAKADictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new HashTable<string, int>();
            dict.Add("Mohamed", 8);
            dict.Add("Ahmed", 1);
            dict.Add("Ali", 2);
            dict.Add("Asmaa", 3);
            dict.Add("Alaa", 4);
            dict.Add("Arwa", 5);
            dict.Add("Hanem", 6);
            dict.Add("Hatem", 7);
            dict.Add("Abanob", 9);

            foreach (int i in dict.getDic())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(dict.getValue("Arwa"));
            
        }
    }
}
