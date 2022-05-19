
using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson4_1_CountingElements_FrogRiverOne
{


class Solution {

    public void Test()
    {
        
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

       
        // given x, find the first place in the array where we've sequentially seen all interges between 1 and X
        var result = 0;
        
        var list = A.ToList();
        for(var i = 1; i <= X; i++)
        {
            var index = list.FindIndex( x => x == i);
            log($"Found entry [{i}] at index [{index}]");

            if(index == -1) return -1; // missing element, no path found.
            if(index > result)
            {
                // our final answer will be the largest index we first located our quarry at.
                result = index;
                log($"result set to new index [{index}]");
            }
        }
    
        return result;
    }
}



}

