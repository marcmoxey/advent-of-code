using System;
using FileUtils;

namespace RedNosedReports;
class Program
{
    static void Main(string[] args)
    { 
        string filePath = @"/Users/marcmoxey/Repo/advent-of-code/2024/02Day/RedNosedReports/input.txt";

        /*
            The levels are either all increasing or all decreasing.
        
             Any two adjacent levels differ by at least one and at most three.
        
        */

        var levels = FileUtils.FileUtils.ReadFile(filePath);
        
        for (int i = 0; i < levels.Length; i++)
        {
            
        }
    
        


        System.Console.WriteLine("DONE!");
        Console.ReadLine();
    }
}
