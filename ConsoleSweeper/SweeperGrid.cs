using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        Random generator = new Random();

        void SweeperGrids()
        {
            int[,] grid = new int[9,9];

            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    grid[x, y] = 9;

                    // for (int i = 0; i < 10; i++)
                    // {
                    //     grid[x,y] = generator.Next(9,11);
                    // }  
                }
            }
        }  
    }
}