using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    static class DynamicProgramming
    {
        public static int PathsCountRecursion(int[,] grid, int rowPos, int colPos)
        {
            if (EndOfGrid(grid, rowPos, colPos)) return 1;
            if (isInvalidCell(grid, rowPos, colPos)) return 0;
            return PathsCountRecursion(grid, rowPos + 1, colPos) + PathsCountRecursion(grid, rowPos, colPos + 1);
        }


        public static int PathsCountMemoized(int[,] grid, int rowPos, int colPos, Dictionary<Tuple<int, int>, int> memo = null)
        {
            if (EndOfGrid(grid, rowPos, colPos)) return 1;
            if (isInvalidCell(grid, rowPos, colPos)) return 0;

            if (memo == null) memo = new Dictionary<Tuple<int, int>, int>();

            var key = new Tuple<int, int>(rowPos, colPos);
            if (memo.TryGetValue(key, out int value))
                return value;
            else
            {
                value = PathsCountRecursion(grid, rowPos + 1, colPos) + PathsCountRecursion(grid, rowPos, colPos + 1);
                memo.Add(key, value);
                return value;
            }
        }

        public static int PathsCountDynamicProg(int[,] grid, int rowPos, int colPos, int[,] helperGrid = null)
        {
            int dimention = grid.Dimention();
            if (helperGrid == null) helperGrid = new int[dimention, dimention];

            for (int row = dimention - 1; row >= 0; row--)
                for (int col = dimention - 1; col >= 0; col--)
                {
                    if (EndOfGrid(grid, row, col)) helperGrid[row, col] = 1;
                    else if (isInvalidCell(grid, row, col)) helperGrid[row, col] = 0;
                    else helperGrid[row, col] = (IsLast(grid, row) ? 0 : helperGrid[row + 1, col]) + (IsLast(grid, col) ? 0 : helperGrid[row, col + 1]);
                }

            return helperGrid[0, 0];
        }

        private static bool IsLast(int[,] grid, int rowOrCol) => rowOrCol + 1 == grid.Dimention();

        private static int Dimention(this int[,] grid) => grid.GetLength(0);

        private static bool isInvalidCell(int[,] grid, int rowPos, int colPos)
            => rowPos >= grid.Dimention() || colPos >= grid.Dimention() || grid[rowPos, colPos] == 1;

        private static bool EndOfGrid(int[,] grid, int rowPos, int colPos)
            => rowPos == grid.Dimention() - 1 && colPos == grid.Dimention() - 1;
    }
}
