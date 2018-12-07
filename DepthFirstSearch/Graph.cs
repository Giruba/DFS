using System;
using System.Collections.Generic;
using System.Text;

namespace DepthFirstSearch
{
    class Graph
    {
        int noOfVertices;

        int[,] adjacencyMatrix;

        public Graph() { }

        public void SetNoOfVertices(int vertices) {
            noOfVertices = vertices;
        }

        public void SetAdjacencyMatrix(int[,] matrix) {
            adjacencyMatrix = matrix;
        }

        public int GetNoOfVertices() {
            return noOfVertices;
        }

        public int[,] GetAdjacencyMatrix() {
            return adjacencyMatrix;
        }
    }
}
