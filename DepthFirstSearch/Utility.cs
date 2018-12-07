using System;
using System.Collections.Generic;
using System.Text;

namespace DepthFirstSearch
{
    class Utility
    {
        public static Graph GetGraphFromInput() {
            Graph graph = null;

            Console.WriteLine("Enter the number of vertices in the graph");
            try
            {
                int vertices = int.Parse(Console.ReadLine());
                graph = new Graph();
                graph.SetNoOfVertices(vertices);
                int[,] matrix = new int[vertices, vertices];
                Console.WriteLine("Enter the rows of the adjacency matrix one by one");
                for (int i = 0; i < vertices; i++) {
                    Console.WriteLine("Enter the elements of row "+ i +"separated by space");
                    String[] elements = Console.ReadLine().Split(' ');
                    for (int j = 0; j < vertices; j++) {
                        matrix[i, j] = int.Parse(elements[j]);
                    }
                }
                if (isAdjacencyMatrix(matrix))
                {
                    graph.SetAdjacencyMatrix(matrix);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            
            Console.WriteLine();
            return graph;
        }


        private static bool isAdjacencyMatrix(int[,] matrix) {

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    bool num1 = matrix[i, j] != 0;
                    bool num2 = matrix[i, j] != 1;
                    if ((matrix[i, j] != 0) && (matrix[i, j] != 1)) {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void DFSOfGraph(Graph graph) {
            int dimension = graph.GetNoOfVertices();
            bool[] visited = new bool[dimension];
            visited[0] = true;
            DFSUtil(0, visited, graph);
        }

        private static void DFSUtil(int startVertex, bool[] visisted, Graph graph) {
            if (graph != null && graph.GetAdjacencyMatrix() != null)
            {
                Console.Write(startVertex + "->");
                int[,] matrix = graph.GetAdjacencyMatrix();
                for (int i = 0; i < graph.GetNoOfVertices(); i++)
                {
                    if (startVertex != i && matrix[startVertex, i] == 1
                        && visisted[i] == false)
                    {
                        visisted[i] = true;
                        DFSUtil(i, visisted, graph);
                    }
                }
            }
        }

    }
}
