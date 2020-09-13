// using System.Collections.Generic;
// using System.Linq;

// namespace graphImpl
// {
//     public class Graph
//     {
//         public int numVertices;
//         public Dictionary<int, Vertex> vertexList;

//         public Graph()
//         {
//             numVertices = 0;   
//             vertexList = new Dictionary<int, Vertex>();         
//         }

//         public void AddVertex(int key)        
//         {                        
//             vertexList.Add(key, new Vertex(key));
//             numVertices++;            
//         }

//         // Add a connection to the list of connections of the node
//         // A connection is represented by a triplet(u,v,w) 
//         //  u is the origin vertex
//         //  v is the vertex that the origin is connected to
//         //  w is a value that represents the weight of the edge
//         public bool AddEdge(int u, int v, int w = 0)
//         {            
//             if (!vertexList.ContainsKey(u)) {
//                 AddVertex(u);            
//             }

//             if (!vertexList.ContainsKey(v)) {
//                 AddVertex(v);
//             }                       
//             vertexList[u].AddNeighbor(v,w);
//             return true;          
//         }

//     }
// }