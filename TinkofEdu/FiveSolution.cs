using NUnit.Framework;

namespace ConsoleApp1.TinkofEdu;
using System;

public class FiveSolution
{
    public static long CountTests(long l, long r)
    {
        long count = 0;
        var curNumber = l;
        
        if (l < 10)
        {
            if (r < 10)
            {
                return  r - l + 1;
            }
            else
            {
                count += 10 - l;
                curNumber = 10;
            }
        }
        while (curNumber % 11 != 0)
        {
            curNumber++;
        }
        while (curNumber <=r)
        {
            count++;
            curNumber += 11;
        }
        return count;
        
    }
    
    
}