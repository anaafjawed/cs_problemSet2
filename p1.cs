
using System.Collections.Generic;
namespace ProblemSet2
{
    class P1
    {
        public static void Main(string[] args)
        {
            solve();
        }

        public static void solve()
        {

            string file = @"C:\Users\anaaf.javed\ProblemSet2\olddata.txt";

            string[] lines = File.ReadAllLines(file);
            
            int id_Count = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(" "); // spliting each line in to string array, seperate words
                
                Boolean isId = false;
                
                if(line[0].Length == 6) {
                     isId = true;
                    string str = line[0];
                    for(int j = 0; j < line[0].Length; j++) {
                        char c = str[j]; 
                        if(!Char.IsDigit(c)) {
                           isId = false;
                        }
                    }
                }

                if(isId) {
                    id_Count++;
                }   
            }

            System.Console.WriteLine(id_Count);
        }
    }
}