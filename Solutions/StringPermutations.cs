using System.Collections.Generic;

namespace Solutions
{
    public static class StringPermutations
    {


        public static int GetUniqueChars(string s)
        {
            return IsUnique(s);
        }

        public static List<string> AllPermutations(string s)
        {
            var permutations = new List<string>();

            // base case
            if (s.Length == 1)
            {
                permutations.Add(s);
            }
            else
            {
                foreach (char c in s)
                {
                    // Permutations are the first character and the permutations of the rest of the string
                    // take all the characters but the one of the iteration.
                    var rest = RestOfString(c, s);
                    foreach (var permutation in AllPermutations(rest))
                    {
                        permutations.Add(c + permutation);
                    }
                }
            }
            return permutations;

        }

        private static string RestOfString(char c, string rest)
        {
            return rest.Substring(0, rest.IndexOf(c)) + rest.Substring(rest.IndexOf(c) + 1);
        }

        private static int IsUnique(string current)
        {
            var unique = new HashSet<char>(current);

            if (unique.Count == current.Length)
                return unique.Count;

            return -1;
        }
    }
}