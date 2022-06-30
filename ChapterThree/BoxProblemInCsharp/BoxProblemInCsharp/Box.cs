using System;
using System.Collections.Generic;
using System.Text;

namespace BoxProblemInCsharp
{
    public class Box
    {
        string id;
        Type content;
        List<Box> items;

        public Box(string id, Type content, List<Box> items)
        {
            this.id = id;
            this.content = content;
            this.items = items;
        }

        public string getId()
        {
            return id;
        }
        public Type getContent()
        {
            return content;
        }
        public List<Box> getItems()
        {
            return items;
        }
    }
}
