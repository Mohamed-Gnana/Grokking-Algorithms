using System;
using System.Collections.Generic;
using System.Text;

namespace KnapsackProblemUsingDynamicProgramming
{
    public class KnapsackDP
    {
        double[,] grid;
        int maxWieght;
        int itemsCount;

        public KnapsackDP(double maxWieght, int numStoreItems)
        {
            this.maxWieght = (int)maxWieght + 1;
            this.itemsCount = (int)numStoreItems + 1;
            grid = new double[this.itemsCount, this.maxWieght];
        }

        public double maxValue(List<(string item, double price, double wieght)> store)
        {
            for(int i = 1; i < itemsCount; i++)
            {
                int currentItem = i - 1;
                for(int j = 1; j < maxWieght; j++)
                {
                    if (store[currentItem].wieght > j)
                    {
                        grid[i, j] = grid[i - 1, j];
                    }
                    else
                    {
                        grid[i, j] = Math.Max(grid[i - 1, j], store[currentItem].price + grid[i - 1, j - (int)store[currentItem].wieght]);
                    }
                }
            }
            return grid[itemsCount - 1, maxWieght - 1];
        }
    }
}
