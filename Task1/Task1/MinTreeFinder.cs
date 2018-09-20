using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class MinTreeFinder
    {
        public static Tuple<List<int>[], int> FindMinTree(Tuple<List<Edge> , int> graph)
        {
            var result = new List<int>[graph.Item2];
            var orderedEdges = graph.Item1.OrderBy(edge => edge.Cost);
            var treeId = new int[graph.Item2];
            var cost = 0;
            
            for (var i = 0; i < graph.Item2; i++)
            {
                treeId[i] = i;
                result[i] = new List<int>();
            }
            
            foreach (var edge in orderedEdges)
            {
                var newId = treeId[edge.From.NodeNumber - 1];
                var oldId = treeId[edge.To.NodeNumber - 1];
                
                if (oldId == newId) continue;
                
                result[edge.From.NodeNumber-1].Add(edge.To.NodeNumber);
                result[edge.To.NodeNumber-1].Add(edge.From.NodeNumber);
                cost += edge.Cost;
                for (var i = 0; i < treeId.Length; i++)
                {
                    if (treeId[i] == oldId)
                    {
                        treeId[i] = newId;
                    }
                }
            }    
            
            return new Tuple<List<int>[], int>(result, cost);
        }
    }
}