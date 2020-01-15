using System;
using System.Collections.Generic;

namespace inflight_movie
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = new int[] {122, 110, 144, 222};
            var flight_time = 232;
            var result = new inflight_movies();
            Console.WriteLine(result.AreTwoMovies(flight_time, times) ? "true" : "false");

        }
    }


    public class inflight_movies
    {
        public Boolean AreTwoMovies(int flight_time, int[] movies_times)
        {
            var times_set = new HashSet<int>();

            for (int i = 0; i < movies_times.Length; i++)
            {               
                if (times_set.Contains(flight_time - movies_times[i]))
                {
                  return true;
                }
                times_set.Add(movies_times[i]);            
            }

           return false;
        }
    }
}
