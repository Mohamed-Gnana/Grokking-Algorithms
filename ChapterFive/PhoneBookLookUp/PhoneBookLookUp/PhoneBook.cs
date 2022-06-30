using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookLookUp
{
    public class PhoneBook
    {
        Dictionary<string, int> book;

        public PhoneBook()
        {
            book = new Dictionary<string, int>();
        }

        public void AddNumber(string name, int number)
        {
            book.Add(name.ToLower(), number);
        }

        public Dictionary<string, int> getBook()
        {
            return book;
        }

        public int getNumber(string name)
        {
            return book[name.ToLower()];
        }

    }
}
