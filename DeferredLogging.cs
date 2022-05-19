
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");



namespace DeferredLogging
{


class Solution {

    public void Test()
    {

        Console.WriteLine($"=== Sandbox Test Execution ===");

        Stopwatch sw = new Stopwatch();

        
        string result; 
        String passFail = "FAILED"; 


        sw.Start();
        result = solution( new int[] { 1,2,8,15,55} );
        sw.Stop();
        Console.WriteLine("ElapsedTime={0}",sw.Elapsed);

        Console.WriteLine($"result: {result}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        


        return;
    }

    public void log(string l)
    {
       Console.WriteLine(l);
    }

    public static void LazyLog(Action action)
    {
        //action();
    }


    public string solution(int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        LazyLog( () => {  log($"foobarblah");}  );


        // lets build a pretty big array
        var X = new int[10000];
        
        
        for(var i = 1; i < 1000; i++) 
        {
            LazyLog( () => {  log(String.Join(",", X));     }  );
            
        }


        // figure out if array has all  (and only) numbers in the sequence 1...N 
        var result = "0";
        return result;
    }
}



}

