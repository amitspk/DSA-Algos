// { Driver Code Starts
//Initial Template for Java

import java.io.*;
import java.util.*;
class GfG
{
    public static void main (String[] args)
    {
        
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt();
        
        while(t-- > 0)
        {
            int n = sc.nextInt();
            int[] arr = new int[n];
            
            for (int i = 0; i < n; ++i)
                arr[i] = sc.nextInt ();

    		System.out.println (new Sol().search (arr, n));
        }
        
    }
}// } Driver Code Ends


//User function Template for Java

class Sol
{
    public static int search(int a[], int N)
    {
        // your code here
        int l=0,r=N;
	    
	    while(l<r) {
	        int mid = (l+r)/2;
	        if(N == 1)
	            return a[0];
	        else if(mid == 0 && a[mid] < a[mid+1])
	            return a[mid];
	        else if(mid == N-1 && a[mid-1] < a[mid])
	            return a[mid];
	        else if(a[mid-1] < a[mid] && a[mid] < a[mid+1])
	            return a[mid];
	            
	       // System.out.println("befire "+ l + " " + r);
	       if(a[mid-1] == a[mid] && (mid-1)%2 == 0)
	           l = mid + 1;
           else if(a[mid] == a[mid+1] && (mid)%2 == 0)
                l = mid + 1;
	       else
	            r = mid - 1;
	            
	       //System.out.println("after "+ l + " " + r);
	    }
	    
	    return (l == r) ? a[l] : -1;
    }
}