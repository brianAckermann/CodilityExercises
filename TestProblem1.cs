
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace TestProblem1
{


class Solution {

    public void Test()
    {
        var Solution = new TestProblem1.Solution();
                
                string x; 
                String passFail = "";
                 
                x=Solution.solution("hello world!", 10 );
                passFail = x == "hello" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                 
                x=Solution.solution("hello world! Nice to see you today", 15 );
                passFail = x == "hello world!" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution("hello world! Nice to see you today", 12 );
                passFail = x == "hello world!" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution("hello world! Nice to see you today", 11 );
                passFail = x == "hello" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
                x=Solution.solution("hello world! Nice to see you today", 4 );
                passFail = x == "" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
              
                x=Solution.solution("hello world!", 100 );
                passFail = x == "hello world!" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
              
                x=Solution.solution("hello", 5 );
                passFail = x == "hello" ? "PASS" : "FAILED";
                Console.WriteLine($"{ passFail}");
                Console.WriteLine($" ============================================ Next ============================================ ");
                
    }


    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public string solution(string message, int K)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        // find whole words, keeping only under max K chars

        // truncate to K first.. throw away extra processing we don't need.
        // then work backwards to find a space we can clip on.
        // loop backwards over our string to find a space.
        // what if the word we trunctated on was actually a space?
        // K is limited to 500 chars.. lets just deal with that instead of truncating.
 

        log($"orig message [{message}]  [{message.Length}]  [{K}]");
        if(message.Length <= K) {
            log("Message already fits in constraint");
            return message;
        }

        var chars = message.ToCharArray();

        for(var i = chars.Length-1; i > 0; i--)
        { 
            log($"{chars[i]}");
            if(chars[i] == ' ')
            {
                log($"found space at {i}") ;
                // are we still over K?
                if(i > (K) )
                {
                    log($"{i} {K}");
                    continue;
                }
                else
                {
                    message = message.Substring(0,i);
                    log($"trunc message [{message}]");
                    return message;
                }
            }

        }

        log($"trunc message []");
        return ""; // no solution found





    }
}



}

