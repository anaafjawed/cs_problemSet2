using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet2
{
    class P3
    {
        public static void solve()
        {


            string file = @"C:\Users\anaaf.javed\ProblemSet2\p3.txt";

            string[] lines = File.ReadAllLines(file);
            int g = 0;
            int test = int.Parse(lines[g++]);

            for (int t = 0; t < test; t++)
            {
                string[] str = lines[g++].Split(" "); // reading line 1

                int vertices = int.Parse(str[0]);
                int edges = int.Parse(str[1]);
                int inf = 1000000000;

                int[,] adjacencyMat = new int[vertices, vertices];

                int[,] copy_adjMat = new int[vertices, vertices];

                for (int k = 0; k < edges; k++)
                {

                    string[] str1 = lines[g++].Split(" ");
                    int i = int.Parse(str1[0]);
                    int j = int.Parse(str1[1]);
                    int weight = int.Parse(str1[2]);
                    adjacencyMat[i, j] = weight;
                }

                for (int i = 0; i < adjacencyMat.GetLength(0); i++)
                {
                    for (int j = 0; j < adjacencyMat.GetLength(1); j++)
                    {
                        if (adjacencyMat[i, j] == 0)
                        {
                            copy_adjMat[i, j] = inf;
                        }
                        else
                        {
                            copy_adjMat[i, j] = adjacencyMat[i, j];
                        }
                    }
                }

                int current = 0;
                int v_store = int.Parse(lines[g++]);
                int dis = 0;
                int node;



                // finding the shortest path of all the possible pairs


                for (int k = 0; k < vertices; k++)
                {

                    for (int i = 0; i < vertices; i++)
                    {
                        for (int j = 0; j < vertices; j++)
                        {

                            copy_adjMat[i, j] = Math.Min(copy_adjMat[i, j], copy_adjMat[i, k] + copy_adjMat[k, j]);

                        }
                    }

                }



                // finding the desired shortest path

                for (int l = 0; l < v_store; l++)
                {
                    node = int.Parse(lines[g++]);
                    dis += copy_adjMat[current, node];
                    current = node;
                }

                dis += copy_adjMat[current, 0];

                Console.WriteLine(dis);




            }
        }

    }
}