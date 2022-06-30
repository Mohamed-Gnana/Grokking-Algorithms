using System;

namespace ListUsingArrayCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Listy<int> ints = new Listy<int>(1);
            ints.push(2);
            ints.push(3);
            Console.WriteLine(ints.pop());
            Console.WriteLine(ints.pop());
            Console.WriteLine(ints.pop());
            Console.WriteLine(ints.pop());
        }
    }
}
