using System;
using System.Collections.Generic;
using System.Linq;

namespace KClosestElements
{
    class Program
    {
        public static int[][] KClosest(int[][] points, int K)
        {
            if (points.Length == K) return points;

            Dictionary<int, int> distances = new Dictionary<int, int>();

            for (int i = 0; i < points.Length; i++)
            {
                distances[i] = distance(points[i][0], points[i][1]);
            }

            var kPoints = FindK(distances, K);

            int[][] result = new int[kPoints.Count][];

            int kp = 0;

            foreach (var p in kPoints)
            {
                result[kp] = new int[2];
                result[kp][0] = points[p.Key][0];
                result[kp][1] = points[p.Key][1];
                kp++;
            }
            return result;
        }

        public static Dictionary<int, int> FindK(Dictionary<int, int> distances, int K)
        {
            if (distances.Count == K) return distances;

            Random random = new Random();
            var pivot = random.Next(0, distances.Count);

            Dictionary<int, int> left = new Dictionary<int, int>();
            Dictionary<int, int> right = new Dictionary<int, int>();
            Dictionary<int, int> equal = new Dictionary<int, int>();

            KeyValuePair<int, int> pivotKPair = distances.ElementAt(pivot);
            Dictionary<int, int> result = new Dictionary<int, int>();

            foreach (var item in distances)
            {
                if (item.Value < pivotKPair.Value)
                    left.Add(item.Key, item.Value);

                if (item.Value == pivotKPair.Value)
                    equal.Add(item.Key, item.Value);

                if (item.Value > pivotKPair.Value)
                    right.Add(item.Key, item.Value);
            }

            if (left.Count == K) return left;

            // Console.WriteLine("Adding left and equal");
            if (left.Count + equal.Count == K)
                return AddRangeToDictionary(left, equal);

            if (left.Count > K)
                return FindK(left, K);
            else
            {
                // Console.WriteLine("Adding left");
                result = AddRangeToDictionary(result, left);

                // Console.WriteLine("Adding equal");
                result = AddRangeToDictionary(result, equal);

                // Console.WriteLine("Adding right");
                result =
                    AddRangeToDictionary(result,
                    FindK(right, K - left.Count - equal.Count));
            }

            return result;
        }

        public static Dictionary<int, int> AddRangeToDictionary(
            Dictionary<int, int> dict,
            Dictionary<int, int> newElements
        ) {
            foreach (var item in newElements)
            {
                dict.Add(item.Key, item.Value);
            }

            return dict;
        }

        public static int distance(int pt1, int pt2)
        {
            return pt1 * pt1 + pt2 * pt2;
        }

        static void Main(string[] args)
        {
            int[][] points = new int[3][];

            // points[0] = new int[2]{1,3};
            // points[1] = new int[2]{-2,2};

            // var K = 1;

            //  result {-2, 2}
       
            points[0] = new int[2]{3, 3}; 
            points[1] = new int[2]{ 5,-1};
            points[2] = new int[2]{-2, 4};
            var K = 2;
            // Output: [[3,3],[-2,4]]

            var result = KClosest(points, K);
            int i = 0;

            foreach (var item in result)
            {
                Console.WriteLine("{0}, {1} ", result[i][0], result[i][1]);                
                i++;
            }
        }
    }
}
