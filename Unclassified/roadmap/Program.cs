using System;
using System.Collections.Generic;
using System.Linq;

namespace roadmap
{

    public class task
    {
        public string nameTask;
        public DateTime startDate;
        public DateTime endDate;
        public List<string> owners;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[][] tasks = new string[3][];
            tasks[0] = new string[] { "A", "2017-02-01", "2017-03-01", "Sam", "Evan", "Troy" };
            tasks[1] = new string[] { "B", "2017-01-16", "2017-02-15", "Troy" };
            tasks[2] = new string[] { "C", "2017-02-13", "2017-03-13", "Sam", "Evan" };

            string[][] queries = new string[2][];
            queries[0] = new string[] { "Evan", "2017-03-10" };
            queries[1] = new string[] { "Troy", "2017-02-04" };
            roadmap(tasks, queries);
        }

        public static string[][] roadmap(string[][] tasks, string[][] queries)
        {

            List<task> t = new List<task>();

            foreach (string[] task in tasks)
            {
                List<string> namesOwners = new List<string>();
                for (int i = 3; i < task.Length; i++)
                {
                    namesOwners.Add(task[i]);
                }
                t.Add(new task { nameTask = task[0], startDate = DateTime.Parse(task[1]), endDate = DateTime.Parse(task[2]), owners = namesOwners });
            }

            List<string[]> result = new List<string[]>();

            foreach (var query in queries)
            {
                result.Add(t.Where(s => s.startDate.Date <= DateTime.Parse(query[1]).Date && s.endDate.Date >= DateTime.Parse(query[1]).Date && s.owners.Contains(query[0]))
                .OrderBy(s => s.endDate.Date).ThenBy(s => s.nameTask)
                .Select(i => new string(i.nameTask))
                .ToArray());
            }

            return result.ToArray();
        }
    }
}