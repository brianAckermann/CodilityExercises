
using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson4_1_CountingElements_FrogRiverOne_v3
{


class Solution {

    public void Test()
    {

            if(true)
            {        
                var Solution = new Lesson4_1_CountingElements_FrogRiverOne_v3.Solution();
                
                int x; 
                String passFail = "";

                
 
                x=Solution.solution(5, new int[] { 1,2,3,4,5} );
                passFail = x == 4 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution(5, new int[] { 1,2,3,3,5} );
                passFail = x == -1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution(5, new int[] { 1,3,1,4,2,3,5,4} );
                passFail = x == 6 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution(1, new int[] { 1} );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
            }
        
    }


    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public int solution(int X, int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        // 27%  - https://app.codility.com/demo/results/trainingTN2PFD-YDE/
        // 54%  - https://app.codility.com/demo/results/trainingR5VYKE-4RG/
        // 81%  - https://app.codility.com/demo/results/training9NZF2B-6HT/
        // 100% - https://app.codility.com/demo/results/trainingGSYAWC-HR4/

       
        // given x, find the first place in the array where we've sequentially seen all interges between 1 and X
        // don't use a "find" methodology... gotta do it all in a single pass.
        // create dictionary matching our X's
        // iterate over main array.
        // check dictionary to see if we have the value already.. if not update
        // at end, check dictionary size, if less than X return -1
        // return MAX value

        var dict = new Dictionary<int, int>();
        for(var i = 0; i < A.Length; i++)
        {
            if(dict.ContainsKey(A[i])) continue;

            dict.Add(A[i], i);
            log($"Found [{A[i]}] at location [{i}]");
        }

        if(dict.Count < X) return -1; // not all locations represented.

        return dict.Values.Max(); // biggest value is the earliest full path opportunity.
    }
}



}

