// C# program to find longest common prefix of
// given array of words.
using System;
		
public class GFG {
	
	static string longestCommonPrefix(String[] a)
	{
        int len = a.Length;

        if(len==0){
            return "";
        }
        
        if(len==1){
            return a[0];
        }
        
        Array.Sort(a);
        
       
        
        int minlen = Math.Min(a[0].Length, a[len-1].Length);
        
        int i = 0;
        while(i < minlen && a[0][i]==a[len-1][i]){
            i++;
        }
        
        return a[0].Substring(0,i);
	}

	/* Driver Function to test other function */
	public static void Main()
	{
		
		string[] input = {"geeksforgeeks", "geeks",
								"geek", "geezer"};
								
		Console.WriteLine( "The longest Common"
							+ " Prefix is : "
				+ longestCommonPrefix(input));
	}
}
