
using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace TestProblem2
{


class Solution {

    public void Test()
    {
        var Solution = new TestProblem2.Solution();
        
        int x; 
        String passFail = ""; 


        x=Solution.solution(5, new int[] { 1,2,3,4,5} );
        passFail = x == 4 ? "PASS" : "FAILED";
        Console.WriteLine($"{ passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        
    }

    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public int solution(int X, int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        return 0;
    }
}



}

