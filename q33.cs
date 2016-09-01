// Devon Wasson
// csci208
// question 33

/*

Does it do implicit type conversions? Which ones? Does it allow explicit conversions? Which ones?

C# allows for both explicit and implicit type conversions. (1)
You can only implicitly cast if there is no percision loss or from a derived class to a base class(1)
you can do an explicit conversion to lose percision or from a base class to derived class (1)

we can also convert chars to nums and nums to chars using explicit casting (2)

source1: https://msdn.microsoft.com/en-us/library/ms173105.aspx
source2: knowing how to cast, and the code below

chart for all explicit numeric conversions: https://msdn.microsoft.com/en-us/library/yht2cx7b.aspx
chart for all implicit numeric conversions: https://msdn.microsoft.com/en-us/library/y5b434w4.aspx

*/

using System;

public class q33{

	public static void Main(){

		int a = 1;
		double b = a;
		//this works because no loss of percision
		Console.WriteLine("{0}\n",b);


		double c = 1.1;
		int d = (int) c;
		//we lose percision but we explicitly casted so it is okay
		Console.WriteLine("{0}\n",d);

		char e = 'e';
		int f = (int)e;
		Console.WriteLine("{0}\n",f);

		int g = 92;
		char h = (char)g;
		Console.WriteLine("{0}\n",h);

	}

}
