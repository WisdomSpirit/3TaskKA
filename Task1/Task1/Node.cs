using System;
using System.Collections.Generic;

namespace Task1
{
    public class Node
    {
        public Node(int number)
        {
            NodeNumber = number;
        }

        public Node Parent;

        public readonly int NodeNumber;
        public readonly List<Tuple<Node, int>> IncidentNodes = new List<Tuple<Node, int>>();
    }
}