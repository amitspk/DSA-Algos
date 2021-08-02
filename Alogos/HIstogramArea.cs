// { Driver Code Starts
//Initial Template for C#


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                int N = Convert.ToInt32(Console.ReadLine());
                long[] arr = new long[N];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), long.Parse);

                Solution obj = new Solution();
                long res = obj.getMaxArea(arr, N);
                Console.Write(res+"\n");
          }

        }
    }
}// } Driver Code Ends


//User function Template for C#


class Solution
{
    //Complete this function
    public long getMaxArea(long[] arr, int n)
    {
        //Your code here
        var s = new Stack<int>();
        
        long maxArea = 0;
        int i = 0;
        
        // Console.WriteLine("Amit");
        while(i < n) {
            // Console.WriteLine("peek" + (s.Count == 0 ? 0 : s.Peek()));
            if(s.Count == 0 || arr[i] >= arr[s.Peek()]) {
                s.Push(i++);
                // Console.WriteLine("push:" + i);
            }
            else {
                // Console.WriteLine("pop:");
                while(s.Count != 0 && arr[i] < arr[s.Peek()]) {
                    int p = s.Peek();
                    s.Pop();
                    long area = arr[p] * (s.Count == 0 ? i : (i - s.Peek() - 1));
                    
                    // Console.WriteLine("pop:" + area);
                    if(area > maxArea)
                        maxArea = area;
                }
                // i++;
            }
            
        }
        
        while(s.Count != 0 && arr[i] < arr[s.Peek()]) {
            int p = s.Peek();
            s.Pop();
            long area = arr[p] * (s.Count == 0 ? i : (i - s.Peek() - 1));
            
            if(area > maxArea)
                maxArea = area;
        }
        
        return maxArea;
    }
}