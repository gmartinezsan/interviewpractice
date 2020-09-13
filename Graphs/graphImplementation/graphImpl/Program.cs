using System;
using System.Collections.Generic;

namespace graphImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. Create the graph
            List<Vertex> g = new List<Vertex>();

            // // Add the vertices
            // for (int i = 0; i < 6; i++)
            // {
            //     Vertex v = new Vertex(i);
            //     g.Add (v);
            // }

            // add the edges to the graph
            // this a directed and weighted graph
            // AddEdge(g, 0, 1, 5);
            // AddEdge(g, 0, 5, 2);
            // AddEdge(g, 1, 2, 4);
            // AddEdge(g, 2, 3, 9);
            // AddEdge(g, 3, 4, 7);
            // AddEdge(g, 3, 5, 3);
            // AddEdge(g, 4, 0, 1);
            // AddEdge(g, 5, 2, 1);
            // AddEdge(g, 5, 4, 8);

            // create an undirected and unweighted graph
            // this graph can be checked at 
            // https://www.geeksforgeeks.org/graph-and-its-representations/

            AddEdge(g, 0, 1, 0);
            AddEdge(g, 0, 4, 0);           
            AddEdge(g, 1, 4, 0);
            AddEdge(g, 1, 3, 0);
            AddEdge(g, 1, 2, 0);            
            AddEdge(g, 2, 3, 0);            
            AddEdge(g, 3, 4, 0);     

            // PrintGraph(g);  

            // Find the shortest path from 0 to 4
            FindShortestPath(0, 2, g);
            

            // DFS(g);

            // g = new List<Vertex>();

            // // this is an undirected and unweigthed graph
            // AddEdge(g, 0, 1);
            // AddEdge(g, 0, 4);
            // AddEdge(g, 1, 0);
            // AddEdge(g, 1, 2);
            // AddEdge(g, 1, 3);
            // AddEdge(g, 1, 4);
            // AddEdge(g, 2, 1);
            // AddEdge(g, 2, 3);
            // AddEdge(g, 3, 1);
            // AddEdge(g, 3, 2);
            // AddEdge(g, 3, 4);
            // AddEdge(g, 4, 0);
            // AddEdge(g, 4, 1);
            // AddEdge(g, 4, 3);

            // DFS(g);

            //  undirected graph and unweighted to test the BFS
            // AddEdge(g, 0, 9);
            // AddEdge(g, 0, 7);
            // AddEdge(g, 0, 11);

            // AddEdge(g, 9, 10);
            // AddEdge(g, 9, 8);

            // AddEdge(g, 7, 11);
            // AddEdge(g, 7, 6);
            // AddEdge(g, 7, 3);

            // AddEdge(g, 11, 0);
            // AddEdge(g, 11, 7);

            // AddEdge(g, 10, 1);
            // AddEdge(g, 10, 9);

            // AddEdge(g, 8, 1);
            // AddEdge(g, 8, 12);            
            // AddEdge(g, 8, 9);            

            // AddEdge(g, 6, 7);
            // AddEdge(g, 6, 5);

            // AddEdge(g, 3, 7);
            // AddEdge(g, 3, 4);
            // AddEdge(g, 3, 2);
        
            // AddEdge(g, 1, 8);
            // AddEdge(g, 1, 10);

            // AddEdge(g, 2, 3);
            // AddEdge(g, 2, 12);                                           
        
            // AddEdge(g, 4, 3);
            // FindShortestPath(0,10, g);
        }

        static void PrintGraph(List<Vertex> graph)
        {
            foreach (var v in graph)
            {
                Console.WriteLine("Vertex {0}", v.Id);
                foreach (KeyValuePair<int, int> u in v.connectedTo)
                {
                    Console.WriteLine("Edge to {0} of Weight {1}", u.Key, u.Value);
                }
            }
        }

        // Add a new connection to the u vertex
        // A connection is represented by a triplet(u,v,w)
        //  u is the origin vertex
        //  v is the vertex that the origin is connected to
        //  w is a value that represents the weight of the edge
        // Important Note:
        // The implementation of the AddEdge is very important
        // since this differ from a directed graph from an undirected graph
        // this code refers to a undirected graph
        static void AddEdge(List<Vertex> graph, int u, int v, int w = 0)
        {
            Vertex vertex;

            if (!graph.Exists(v => v.Id == u)) 
            {
                vertex = new Vertex(u);
                graph.Add(vertex);            
            }
            else
                vertex = graph.Find(t => t.Id == u);

            vertex.AddNeighbor (v, w);
                

            if (!graph.Exists(t => t.Id == v))            
            {
                vertex = new Vertex(v);
                graph.Add(vertex);      
            }
            else
                vertex = graph.Find(t => t.Id == v);
            
            vertex.AddNeighbor (u, w);                
                       
        }   

        static void DFSUtil(List<Vertex> g, int u, Dictionary<int, int> neighbors, bool[] visited)
        {
            visited[u] = true;     
            Console.WriteLine("Visiting {0}", u);
            foreach (var nbr in neighbors) {
                if (visited[nbr.Key] == false) {
                       DFSUtil(g, nbr.Key, g[nbr.Key].connectedTo, visited);
                }
            }            
        }
        //  Depth First Search recursive version
        //  The Time Complexity of this algorithm is O(V*E)

        static void DFS(List<Vertex> graph)
        {
            int n = graph.Count;
            bool[] visited = new bool[n];
            for (int u = 0; u < n; u++)
            {
                if (visited[u] == false) 
                    DFSUtil(graph, u, graph[u].connectedTo, visited); 
            }             
        }

        // Breath first search, uses a queue
        // This technique starts with a node and then explore its neighbors before moving to the next one
        // First thing is add a node to the queue and start exploring their neighbors until there are no more unvisited neighbors for this node
        // Second step is deque one element from the queue (first input first output)
        // Third Visit all their unvisited neighbors and add them to the queue
        // Fourth go to the Second step and dequeue a node
        // Go to their unvisited neighbors, if any of the nodes are already in the queue they they are skiped.
        // and the process goes on until there are no more element in the queue

        //  Example 
        // find the shortest path between two nodes in the graph
        // 

        public static int[] FindShortestPath(int s, int e, List<Vertex> graph)
        {
            if (!graph.Exists(n => n.Id == s) && graph.Exists(t => t.Id == e))
                return new int[]{};
            
            var prev = BFS(graph, 0);
            Console.WriteLine( "---- Shortest path ---- ");
            var path = new List<int>();
            int i = e;
            while (prev[i] != -1 && i >= 0)
            {                
                path.Add(prev[i]);
                i--;
            }

            path.Reverse();

            if (path[0] == s)
              return path.ToArray();
            
            return new int[]{};            
        }

        static int[] BFS(List<Vertex> graph, int start)
        {
            Queue<Vertex> q = new Queue<Vertex>();
            Vertex v = graph.Find(t => t.Id == start);
            q.Enqueue(v);

            int[] prev = new int[graph.Count];

            // initialization of prev to -1 to know where the path ends            
            for(int i = 0; i < prev.Length ; i++) {
                prev[i] = -1;
            }

            bool[] visited = new bool[graph.Count];
            visited[v.Id] = true;
            Console.WriteLine(v.Id);        
                
            while(q.Count > 0)
            {
                var nodeBeingVisited = q.Dequeue();
                var neighbors = graph.Find(t => t.Id == nodeBeingVisited.Id).connectedTo;
                foreach (var nbr in neighbors)
                {
                    if (!visited[nbr.Key])
                    {
                        q.Enqueue(graph.Find(t => t.Id == nbr.Key));
                        Console.WriteLine(nbr.Key);
                        visited[nbr.Key] = true;        
                        prev[nbr.Key] = nodeBeingVisited.Id;  // keep track of the parent node         
                    }
                }
            }
            return prev;
        }

    }
}
