using System;
using System.Collections.Generic;

namespace shortest_path
{
    class Program
    {

        public static int FindShortestPath(int[,] matrix, int sr, int sc, int tr, int tc)
        {
            if (matrix.GetLength(0) == 0 && matrix.GetLength(1) == 0)
                return -1;

            Queue<int[]> q = new Queue<int[]>();

            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            q.Enqueue(new int[2] { sr, sc });
            matrix[sr, sc] = 0;

            int i = sr;
            int j = sc;
            int count = 0;
            while (q.Count > 0)
            {
                var item = q.Dequeue();                             
                
                if (matrix[item[0],item[1]] == 1)
                  count++;
                
                if (item[0] == tr && item[1] == tc)
                    return count;                
                
                explore_neighbors(item[0], item[1], matrix, q);                
            }

            return -1;
        }


        public static void explore_neighbors(int i, int j, int[,] matrix, Queue<int[]> q)
        {
           
            matrix[i, j] = 0;           

            if (i + 1 < matrix.GetLength(0) && matrix[i + 1, j] != 0) q.Enqueue(new int[2] { i + 1, j });
            if (i - 1 >= 0 && matrix[i - 1, j] != 0) q.Enqueue(new int[2] { i - 1, j });
            if (j + 1 < matrix.GetLength(1) && matrix[i, j + 1] != 0) q.Enqueue(new int[2] { i, j + 1 });
            if (j - 1 >= 0 && matrix[i, j- 1] != 0) q.Enqueue(new int[2] { i, j - 1 });
           
        }


        static void Main(string[] args)
        {
            int[,] grid = new int[, ]{{1, 1, 1, 1}, {0, 0, 0, 1}, {1, 1, 1, 1}};
            int sr = 0;
            int sc = 0;
            int tr = 2, tc = 0;

            int length = FindShortestPath(grid, sr, sc, tr, tc);

            Console.WriteLine(length);
        }
    }
}
