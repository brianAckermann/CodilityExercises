using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Lesson4_3_CountingElements_MaxCounters
{


class Solution {

    public void Test()
    {

        Stopwatch sw = new Stopwatch();
            
        if(true)
        {        
            Console.WriteLine($"=== Sandbox Test Execution ===");


            // var Solution = new Solution();
            
            string result;
            int[] interimResult; 
            string expected;
            String passFail = "FAILED"; 


            sw.Start();
            interimResult = solution( 5, new int[] { 3,4,4,6,1,4,4} );
            sw.Stop();
            Console.WriteLine("ElapsedTime={0}",sw.Elapsed);

            result = (String.Join(",", interimResult));
            expected = "3,2,2,4,2";
            if(result == expected) passFail = "PASS";
            Console.WriteLine($"result  : [{result}]");
            Console.WriteLine($"expected: [{expected}]");
            Console.WriteLine($"TEST:   {passFail}");
            Console.WriteLine($" ============================================ Next ============================================ ");
            



            
            sw.Start();
            interimResult = solution( 5, new int[] { 1,2,3,4,5,6} );
            sw.Stop();
            Console.WriteLine("ElapsedTime={0}",sw.Elapsed);

            result = (String.Join(",", interimResult));
            expected = "1,1,1,1,1";
            if(result == expected) passFail = "PASS";
            Console.WriteLine($"result  : [{result}]");
            Console.WriteLine($"expected: [{expected}]");
            Console.WriteLine($"TEST:   {passFail}");
            Console.WriteLine($" ============================================ Next ============================================ ");

            sw.Start();
            interimResult = solution( 5, new int[] { 1,2,3,4,5,5,6} );
            sw.Stop();
            Console.WriteLine("ElapsedTime={0}",sw.Elapsed);

            result = (String.Join(",", interimResult));
            expected = "1,1,1,1,1";
            if(result == expected) passFail = "PASS";
            Console.WriteLine($"result  : [{result}]");
            Console.WriteLine($"expected: [{expected}]");
            Console.WriteLine($"TEST:   {passFail}");
            Console.WriteLine($" ============================================ Next ============================================ ");

            
            return;
        }
            

    }

    

    public static bool LOGGING = false;

    /// call this as a lambda to defer the logging until possibly never if we comment out the action
    /// like this:        LazyLog( () => {  Console.WriteLine($"foobarblah");}  );
    /// the anonymous function will be created, but not executed, so if we are processing large arrays/dicts/etc into text to be written out to logs,
    /// we won't spend time on it if we decide not to execute later on.
    public static void LazyLog(Action action)
    {
        if(LOGGING) {
            action();
        }
    }
 


    public int[] solution(int N, int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        // create new array of length N
        // for each item in A, increment the counter in newArray if the value is between 1 and N inclusive
        // otherwise, set all counters to the maximum value currently in the newArray.

        var newArray = new  List<int> (new int[N]);
        var maxCounter = 0;
        var baseValue = 0;

        LazyLog( () => { Console.WriteLine(String.Join(",", A));   }  );
        LazyLog( () => { Console.WriteLine(String.Join(",", newArray));    }  );        
        LazyLog( () => { Console.WriteLine("----");  }  );

        foreach(var i in A)
        {

            var element = i - 1;
            
            LazyLog( () => { Console.WriteLine($"placing {i}");   }  );
            if(i <= N)
            {
                if(newArray[element] < baseValue)
                {
                    LazyLog( () => { Console.WriteLine($"setting new baseValue for element {i} to {baseValue}");  }  );
                    newArray[element] = baseValue;
                }

                
                LazyLog( () => { Console.WriteLine($"element {i} was {newArray[element]}");  }  );
                newArray[element] += 1;
                
                LazyLog( () => { Console.WriteLine($"element {i} is {newArray[element]}");  }  );
                if(newArray[element] > maxCounter) 
                {
                    maxCounter++;
                    
                    LazyLog( () => { Console.WriteLine($"upgrading maxCounter to {maxCounter}");  }  );
                } 
            } 
            else
            {
                // handle N+1 case
                // set all values of newArray to maxCounter
                // this solution is bad, as it happens every time we have a maxCounter op,
                // a better solution (which I didn't think of) is to store the current "base"
                // and add that to the incrementor calculation above
                //for(var j = 0; j < N; j++)
                //{
                //    newArray[j] = maxCounter;
                //}
                
                LazyLog( () => { Console.WriteLine($"upgrading baseValue to {maxCounter}");   }  );
                baseValue = maxCounter;
            }



            LazyLog( () => { Console.WriteLine(String.Join(",", newArray));}  );
            
            LazyLog( () => { Console.WriteLine("----");   }  );
            
        }


        // because we don't ALWAYS upgrade the baseValue, we have to iterate through newArray once, to make sure everybody is at LEAST at the base.
        for(var j = 0; j < N; j++)
        {
            if(newArray[j] < baseValue)
            {
                LazyLog( () => { Console.WriteLine($"setting new baseValue for element {j+1} to {baseValue}");  }  );
                
                newArray[j] = baseValue;
            }
        }
        
        return newArray.ToArray();
    }
}



}

