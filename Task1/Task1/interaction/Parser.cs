using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.interaction
{
    public class Parser
    {
        public static Tuple<List<Edge>, int> Parse(List<string> list)
        {
            var graph = new List<Edge>();
            var nodesCount = int.Parse(list.First());
            list.RemoveAt(0);
            var hostNode = 1;
            foreach (var str in list)
            {
                var intSet = str.Split(' ')
                    .Select(int.Parse)
                    .ToList();
            
                for (var k = 0; k < intSet.Count; k++)
                {
                    if (k % 2 == 1) graph.Add(new Edge(new Node(hostNode), new Node(intSet[k-1]), intSet[k]));
                }

                hostNode++;
            }
            return new Tuple<List<Edge>, int>(graph, nodesCount);
        }
    }
}