using System;

namespace pool_servers
{
    class Program
    {

        // always confirm the constraints
        // are the numbers unique, are the numbers always positive

        static void Main(string[] args)
        {
            // test for null

           int result = 0;
           result = next_server_number(null);

          if (result != 1)
             Console.WriteLine("Test for null array failed");
        
        result = next_server_number(new int[]{5,4,1,2});

        if (result != 3)
            Console.WriteLine("Test for array with 5,4,1,2: failed, expected 3 but the actual result was {0}", result);
        
        result = next_server_number(new int[]{3,2,1});
        
        if (result != 4)
            Console.WriteLine("Test for array with 3,1,2: failed, expected 4 but the actual result was {0}", result);
       
        result = next_server_number(new int[]{3,2,1,4,5});

        if (result != 6)
           Console.WriteLine("Test for array with 3,1,2,4,5: failed, expected 6 but the actual result was {0}", result);

         Console.WriteLine("Finished");
         
        }

        public static int next_server_number(int[] servers)
        {                        
            if (servers == null || servers.Length == 0)
            {
                return 1;
            }

            // first solution is order the array in ascending order 

            // sorting in place
            Array.Sort(servers);

            if (servers.Length == servers[servers.Length - 1])
              return servers.Length + 1;

            for(int i = 0; i < servers.Length; i++)
            {
                if (servers[i] != i + 1)
                {
                    return (i + 1);
                }
            }

            return servers[servers.Length - 1] + 1;
        }
    }
}
