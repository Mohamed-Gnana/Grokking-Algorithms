using System;

namespace PhoneBookLookUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new PhoneBook();
            book.AddNumber("Mohamed", 01015169761);
            book.AddNumber("Asmaa", 01010203040);
            book.AddNumber("Alaa", 01020304050);
            book.AddNumber("Arwa", 01030405060);
            book.AddNumber("Ahmed", 01040506070);

            foreach(string name in book.getBook().Keys)
            {
                Console.WriteLine($"{name} : {book.getNumber(name)}");
            }

            string q = null, o;
            do
            {
                Console.WriteLine("Please, Enter the required order on the form (r for read, w for write):");
                o = Console.ReadLine();
                if (o == "r")
                {
                    Console.Write("Please, Enter the person's name :\n");
                    Console.WriteLine($"The number : {book.getNumber(Console.ReadLine())}");
                }
                else
                {
                    Console.Write("Please, Enter the person's name and number on this form (Ahmed, xxxxxx)\n");
                    string[] parts = new string[2];
                    parts = Console.ReadLine().Split(",");
                    book.AddNumber(parts[0], int.Parse(parts[1]));
                }
                q = Console.ReadLine();
            }
            while (q != "q");
        }
    }
}
