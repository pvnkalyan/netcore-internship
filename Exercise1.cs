using System;
using System.Linq;
using System.Collections.Generic;
 
namespace netcore_internship
{
    public class program
    {
        public void Run()
        {
             int[] arr1 = new int[] { 6,6,9,8,5,4,7,8,5,3,2,3,2,3,6,5,8,5,8,6,9,6,9,9,5,8,7,4,7,8,4,5,9,5,2,6,5,8,7,1};  
             Array.Sort(arr1);	
		     var n = from x in arr1  
				group x by x into y  
				select y;  
				foreach (var arrNo in n)  
				{  
					Console.Write(arrNo.Key + " = " + arrNo.Count());  
				} 
    }
        static void Main(String[] args)
        {
            program p=new program();
            p.Run();
        }
    }
}
