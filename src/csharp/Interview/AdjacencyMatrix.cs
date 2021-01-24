using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    // https://www.geeksforgeeks.org/implementation-of-bfs-using-adjacency-matrix/
    public class AdjacencyMatrix
    {

        public class Graph
        {

            // Number of vertex
            int v;

            // Number of edges
            int e;

            // Adjacency matrix
            int[,] adj;

            public Graph(int v, int e)
            {
                this.v = v;
                this.e = e;

                this.adj = new int[v, v];
                for (int row = 0; row < v; row++)
                    for (int column = 0; column < v; column++)
                        adj[row, column] = 0;
            }

            public void AddEdge(int start, int e)
            {
                // Considering a bidirectional edge
                adj[start, e] = 1;
                adj[e, start] = 1;
            }

            // Function to perform BFS on the graph
            public void BFS(int start)
            {
                var visited = new bool[this.v];

                var nodes = new Queue<int>();
                nodes.Enqueue(start);
                visited[start] = true;

                while (nodes.Count > 0)
                {
                    var current = nodes.Dequeue();
                    Console.WriteLine(current + " ");

                    for (int i = 0; i < this.v; i++)
                    {
                        if(adj[current, i] == 1 && !visited[i])
                        {
                            nodes.Enqueue(i);
                            visited[i] = true;
                        }
                    }
                }
            }

        }



    }
}
