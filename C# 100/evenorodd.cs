using System;
using System.Collections.Generic;
using System.Linq;
public class evenodd{
	public static void Main(string[] args){
		int name1=Convert.ToInt32(Console.ReadLine());
        if(name1%2==0){
            Console.WriteLine($"the number is even : {name1}");
        }
        else{
            Console.WriteLine($"the number is odd : {name1}");
        }
    }
}