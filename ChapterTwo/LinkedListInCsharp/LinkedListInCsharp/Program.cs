using System;

namespace LinkedListInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListy<int> ints = new LinkedListy<int>();
            ints.insertWithIndex(1, 0);
            ints.insert(1);
            ints.insertWithIndex(1, 2);
            ints.insert(2);
            ints.insertFront(3);
            Console.WriteLine($"{ints.getFirtNode()} {ints.getCount()}");
            Console.WriteLine(ints.getLastNode());
            ints.insertWithIndex(0, 0);
            Console.WriteLine(ints.getFirtNode());
        }
    }
}
