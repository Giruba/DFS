using System;

namespace DepthFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DFS Search using adjacency matrix!");
            Console.WriteLine("----------------------------------");
            try
            {
                Graph graph = Utility.GetGraphFromInput();
                if (graph != null && graph.GetAdjacencyMatrix() != null)
                {
                    Console.WriteLine("---The DFS Of the graph is ------");
                    Console.WriteLine();
                    Utility.DFSOfGraph(graph);
                }else {
                    if (graph == null){
                        Console.WriteLine("Graph does not exist!");
                    }
                    else {
                        Console.WriteLine("No adjacency matrix for the Graph!");
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
