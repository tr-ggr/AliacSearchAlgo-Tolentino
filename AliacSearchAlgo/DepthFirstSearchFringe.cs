using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample
{
    class DepthFirstSearchFringe:Fringes
    {
       // DFS
       // Stack<Node> s;
        Stack<Node> s;
        public DepthFirstSearchFringe() 
        {
            s = new Stack<Node>();
        }
        
        public void add(Node n,Node origin)
        {
            n.Origin = origin;
            s.Push(n);
        }

        public Node remove()
        {
            if (s.Count != 0)
                return s.Pop();
            return null;
        }
    }
}
