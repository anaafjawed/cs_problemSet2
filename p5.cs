
using System.Collections.Generic;
namespace problemSet2
{
    class P5
    {

        // Snowflakes 
        public void solve()
        {

            string file = @"C:\Users\anaaf.javed\ProblemSet2\snowflakes.txt";

            string[] lines = File.ReadAllLines(file);
            
            int test = Int32.Parse(lines[0]);
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