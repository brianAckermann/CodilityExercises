
using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace TestProblem3
{


class Solution {

    public void Test()
    {        
        var Solution = new  TestProblem3.Solution();
        
        int x; 
        String passFail = "";

            
        x=Solution.solution( new int[] { 5,19,8,1} );
        passFail = x == 3 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        
        x=Solution.solution( new int[] { 10,10} );
        passFail = x == 2 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        
        x=Solution.solution( new int[] { 800, 0, 10} );
        passFail = x == 2 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
    
        x=Solution.solution( new int[] { 400, 401} );
        passFail = x == 2 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
    
        x=Solution.solution( new int[] { 400, 1,1,1,1,1,1,1,50} );
        passFail = x == 2 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
    
        x=Solution.solution( new int[] { 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 0} );
        passFail = x == 9 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
    
    
    }


    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public int solution(int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        // tally overall pollution and id halfway marker.

        // Do we need to convert to doubles?
        double[] D = Array.ConvertAll(A, x => (double)x);

        var totalP = D.Sum();
        var currentP = totalP;
        var targetP = totalP/2.0;
        var filtersApplied = 0;

        
        log($"Starting pollution level is [{currentP}] -- target is [{targetP}]");
        // so, our approach here is to iterate over the list of polluters, find the max polluter, apply a filter to it
        // and carry on until we're under our target.
        // this may not be ideally optimized, but we'll improve it iteratively as we're able.
        while(currentP > targetP)
        {
            // how to find the max?
            var maxIndex = getMaxIndex(D);
            
            // apply the fiter
            D[maxIndex] = D[maxIndex]/2.0; 
            filtersApplied++;

            // recalculate
            currentP = D.Sum();
            log($"New pollution level is [{currentP}]");
        }


        return filtersApplied ;
    }

    public int getMaxIndex(double [] D)
    {
        var maxValue = D[0];
        var maxIndex = 0;
                
        log($"found new maxIndex at 0 -- {D[0]}");

        for (var i=1; i < D.Length; i++)
        {    
            if(D[i] > maxValue) {
                
                log($"found new maxIndex at {i} -- {D[i]}");
                maxIndex = i;
                maxValue = D[i];
            }
            else
            {
                log($"TOO SMALL at index {i} -- {D[i]}");
            }
        }

   
        log($"current maxIndex at {maxIndex} ");
        return maxIndex;
    }
}



}

