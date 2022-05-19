
using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson4_2_CountingElements_IsAPermutation
{


class Solution {

    public void Test()
    {

            
            if(true)
            {        
                var Solution = new Lesson4_2_CountingElements_IsAPermutation.Solution();
                
                int x; 
                String passFail = "";

                 
                x=Solution.solution( new int[] { 10} );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution( new int[] { 1 } );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                

                x=Solution.solution( new int[] { 1000000000 } );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution( new int[] { 2,1,3,4} );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution( new int[] { 1,10} );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                

                x=Solution.solution( new int[] { 2,5,1,3, 5, 4} );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
     
            }
            

    }

    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public int solution(int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        // figure out if array has all  (and only) numbers in the sequence 1...N 
        //var result = 0;

        var len = A.Length;

        //iterate over array, stuffing items into hashset
        // if we ever find a duplicate, just quit.. its not a perm.
        // if we finish loading without dupes, then we need to sort the array, and
        //   traverse, checking to see that our next value matches what it should be.

        var H = new HashSet<int>();
        foreach(int i in A)
        {
            H.Add(i);
        }

        if(H.Count != len)  
        {
            log("hash wrong len; abort!");
            return 0;
        }

        var L = A.ToList();
        L.Sort();

        int checker = 1;
        foreach(int i in L)
        {
            log($"checking {i} --  checker {checker}");
            if (checker != i) 
            {
                log("wrong int; abort!");
                return 0;
            }
            checker++; 
        }
        
   
        // if we make it to the end, we've got a good one.
        return 1;
    }
}



}

