using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson2_Arrays_OddOccurrencesInArray
{


class Solution {

    public void Test()
    {            
     
            if(true) 
            {

                var Solution = new Lesson2_Arrays_OddOccurrencesInArray.Solution();
                
                int x; 
                String passFail = "";

                x=Solution.solution(new int[] { 1 } );
                passFail = x == 1 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(new int[] { 1,2,3 ,1,2} );
                passFail = x == 3 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(new int[] { 1 ,1,2,1,2,3,1} );
                passFail = x == 3 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution(new int[] { 1 ,2,3,4,5,5,4,3,2,1,6,7,8,9,0,0,9,8,7,6,5} );
                passFail = x == 5 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution(new int[] { 1 ,2,3,4,5,4,3,2,1,6,7,8,9,0,0,9,8,7,6,1,2,3,4,4,3,2,1,5,55,55,99,1,1,2,2,3,2,3,2} );
                passFail = x == 99 ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");

                x=Solution.solution(new int[] { 1 ,2,1} );
                passFail = x == 2 ? "PASS" : "FAILED";
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
       log($"inside solution.solution input param [{string.Join(" , ", A)}]");

        // iterate over entire list,
        // for each item, add counter to dictionary <int Key, int count>
        // loop over dictionary until we find an odd entry.

        var lenA = A.Length;
       log($"lenA [{lenA}]");

        var dict = new Dictionary<int, int>();

        foreach(int i in A)
        {
            if(dict.ContainsKey(i))
            {
               log($"HAS KEY [{i}]");
                dict[i]++;
            }
            else
            {
               // Console.WriteLine($"CREATING KEY [{i}]");
                dict.Add(i, 1);
            }

        }
          
        // iterate over dict to find odd entry
        foreach(var k in dict)
        {
           log($" KEY [{k}]  VALUE [{dict[k.Key]}]   mod [{ k.Value % 2 }]");
        }
        
      // iterate over dict to find odd entry
        foreach(var k in dict)
        {
            if(k.Value % 2 == 1) 
            {
                
               log($"RESULT [{k.Key}]]");
                return k.Key;
            }
        }
        


        // something went wrong .. shouldn't get here if initial dataset was right.
       log($"RESULT 0");
        return 0;
    }
}



}