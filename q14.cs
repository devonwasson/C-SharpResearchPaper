/*

Anonymous funcitons -> c# can use lambda expressions and anonymous functions
to make delegates or expression tree types. this allows one to write local 
fncts to pass as args or return as the value of a fnct call

source: https://msdn.microsoft.com/en-us/library/bb397687.aspx

*/

using System;

class q14{
	delegate int del(int i); 
	public static void Main(){
		del d = x => x*x;   //this returns the squared for any x
		int i = d(5); //should be 25
		Console.WriteLine(i);
	}

}
