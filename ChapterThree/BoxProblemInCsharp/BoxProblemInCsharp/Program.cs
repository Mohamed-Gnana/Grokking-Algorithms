using System;
using System.Collections.Generic;

namespace BoxProblemInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("1", Type.Boxes, new List<Box>() {
            new Box("2", Type.Boxes, new List<Box>() {
            new Box("4", Type.Empty, new List<Box>()),
                new Box("5", Type.Empty, new List<Box>())}),
                new Box("3", Type.Boxes, new List<Box>(){
                new Box("6", Type.Empty, new List<Box>()),
                    new Box("7", Type.Key, new List<Box>()),
                    new Box("8", Type.Empty, new List<Box>())})});

            SearchForBox.SearchwithWhile(box);
            SearchForBox.SearchusingFor(new List<Box>() { box });
            SearchForBox.SearchusingRecurrsion(new List<Box>() { box });
            SearchForBox.SearchwithNopiles(box);
        }
    }
}
