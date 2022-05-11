
using System.Collections.Generic;
namespace ProblemSet2
{
    class P5
    {
        public static void Main(string[] args)
        {
            solve();
        }

        public static void solve()
        {

            string file = @"C:\Users\anaaf.javed\ProblemSet2\snowflakes.txt";

            string[] lines = File.ReadAllLines(file);
            
            int test = int.Parse(lines[0]);
            int i = 1;
            for (int t = 0; t < test; t++)
            {

                int n = int.Parse(lines[i]);
                i++;
                HashSet<int> hs = new HashSet<int>();
                int range = i + n;
                while(i < range) {
                    hs.Add(int.Parse(lines[i]));
                    i++;
                }
               System.Console.WriteLine(hs.Count);
        }
    }
}
}