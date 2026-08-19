using System;
using System.Collections.Generic;
using System.Linq;
public class swap1{
	public static void Main(string[] args){
		string name1=Console.ReadLine();
		string name2=Console.ReadLine();
		Console.WriteLine($"before swap : {name1},{name2}");
		string temp=name1;
		name1=name2;
		name2=temp;
		Console.WriteLine($"after swap : {name1},{name2}");
	}
}