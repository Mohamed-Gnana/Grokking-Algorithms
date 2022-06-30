using System;
using System.Collections.Generic;
using System.Text;

namespace SubString
{
    public class Compare
    {
        int[,] grid;
        string word1;
        string word2;

        public Compare(string word1, string word2)
        {
            this.word1 = word1;
            this.word2 = word2;
            this.grid = new int[this.word1.Length + 1, this.word2.Length + 1];
        }

        public int MaxSubString()
        {
            for(int i = 1; i < word1.Length + 1; i++)
            {
                int currentCharIndex = i - 1;
                for(int j = 1; j < word2.Length + 1; j++)
                {
                    int currentCharIndex2 = j - 1;
                    if (word2[currentCharIndex2] == word1[currentCharIndex])
                    {
                        grid[i, j] = grid[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        grid[i, j] = 0;
                    }
                }
            }
            int bestMatch = 0;
            for (int i = 0; i < word1.Length + 1; i++)
            {
                for (int j = 0; j < word2.Length + 1; j++)
                {
                    if (grid[i, j] > bestMatch)
                        bestMatch = grid[i, j];
                }
            }
            return bestMatch;
        }
    }
}
