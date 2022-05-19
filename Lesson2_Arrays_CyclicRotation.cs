using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson2_Arrays_CyclicRotation
{


class Solution {

    public void Test()
    {
        
            if(true) 
            {

                var Solution = new Lesson2_Arrays_CyclicRotation.Solution();

                var x=Solution.solution(new int[] { 1, 3, 5, 7, 9 } , 0);
                Console.WriteLine($"=== Next===");
                x=Solution.solution(new int[] { 1, 3, 5, 7, 9 } , 1);
                Console.WriteLine($"=== Next===");
                x=Solution.solution(new int[] { 1, 3, 5, 7, 9 } , 2);
                Console.WriteLine($"=== Next===");
                x=Solution.solution(new int[] { 1, 3, 5, 7, 9 } , 3);
                Console.WriteLine($"=== Next===");
                x=Solution.solution(new int[] { 1, 3, 5, 7, 9 } , 4);
                Console.WriteLine($"=== Next===");
                x=Solution.solution(new int[] { 1, 3, 5, 7, 9 } , 5);
                Console.WriteLine($"=== Next===");

                x=Solution.solution(new int[] { 5, -1000 } , 1);
                Console.WriteLine($"=== Next===");
            
                x=Solution.solution(new int[] {  } , 1);
                Console.WriteLine($"=== Next===");
            }
    }

    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Console.WriteLine($"inside solution.solution input param [{string.Join(" , ", A)}], [{K}]");

        if(A.Length==0) return A;
        // problems if we flip longer than our array length?
        //   we could iterate and do one rotation at a time.
        //   no... just calc the final rotation.. 15char @ 32 rotations  == 2
        K = K % A.Length; 
        Console.WriteLine($" K == [{K}]");

        if(K == 0) return A;


        // move array element to new array.
        var N = new int[A.Length+K];

        
        Console.WriteLine($" A Length [{A.Length}]");
        Console.WriteLine($" [{string.Join(" , ", A)}]");

        Console.WriteLine($"\n N Length [{N.Length}]");

        A.CopyTo(N,K);

        Console.WriteLine($" [{string.Join(" , ", N)}]");
        // thats the majority of the work, now lets flip the edges...
        

        for(var i = 0; i < K; i++)
        {
            Console.WriteLine($"\n\n {i}");
            //N[i] = A[i + K-1];
            N[i] = N[A.Length + i];
            Console.WriteLine($"\t [{string.Join(" , ", N)}]");

        }

        Console.WriteLine($"  -- and cleanup --");

        // and now just delete the K extra bits at the end.
        var s = N.ToList();
        s.RemoveRange(A.Length,K);
        N = s.ToArray();
  
        Console.WriteLine($"inside solution.solution RESULT [{string.Join(" , ", N)}], [{K}]");
        return N;
    }
}



}