using System;

namespace spiralmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] a = new [,]{{2,4,6,8}, {5,9,12,16}, {2,11,5,9}, {3,2,1,8}};
            PrintMatrix(a);
        }

        static void PrintMatrix(int[,] a)
        {
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);

            int top = 0;
            int bottom = rows - 1;
            int left = 0;
            int right = columns - 1;
            int direction = 0; // 0 left to righ, 1 top to bottom, 2 right to left, 3 bottom to top

            while (bottom >= top && right >= left)
            {
                if (direction == 0)
                {
                    for (int i = left; i <= right; i++)
                    {
                        Console.Write(a[top, i]);
                    }
                    top++;
                    direction = 1;
                }
                if (direction == 1)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        Console.Write(a[i,right]);                        
                    }
                    right--;
                    direction = 2;
                }
                if (direction == 2)
                {
                    for(int i = right; i>= left; i--)
                    {
                        Console.Write(a[bottom, i]);
                    }
                    bottom --;
                    direction = 3;
                }
                if (direction == 3)
                {
                    for(int i = bottom ; i >= top; i--)
                    {
                        Console.Write(a[i,left]);
                    }
                    left++;                    
                    direction = 0;
                }
            }
        }
    }
}
