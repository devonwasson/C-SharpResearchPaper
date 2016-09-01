/*

Structural reflection is possible in c# by giving objects the type Type.
Reflection dynamically creates an instance of type and will bind it to a
pre-existing object or get the type of an existing object and invoke the methods
and access its fields.

in the below example, GetType is used to get the type of the variable.

source: https://msdn.microsoft.com/en-us/library/ms173183.aspx

*/

using System;

public class q06{

	public static void Main(){
		int i = 0;
		System.Type t = i.GetType();
		Console.WriteLine(t);
		//prints System.Int32
	}

}
