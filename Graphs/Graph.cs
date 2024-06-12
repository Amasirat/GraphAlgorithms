// public class Graph
// {
//         public Graph(int vertexCount)
//         {
//             adjacencyMatrix = new int[vertexCount, vertexCount];

//             this.vertexCount = vertexCount;
//         }

//         public void AddEdge(int src, int dst, int weight)
//         {
//             if(src >= vertexCount || dst >= vertexCount)
//                 throw new ArgumentOutOfRangeException("The instanciated graph does not contain the given vertices");

//             adjacencyMatrix[src,dst] = weight;
//         }

//         public void AddUndirectedEdge(int src, int dst, int weight)
//         {
//             AddEdge(src, dst, weight);
//             AddEdge(dst, src, weight);
//         }
//         public void Print()
//         {
//             for(int i = 0; i < vertexCount; i++)
//             {
//                 for(int j = 0; j < vertexCount; j++)
//                 {
//                     Console.Write(adjacencyMatrix[i,j]);
//                     Console.Write('\t');
//                 }
//                 Console.Write('\n');
//             }
//         }

//         public Graph KruskalMST()
//         {
//             Graph MST = new Graph(vertexCount);

//             return MST;
//         }

//         private int[,] adjacencyMatrix;
//         private int vertexCount;
//     }
using System.Globalization;

// public class Graph
// {
//     public Graph(int verticesNum)
//     {
//         vertexCount = verticesNum;
//         adjacencyList = new List<List<Node>>();
        
//         for(int i = 0; i < vertexCount; i++)
//         {
//             adjacencyList.Add(new List<Node>());
//             adjacencyList[i].Add(new Node(i, int.MaxValue));
//         }
//     }
//     public void AddEdge(int src, int dst, int weight)
//     {
// // if vertex is not defined
//         if(src > vertexCount || dst > vertexCount)
//             throw new ArgumentOutOfRangeException();
// // unchanged if vertex already exists
//         if(adjacencyList[src].Contains(new Node(dst, weight)))
//             return;

//         adjacencyList[src].Add(new Node(dst, weight));
//     }

//     public void AddUEdge(int v1, int v2, int weight)
//     {
//         AddEdge(v1,v2,weight);
//         AddEdge(v2,v1,weight);
//     }

//     public void RemoveEdge(int src, int dst, int weight)
//     {
//         // if vertex is not defined
//         if(src > vertexCount || dst > vertexCount)
//             throw new ArgumentOutOfRangeException();
//         // unchanged if vertex already exists
//         if(!adjacencyList[src].Contains(new Node(dst, weight)))
//             return;
//         adjacencyList[src].Remove(new Node(dst, weight));
//     }
//     public void RemoveUEdge(int src, int dst, int weight)
//     {
//         RemoveEdge(src, dst, weight);
//         RemoveEdge(dst, src, weight);
//     }
//     public bool CycleExists()
//     {
//         List<bool> visited = new List<bool>(vertexCount);

//         for(int i = 0; i < vertexCount; i++)
//         {
//             visited.Add(false);
//         }

//         for(int i = 0; i < vertexCount; i++)
//         {
//             if(!visited[i])
//             {
//                 if(isCyclic(i, visited, -1))
//                 {
//                     return true;
//                 }
//             }
//         }
//         return false;
//     }
    
//     private bool isCyclic(int vertex, List<bool> visited, int parent)
//     {
//         visited[vertex] = true;

//         foreach(var i in adjacencyList[vertex])
//         {
//             if(!visited[i.Vertex])
//             {
//                 if(isCyclic(i.Vertex, visited, vertex))
//                 {
//                     return true;
//                 }
//             }
//             else if (i.Vertex != parent)
//             {
//                 return true;
//             }
//         }
//         return false;
//     }
//     public void PrintAdjacencyList()
//     {
//         foreach(var i in adjacencyList)
//         {
//             foreach(Node j in i)
//             {
//                 Console.Write($"{j.Vertex} => ");
//             }
//             Console.Write('\n');
//         }
//     }
//     public Graph KruskalMST()
//     {
//         Graph MST = new Graph(vertexCount);
//         List<int> vertexContained = new List<int>();
//         List<List<Node>> newAdjList = adjacencyList;

//         while(vertexContained.Count != vertexCount)
//         {
//             Tuple<int,int,int> edge = FindMinimumEdge(newAdjList);

//             MST.AddUEdge(edge.Item1, edge.Item2, edge.Item3);

//             if(MST.CycleExists())
//             {
//                 MST.RemoveUEdge(edge.Item1, edge.Item2, edge.Item3);
//             }
//             else
//             {
//                 vertexContained.Add(edge.Item1);
//                 vertexContained.Add(edge.Item2);
//             }
//         }

//         return MST;
//     }

//     public Tuple<int,int, int> FindMinimumEdge(List<List<Node>> adjList)
//     {
//         Tuple<int,int, int> edge;

//         Node min = adjList[0][0];
//         int src = 0;

//         int i = 0;
//         while(i < vertexCount)
//         {
//             foreach(var j in adjList[i])
//             {
//                 if(j.Weight < min.Weight)
//                 {
//                     min = j;
//                     src = i;
//                 }
//             }
//             i++;
//         }

//         edge = new Tuple<int, int, int>(src, min.Vertex, min.Weight);
//         return edge;
//     }


//     public struct Node
//     {
//         public Node(int vertex, int weight)
//         {
//             Vertex = vertex;
//             Weight = weight;
//         }
//         public int Vertex{set; get;}
//         public int Weight{set; get;}
//     }
//     public List<List<Node>> adjacencyList;
//     private int vertexCount;
// }

public class Graph {

 
    // Constructor
    public Graph(int v)
    {
        vertexCount = v;
        adjacencyList = new List<List<Node>>(vertexCount);
        for (int i = 0; i < vertexCount; i++)
        {
            adjacencyList.Add(new List<Node>());
        }
    }
 
    public void AddEdge(int src, int dst, int weight)
    {
// if vertex is not defined
        if(src > vertexCount || dst > vertexCount)
            throw new ArgumentOutOfRangeException();
// // unchanged if vertex already exists
//         if(adjacencyList[src].Contains(new Node(dst, weight)))
//             return;

        adjacencyList[src].Add(new Node(dst, weight));
    }

    public void AddUEdge(int v1, int v2, int weight)
    {
        AddEdge(v1,v2,weight);
        AddEdge(v2,v1,weight);
    }
    public void RemoveEdge(int src, int dst, int weight)
    {
        // if vertex is not defined
        if(src > vertexCount || dst > vertexCount)
            throw new ArgumentOutOfRangeException();
        // unchanged if vertex already exists
        if(!adjacencyList[src].Contains(new Node(dst, weight)))
            return;
        adjacencyList[src].Remove(new Node(dst, weight));
    }
    public void RemoveUEdge(int src, int dst, int weight)
    {
        RemoveEdge(src, dst, weight);
        RemoveEdge(dst, src, weight);
    }

    private Boolean isCyclicUtil(int v, Boolean[] visited, int parent)
    {
        visited[v] = true;

        foreach(Node i in adjacencyList[v])
        {

            if (!visited[i.Vertex]) {
                if (isCyclicUtil(i.Vertex, visited, v))
                    return true;
            }

            else if (i.Vertex != parent)
                return true;
        }
        return false;
    }
 
    public Boolean IsCyclic()
    {
        Boolean[] visited = new Boolean[vertexCount];
        for (int i = 0; i < vertexCount; i++)
            visited[i] = false;
 
        for (int u = 0; u < vertexCount; u++)
            if (!visited[u])
                if (isCyclicUtil(u, visited, -1))
                    return true;
 
        return false;
    }

    public Tuple<int,int, int> FindMinimumEdge(List<List<Node>> adjList)
    {
        Tuple<int,int, int> edge;

        Node min = new Node(0,0);

        foreach(var n in adjList)
        {
            foreach(var m in n)
            {
                min = m;
            }
        }

        int src = 0;

        int i = 0;
        while(i < vertexCount)
        {
            foreach(var j in adjList[i])
            {
                if(j.Weight < min.Weight)
                {
                    min = j;
                    src = i;
                }
            }
            i++;
        }

        edge = new Tuple<int, int, int>(src, min.Vertex, min.Weight);
        return edge;
    }

    public Graph KruskalMST()
    {
        Graph MST = new Graph(vertexCount);
        List<int> vertexContained = new List<int>();
        List<List<Node>> newAdjList = adjacencyList;

        while(vertexContained.Count != vertexCount)
        {
            Tuple<int,int,int> edge = FindMinimumEdge(newAdjList);

            MST.AddUEdge(edge.Item1, edge.Item2, edge.Item3);

            if(MST.IsCyclic())
            {
                MST.RemoveUEdge(edge.Item1, edge.Item2, edge.Item3);
                newAdjList[edge.Item1].Remove(new Node(edge.Item2, edge.Item3));
                newAdjList[edge.Item2].Remove(new Node(edge.Item1, edge.Item3));
            }
            else
            {
                if (!vertexContained.Contains(edge.Item1))  
                    vertexContained.Add(edge.Item1);
                if (!vertexContained.Contains(edge.Item2))  
                    vertexContained.Add(edge.Item2);
                newAdjList[edge.Item1].Remove(new Node(edge.Item2, edge.Item3));
                newAdjList[edge.Item2].Remove(new Node(edge.Item1, edge.Item3));
            }
        }

        return MST;
    }

    public void PrintAdjacencyList()
    {
        int counter = 0;
        foreach(var i in adjacencyList)
        {
            Console.Write($"{counter}.");
            foreach(Node j in i)
            {
                Console.Write($"{j.Vertex} => ");
            }
            Console.Write('\n');
            counter++;
        }
    }

    public struct Node
    {
        public Node(int vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
        public int Vertex{set; get;}
        public int Weight{set; get;}
    }
    private int vertexCount;
    public List<List<Node>> adjacencyList;
}