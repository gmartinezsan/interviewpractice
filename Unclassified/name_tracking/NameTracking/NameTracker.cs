using System;
using System.Collections.Generic;

namespace NameTracking
{
    public class NameTracker
    {
        // dictionary of names where every name has a list of the indexes used for the name
        // allocate method add the name to the dictionary if it does not exist, or update the lists of indexes to the smallest available in the list, 
        // so it can be allocated.
        // deallocate method deletes the number from the list of indexes 

        Dictionary<string, SortedSet<int>> hostnames;

        public NameTracker()
        {
            hostnames = new Dictionary<string, SortedSet<int>>();
        }

        public string allocate(string hostname)
        {
            string newname;               
            if (hostnames.ContainsKey(hostname))
            {
                // get the smallest available index
                var indexes = hostnames[hostname];
                newname = string.Format(hostname + "{0}", indexes.Max + 1);
                indexes.Add(indexes.Max + 1);
                hostnames[hostname] = indexes;
            }
            else
            {
                hostnames.Add(hostname, new SortedSet<int>{{ 1 }});
                newname = hostname + "1";
            }
            return newname;
        }

        public bool deallocate(string hostname)
        {
            if (String.IsNullOrEmpty(hostname))
                throw new ArgumentNullException("hostname");

            string name = string.Empty;
            int index = 0;

            // parse the name 
            for(int i = hostname.Length - 1; i > 0; i--)
            {
                if (Char.IsDigit(hostname[i])==false)
                {
                  name = hostname.Substring(0, i + 1);                
                  index = Int32.Parse(hostname.Substring(i + 1));                  
                  break;
                }              
            }

            //delete the index
            if (hostnames.ContainsKey(name))
            {
                var indexes = hostnames[name];
                if (indexes.Contains(index))
                {
                   indexes.Remove(index);
                   return true;
                }                
            }
            return false;
        }

        public List<string> PrintDictionary()
        {
            var names = new List<string>();
            
            foreach(var pair in hostnames)
            {
                foreach (var index in pair.Value)
                {
                   names.Add(pair.Key+index.ToString()); 
                }
            }

            return names;
        }

    }
}
