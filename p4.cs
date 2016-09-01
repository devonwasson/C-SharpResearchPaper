/* Devon Wasson
   phase 4
   csci208
   9/28/15

c# uses structs, class, and tuples.
here are the sources I used
https://msdn.microsoft.com/en-us/library/0taef578.aspx
https://msdn.microsoft.com/en-us/library/x9afc042.aspx
https://msdn.microsoft.com/en-us/library/system.tuple(v=vs.110).aspx

tuples are ordinal. structs act very closely to classes in the sense that they both have variables and can have methods. 

*/

using System;

public struct Shirt //struct example
{
	public int size;
	public string color;
	public string brand;
}

public class Friend //class example
{
	public string name;

	public Friend() { }

	public Friend(string n)
	{
		name = n;
	}

	public string getName()
	{
		return name;
	}

}



public class p4
{
	public static void Main()
	{

		//using the struct
		Shirt shirt = new Shirt();
		shirt.size = 10;
		shirt.color = "red";
		Console.WriteLine("Shirt size: {0}, shirt color: {1}", shirt.size, shirt.color);

		//using the class
		Friend friend = new Friend("Elliot");
		Console.WriteLine("My friend is {0}", friend.getName());

		//using the tuple
		var classroom = new Tuple<string, string, int>("Professor Wittie", "s208", 30);
		Console.WriteLine("Professor is {0}, class is {1}, size is {2}.", classroom.Item1, classroom.Item2, classroom.Item3);

	}



}
