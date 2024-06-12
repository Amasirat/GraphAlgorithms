using System.ComponentModel.DataAnnotations;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Graph graph = new Graph(6);

            graph.AddUEdge(0,1,1);
            graph.AddUEdge(1,2,3);
            graph.AddUEdge(2,5,4);
            graph.AddUEdge(0,3,4);
            graph.AddUEdge(1,4,3);
            graph.AddUEdge(2,3,2);
            graph.AddUEdge(3,5,5);
            graph.AddUEdge(3,4,2);
            graph.AddUEdge(4,5,7);

            Graph mst = graph.KruskalMST();

            mst.PrintAdjacencyList();
        }
    }
}


