/* Devon Wasson
   Phase 5
   csci208
   10/03/15
   question 1: how inheritance works

   Inheritance works like it does in most other OOPLs
   a derived class can inherite methods and variables from a parent class

   syntax is derived from source, the rest is proved with my code.

   source: https://msdn.microsoft.com/en-us/library/ms173149.aspx

*/

using System;

public class Person
{

//a person class can only have a name

	public string name;

	public Person() { }

	public Person(string n) //base constructor for the base class
	{
		this.name = n;
	}

	public string getName()
	{
		return this.name;
	}

}

public class Friend : Person
{

//friend can have an age as well as a name

	//name is inherited from the parent class
	public int age;

	public Friend(string n, int a) //constructor for the derived class
	{
		this.name = n;
		this.age = a;
	}

	public int getAge()
	{
		return this.age;
	}


}

public class p5
{

	public static void Main()
	{
	
	Friend friend = new Friend("andy", 20);
	Console.WriteLine("My friend's name is {0} and he is {1} years old", friend.getName(), friend.getAge());
	//because we were able to use friend.getName() which is a method of the parent class
	//we prove that c# uses inheritance
	
	}


}
