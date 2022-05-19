using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson3_3_TimeComplexity_TapeEquilibrium
{


class Solution {

    public void Test()
    {


            if(true)
            {

                
                var Solution = new Lesson3_3_TimeComplexity_TapeEquilibrium.Solution();
                
                int x; 
                String passFail = "";

                
                x=Solution.solution(new int[] { 1,1,1,1,1,1} );
                passFail = x == 0 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                
                x=Solution.solution(new int[] { 1,2,-1,1,-10,8} );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                

                x=Solution.solution(new int[] { 3,1,2,4,3} );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");


                
                
                x=Solution.solution(new int[] { -999,3,1,2,4,3, -999, 888} );
                passFail = x == 875 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                
                
                x=Solution.solution(new int[] { -1000,1000} );
                passFail = x == 2000 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
            }
  
    }


    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public int solution(int[] A) {    
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        // 38% https://app.codility.com/demo/results/trainingDMP2ZC-S92/
        // 100% https://app.codility.com/demo/results/trainingWVNRHT-986/
        
        // find the smallest "difference" between the sum of the left hand side and the right hand side.

        // - because of negative numbers, we we can't just use one side or the other, have to calculate all possibilities, then choose the best :\

        var smallest = Int32.MaxValue; 
        log($"Smallest: {smallest}");

        //// test for every slot in the array
        //for(var i = 1; i <= A.Length-1; i++)
        //{
        //    // sort into L & R sides....
        //    var L = A.Take(i);
        //    var R = A.Skip(i).Take(A.Length - i);
        //
        //    var diff = Math.Abs(L.Sum() - R.Sum());
        //    log($"Diff: [{diff}]   Sum L = {L.Sum()} ... Sum R = {R.Sum()}");
        //    
        //    if(diff<smallest) 
        //    { 
        //        smallest = diff;
        //        log($"new smallest: {smallest}");
        //    }
        //}

        // above code is too slow... trying to optimize
        // take sums only once, then add and subtract values as we scan from left to right.
        // O(2N)?

        // initial setup...
        var L = 0;
        var R = A.Sum();

        // move an element from right half, to left..
        for(var i = 0; i < A.Length-1; i++)
        {
            
            L += A[i];
            R -= A[i];

            var diff = Math.Abs(L - R);
            log($"Diff: [{diff}]   Sum L = {L} ... Sum R = {R}");

            if(diff<smallest) 
            { 
                smallest = diff;
                log($"new smallest: {smallest}");
            }
        }


        return smallest;
    }
}



}