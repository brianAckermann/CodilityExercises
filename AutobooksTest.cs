
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");



namespace AutobooksTest
{


class Solution {

    public void Test()
    {

        Console.WriteLine($"=== Sandbox Test Execution ===");


       // var Solution = new Solution();
        
        string result; 
        string expected;
        String passFail = "FAILED"; 


        result = solution( new int[] { 1,2,8,15,16,18,55,97, 98} );
        expected = "3-7,9-14,17,19-54,56-96,99";
        if(result == expected) passFail = "PASS";
        Console.WriteLine($"result: {result}");
        Console.WriteLine($"expected: {expected}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        

        result = solution( new int[] { 2,3,5,8} );
        expected = "1,4,6-7,9-99";
        if(result == expected) passFail = "PASS";
        Console.WriteLine($"result: {result}");
        Console.WriteLine($"expected: {expected}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        

        result = solution( new int[] { 1} );
        expected = "2-99";
        if(result == expected) passFail = "PASS";
        Console.WriteLine($"result: {result}");
        Console.WriteLine($"expected: {expected}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        
   
        result = solution( new int[] {} );
        expected = "1-99";
        if(result == expected) passFail = "PASS";
        Console.WriteLine($"result: {result}");
        Console.WriteLine($"expected: {expected}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        

        result = solution( new int[] {98} );
        expected = "1-97,99";
        if(result == expected) passFail = "PASS";
        Console.WriteLine($"result: {result}");
        Console.WriteLine($"expected: {expected}");
        Console.WriteLine($"TEST:   {passFail}");
        Console.WriteLine($" ============================================ Next ============================================ ");
        
        return;
    }

    public void log(string l)
    {
       Console.WriteLine(l);
    }


    public string solution(int[] A) //v3 
    {
        var list = A.ToList(); // initial array converted to a list for ease of use
        list.Insert(0, 0);     // add edge buffer to beginning of list
        list.Add(100);         // add edge buffer to end of list

        
        var ranges = new List<string>();

        // now we should just be able to loop over each pair of numbers and 
        // generate a range for any that are separated by more then one
        for(var i = 0; i < list.Count-1; i++)
        {
            var startRange = list[i];
            var endRange = list[i+1];
            
            if (endRange-startRange > 1)
            {
                var range = genRange(startRange+1,endRange-1) ;
                ranges.Add(range);
                log($" found range @ {i} -- {range}");

            }
        }

        var result = string.Join(",",ranges);
        
        log(result);
        return result;
    }

    public string solution2(int[] A)  //v2
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        // return a string showing all the missing numbers in A (can assume its already sorted) as ranges
        // [2,3,5,8] ==> "1,4,6-7,9-99"
        // [1] ==> "2-99"
        // [] ==> "1-99"
        // [98] ==> "1-97,99"

        // HACK... append a 100 to end of provided list to better deal with end edge conditions.
        var list = A.ToList();
        list.Append(100);

        var ranges = new List<string>();
        
        // lets merge the arrays into one ... dictionary.
        var dict = new Dictionary<int,int>();

        //load with default "NO" values for everything.
        for(var i = 1; i <= 99; i++)
        {
            dict.Add(i, 0);
        }

        // now, lets override with the values we recieved as input
        foreach(var i in list)
        {
            log($"adding known - {i}");
            dict[i] = 1;
        }

        //log(string.Join(Environment.NewLine, dict.Select(kvp => $"{kvp.Key}:{kvp.Value}")));

        // now, hopefully, its simply as easy as reading out the dict.
        var startRange = 1;
        for(var i = 1; i <= 99; i++)
        {
            //log($"## iteration:{i} -- startRange:{startRange}");
            if(dict[i] == 1) 
            {   // complete the range
                if(startRange==i) 
                {
                    log($" found FALSE range @ {i}");
                    startRange = i+1;
                    continue; // no range to add
                }
                var range = genRange(startRange,i-1) ;
                ranges.Add(range);
                log($" found range @ {i} -- {range}");
                startRange = i+1;

            }
            else
            {    // nothing to do yet
                continue;
            }
        }

        if(startRange != 100)
        { // would be 100 if last item processed in loop was the 99
            
            var range = genRange(startRange,99) ;
            ranges.Add(range);
            
            log($" found final range @ {100} -- {range}");
        }


        var result = string.Join(",",ranges);
        
        log(result);
        return result;
    }

    public string genRange(int start, int end)
    {
        if (start==end) return $"{start}";
        return $"{start}-{end}"; 
    }


}



}

