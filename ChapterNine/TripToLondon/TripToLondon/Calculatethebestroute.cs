using System;
using System.Collections.Generic;
using System.Text;

namespace TripToLondon
{
    public class Calculatethebestroute
    {
        double[,] grid;
        int maxStay;
        int activitiesCount;

        public Calculatethebestroute(double maxStay, int activitiesCount)
        {
            this.maxStay = (int)maxStay * 2 + 1;
            this.activitiesCount = activitiesCount + 1;
            grid = new double[this.activitiesCount, this.maxStay * 2];
        }


        public double maxPoints(List<(string acitivity, double points, double stay)> activities)
        {
            for(int i = 1; i < activitiesCount; i++)
            {
                int currentActivity = i - 1;
                for(int j = 1; j < maxStay; j++)
                {
                    if (activities[currentActivity].stay > ((double)j/2))
                    {
                        grid[i, j] = grid[i, j - 1];
                    }
                    else
                    {
                        grid[i, j] = Math.Max(grid[i, j - 1],
                            activities[currentActivity].points + grid[i - 1, j - (int)(activities[currentActivity].stay * 2)]);
                    }
                }
            }
            return grid[activitiesCount - 1, maxStay - 1];
        }
    }
}
