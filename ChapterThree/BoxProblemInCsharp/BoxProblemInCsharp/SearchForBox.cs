using System;
using System.Collections.Generic;
using System.Text;

namespace BoxProblemInCsharp
{
    public static class SearchForBox
    {
        public static void SearchwithWhile(Box box)
        {
            LinkedList<Box> boxes = new LinkedList<Box>(new List<Box>() { box });
            LinkedListNode<Box> node = boxes.First;
            Box b;
            while(node != null)
            {
                b = node.Value;
                Console.WriteLine(b.getId());
                if(b.getContent() == Type.Boxes)
                {
                    Console.WriteLine($"Box {b.getId()} has {b.getItems().Count} items inside.");
                    foreach(Box item in b.getItems())
                    {
                        boxes.AddLast(item);
                    }
                }
                else if (b.getContent() == Type.Empty)
                {
                    Console.WriteLine($"Box {b.getId()} had nothing inside.");
                }
                else
                {
                    Console.WriteLine($"Box {b.getId()} has the key.");
                    break;
                }
                node = node.Next;
            }
        }

        public static void SearchusingFor(List<Box> boxes)
        {
            for(int i = 0; i < boxes.Count; i++)
            {
                Console.WriteLine(boxes[i].getId());
                if (boxes[i].getContent() == Type.Boxes)
                {
                    Console.WriteLine($"Box {boxes[i].getId()} has {boxes[i].getItems().Count} items inside.");
                    foreach (Box item in boxes[i].getItems())
                    {
                        boxes.Add(item);
                    }
                }
                else if (boxes[i].getContent() == Type.Empty)
                {
                    Console.WriteLine($"Box {boxes[i].getId()} had nothing inside.");
                }
                else
                {
                    Console.WriteLine($"Box {boxes[i].getId()} has the key.");
                    break;
                }
            }
        }

        public static void SearchusingRecurrsion(List<Box> boxes)
        {
            foreach(Box b in boxes)
            {
                Console.WriteLine($"I am Box {b.getId()}.");
                if(b.getContent() == Type.Boxes)
                {
                    Console.WriteLine($"I have {b.getItems().Count} items inside.");
                    SearchusingRecurrsion(b.getItems());
                }
                else if (b.getContent() == Type.Empty)
                {
                    Console.WriteLine("Sorry, I am empty. Try another one!!!");
                }
                else
                {
                    Console.WriteLine("Horray!!! You found the key!!!");
                    break;
                }
            }
        }
        public static void SearchwithNopiles(Box box)
        {
            Console.WriteLine($"I am Box {box.getId()}.");
            foreach (Box b in box.getItems())
            {
                if(b.getContent() == Type.Boxes)
                {
                    Console.WriteLine($"I am {box.getId()} and I will travel to {b.getId()}. Wish me luck!!");
                    SearchwithNopiles(b);
                    Console.WriteLine($"I am box {box.getId()} and I am back, bitches!!!!");
                }
                else if (b.getContent() == Type.Empty)
                {
                    Console.WriteLine($"I am {box.getId()} and I will not travel to this guys {b.getId()}. He has nothing!!!!");
                }
                else
                {
                    Console.WriteLine($"I am {box.getId()} and I opened {b.getId()}. It seems that I finally found it!!!");
                    break;
                }
            }
            Console.WriteLine($"I am {box.getId()}!!!");
        }
    }
}
