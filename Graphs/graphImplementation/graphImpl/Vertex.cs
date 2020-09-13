using System.Collections.Generic;
using System.Linq;

namespace graphImpl
{
    public class Vertex
    {
        public int Id;
        
         // Implicitly the node origin is the ID
        //  the edges list is a dictionary where the 
        // key is the Id of the vertex and the value its weight

        public Dictionary<int,int> connectedTo;        

        public Vertex(int key)
        {
            Id = key;
            connectedTo = new Dictionary<int, int>();
        }  
        
        public void AddNeighbor(int nbr, int weight = 0)       
        {
            connectedTo.Add(nbr, weight);    
        }

        public List<int> GetConnections()
        {
            return connectedTo.Keys.ToList();
        }

        public int GetWeight(int nbr)
        {
            return connectedTo[nbr];
        }

    }
}