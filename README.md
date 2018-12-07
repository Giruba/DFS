
Author: Giruba Beulah SE

# DFS
C# program for DFS with the graph using the adjacency matrix

Logic/Algorithm
---------------
1. Initialize the bool array visited which will be used for avoiding loop of visting the same vertex again and getting struck

2. Call the recursive DFSUtil with the start vertex, visited matrix and the adjacency matrix

   2.a Mark the start vertex visited and print it
   
   2.b Loop over all adjacenct vertices such that
   
      2.b.1 A) If the current vertex is not equal to the start vertex, B) if both the start vertex and current vertex are adjacent
            C) If current vertex is not visited, then
            
            2.b.1.1 Mark the current vertex as visited and call DFSUtil with start vertex as current vextex
