
using System.Collections.Generic;
namespace ProblemSet2
{
    class P2
    {
        public static void Main(string[] args)
        {
            solve();
        }

        // Number System
        public static void solve()
        {

            string file = @"C:\Users\anaaf.javed\problemSet2\p2.txt";

            string[] lines = File.ReadAllLines(file);
            int t = 0;
            int test = int.Parse(lines[t]);
            t++;

            for (int i = 0; i < test; i++)
            {
                string[] line = lines[t].Split(" ");
                t++;
               int source = int.Parse(line[0]);
               int target = int.Parse(line[1]);
               int num = int.Parse(line[2]);

                int temp = toDecimal(source , num);
            
            int res = decimalToTarget(target, temp);

            System.Console.WriteLine(res);
            
            }

        
        }

        // first convert source system to decimal system
        public static int toDecimal(int source,  int num) {

            string str = num.ToString();
            int size = str.Length - 1;
            int res = 0;
            int i = 0;
            while(size >= 0) {
            int r =  (int)Char.GetNumericValue(str[i]);;
            res = res + ((r) * (int) Math.Pow(source, size));
             size --;
             i++;
            }     
            return res;
        }

        // converting the result from decimal to target system 
        public static int decimalToTarget(int target,  int decimalVersion) {
        
            Stack<int> res = new Stack<int>();

            int num = decimalVersion;

            while(num >= 1) {
                int rem = num % target;
                res.Push(rem);
                num = num / target;
            }

            string outp = "";

           while(res.Count() > 0) {
                int pop = res.Pop();
                outp = outp + pop.ToString();
            }

           

            return int.Parse(outp);
        }
    }
}