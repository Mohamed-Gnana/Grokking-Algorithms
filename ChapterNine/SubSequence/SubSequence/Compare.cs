using System;
using System.Collections.Generic;
using System.Text;

namespace SubSequence
{
    public static class Compare
    {
        public static int getMaxSubString(string word1, string word2)
        {
            int[,] grid = new int[word1.Length + 1, word2.Length + 1];
            for(int i = 1; i <= word1.Length; i++)
            {
                int curI = i - 1;
                for(int j = 1; j <= word2.Length; j++)
                {
                    int curJ = j - 1;
                    if (word2[curJ] != word1[curI])
                    {
                        grid[i, j] = Math.Max(grid[i - 1, j], grid[i, j - 1]);
                    }
                    else
                    {
                        grid[i, j] = grid[i - 1, j - 1] + 1;
                    }
                }
            }
            int bestMatch = default;
            for(int i = 0; i <= word1.Length; i++)
            {
                for(int j = 0; j <= word2.Length; j++)
                {
                    if (grid[i, j] > bestMatch)
                        bestMatch = grid[i, j];
                }
            }
            return bestMatch;
        }
    }
}
