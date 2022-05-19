
using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");



namespace Sandbox
{


class Solution {

    public void Test()
    {

        Console.WriteLine($"=== Sandbox Test Execution ===");


       // var Solution = new Solution();
        
        string result; 
        String passFail = "FAILED"; 


        result = solution( new int[] { 1,2,8,15,55} );
        
        Console.WriteLine($"result: {result}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        


        return;
    }

    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public string solution(int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        // figure out if array has all  (and only) numbers in the sequence 1...N 
        var result = "0";
        return result;
    }
}



}

