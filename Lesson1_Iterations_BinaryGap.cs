using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson1_Iterations_BinaryGap
{
class Solution {

    public void Test()
    {
        
            if(true) 
            {

                var Solution = new Lesson1_Iterations_BinaryGap.Solution();

                var x=Solution.solution(8);
                Console.WriteLine($"solution.solution == {x} ");
                x=Solution.solution(1024);
                Console.WriteLine($"solution.solution == {x} ");
                x=Solution.solution(1041);
                Console.WriteLine($"solution.solution == {x} ");
            
            }
    }

    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Console.WriteLine($"inside solution.solution input param {N}");

        var b = Convert.ToString(N, 2);
        Console.WriteLine($"inside solution.solution convert to bool {b}");

        // take string convert to array
        var a = b.ToCharArray();

        // setup
        var zeros = 0;
        var maxZeros = 0;

        // iterate over a
        foreach(char c in a)
        {
            if( c == '1') 
            {
                if ( maxZeros < zeros ) maxZeros = zeros;
                zeros = 0;
                continue;
            }

            zeros++;
        }

        return maxZeros;
    }
}

}