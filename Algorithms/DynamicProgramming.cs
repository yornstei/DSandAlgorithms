using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    static class DynamicProgramming
    {
        public static int PathsCountRecursion(int[,] grid, int rowPos, int colPos)
        {
            if (ReachedEndOfGrid(grid, rowPos, colPos)) return 1;

            if (isInvalidCell(grid, rowPos, colPos)) return 0;
            return PathsCountRecursion(grid, rowPos + 1, colPos) + PathsCountRecursion(grid, rowPos, colPos + 1);

            //if (CanGoDown(grid, rowPos, colPos) && CanGoRight(grid, rowPos, colPos))
            //    return PathsCountRecursion(grid, rowPos + 1, colPos) + PathsCountRecursion(grid, rowPos, colPos + 1);

            //if (CanGoDown(grid, rowPos, colPos))
            //    return PathsCountRecursion(grid, rowPos + 1, colPos);

            //if (CanGoRight(grid, rowPos, colPos))
            //    return PathsCountRecursion(grid, rowPos, colPos + 1);

            //return 0;
        }

        private static bool isInvalidCell(int[,] grid, int rowPos, int colPos)
        {
            return rowPos < 8 && colPos < 8 && grid[rowPos, colPos] != 1;
        }

        public static int PathsCountMemoized(int[,] grid, int rowPos, int colPos)
        {
            return 0;
        }

        public static int PathsCountDynamicProg(int[,] grid, int rowPos, int colPos)
        {
            return 0;
        }


        private static bool CanGoRight(int[,] grid, int rowPos, int colPos)
        {
            return colPos + 1 < grid.GetLength(0) && grid[rowPos, colPos + 1] != 1;
        }

        private static bool CanGoDown(int[,] grid, int rowPos, int colPos)
        {
            return rowPos + 1 < grid.GetLength(0) && grid[rowPos + 1, colPos] != 1;
        }

        private static bool ReachedEndOfGrid(int[,] grid, int rowPos, int colPos)
        {
            return rowPos == grid.GetLength(0) && colPos == grid.GetLength(0);
        }
    }
}
