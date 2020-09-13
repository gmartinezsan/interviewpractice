using System;
using System.Collections.Generic;
using System.Linq;

namespace listapi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] calls = {
        "/project1/subproject1/method1",
        "/project2/subproject1/method1",
        "/project1/subproject1/method1",
        "/project1/subproject2/method1",
        "/project1/subproject1/method2",
        "/project1/subproject2/method1",
        "/project2/subproject1/method1",
        "/project1/subproject2/method1"
           };

        countAPI(calls);

        }


        static string[] countAPI(string[] calls)
        {
            List<root> rootNodes = new List<root>();
            foreach (string val in calls)
            {
                var ncalls = val.Substring(1).Split('/');

                // represents a root node
                var rootNode = rootNodes.Find(t => t.name == ncalls[0]);

                if (rootNode == null)
                {
                    rootNode = new root { name = ncalls[0], subproject_nodes = new List<subproject>() };
                    rootNodes.Add(rootNode);
                }

                // represents a subprojects node                
                var subprojectsNode = rootNode.subproject_nodes.Find(t => t.name == ncalls[1]);

                if (subprojectsNode == null)
                {
                    subprojectsNode = new subproject { name = ncalls[1], methods = new Dictionary<string, int>() };
                    rootNode.subproject_nodes.Add(subprojectsNode);
                }
               
                if (!subprojectsNode.methods.TryAdd(ncalls[2], 1))                    
                    subprojectsNode.methods[ncalls[2]] += 1;
                    
                  subprojectsNode.occurs = subprojectsNode.methods.Values.Aggregate((tot, valm) => tot + valm);
                  rootNode.occurs = rootNode.subproject_nodes.Select(t => t.occurs).Aggregate((projects, val) => projects + val);
            }

            // var totalsubprojects = 0;
            // var totalmethods = 0;

            // rootNodes.ForEach(x =>
            // {
            //     totalsubprojects += x.subproject_nodes.Count;
            //     x.subproject_nodes.ForEach(t =>
            //     {
            //         totalmethods += t.methods.Count;
            //     });
            // });

            // var apiLength = rootNodes.Count + totalsubprojects + totalmethods;
           
            // string[] result = new string[apiLength];
            // int row = 0;
             List<string> result = new List<string>();
            foreach (var rootnode in rootNodes)
            {
               result.Add(string.Format("--{0} ({1})",  rootnode.name, rootnode.occurs));
               foreach(var sub in rootnode.subproject_nodes)
               {
                   result.Add(string.Format("----{0} ({1})", sub.name, sub.occurs));
                   foreach (var method in sub.methods)
                   {
                       result.Add(string.Format("------{0} ({1})", method.Key, method.Value));
                   }
               }
            }
            
            return result.ToArray();
        }

    }
    public class subproject
    {
        public string name;
        public int occurs;
        public Dictionary<string, int> methods;
    }

    public class root
    {
        public string name;
        public int occurs;
        public List<subproject> subproject_nodes = new List<subproject>();        
    }


}
