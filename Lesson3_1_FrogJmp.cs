using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson3_1_FrogJmp
{


class Solution {

    public void Test()
    {
                 

            if(true)
            {

                var Solution = new Lesson3_1_FrogJmp.Solution();
                
                int x; 
                String passFail = "";

                x=Solution.solution(10,85,30);
                passFail = x == 3 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(5,85,10);
                passFail = x == 8 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(5,999999999,10000);
                passFail = x == 100000 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(5,5,10000);
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");



            }
        
    }


    public void log(string l)
    {
        //Console.WriteLine(l);
    }


    public int solution(int X, int Y, int D) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        log($"input param X[{X}], Y[{Y}], D[{D}]");

        if(X==Y) return 0; // fella's already there!

        var dist = Y-X;
        log($"dist[{dist}]");

        var x = dist/(0.00 + D);
        log($"x[{x}]");

        var leaps = (int)Math.Ceiling(x);

        log($"leaps[{leaps}]");
        return leaps;
    }
}



}