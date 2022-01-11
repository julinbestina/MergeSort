using System;
using System.Collections.Generic;


namespace DFS
{
    class graph
    {
        private int vertices;
        private List<Int32>[] adj;
            public graph(int v)
          {
            vertices = v;
            adj =new List<Int32>[v];
          
            for(int i=0;i<v;i++)
            {
                adj[i] = new List<int>();
            }
          }
        public void addedge(int c,int v)
        {
            adj[c].Add(v);
        }
        public void DFS(int v)
        {
            bool[] visited = new bool[vertices];
            Stack< Int32 > stack= new Stack<int>();
            visited[v] = true;
            stack.Push(v);
            while(stack.Count!=0)
            {
                v = stack.Pop();
                Console.WriteLine("next->" + v);
                foreach(int i in adj[v])
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            graph g = new graph(11);
            g.addedge(1,2);
            g.addedge(2, 3);
            g.addedge(3, 4);
            g.addedge(1,5);
            g.addedge(5,6);
            g.addedge(6,7);
            g.addedge(5,8);
            g.addedge(1,9);
            g.addedge(9,10);
           
            g.DFS(1);
            
        }
    }
}
