using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson3_2_TimeComplexity_PermMissingElements
{


class Solution {

    public void Test()
    {
             

            if(true)
            {
                
                var Solution = new Lesson3_2_TimeComplexity_PermMissingElements.Solution();
                
                int x; 
                String passFail = "";

                
                x=Solution.solution(new int[] { 1,2,3 ,5,6} );
                passFail = x == 4 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(new int[] { 6,2,1 ,5, 3} );
                passFail = x == 4 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(new int[] { 4,6,2 ,5, 3} );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                
                x=Solution.solution(new int[] {  } );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");


                x=Solution.solution(new int[] { 1 } );
                passFail = x == 2 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(new int[] { 2 } );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");


                x=Solution.solution(new int[] { 2,1,3,4 } );
                passFail = x == 5 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

            }

    }


    public void log(string l)
    {
        //Console.WriteLine(l);
    }


    public int solution(int[] A) {    
        // write your code in C# 6.0 with .NET 4.5 (Mono)


        // test for starting edge cases:
        if(A.Length == 0) 
        {
            return 1;
            
        }

        if(A.Length == 1)
        {
            
            if(A[0] == 1) return 2;
            //if(A[0] == 2) return 1; //normal handling already handles this outcome
        }

        // examine the array and find out what we're missing... 
        // how?
        // organize the list
        var list = A.ToList();
        list.Sort();

        // now we can iterate over the list, looking for the broken one..

        // that won't help us on super big arrays, we'll run out of time.. need another idea .. binary search?

        int c = 1;
        foreach(var i in list)
        {
            if(c==i) 
            {
                c++;  
                continue;
            }

            return c;


        }


       
        return c;
     
    }
}



}