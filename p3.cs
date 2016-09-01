// Devon Wasson
// p3.cs

//source: https://msdn.microsoft.com/en-us/library/ms228360(v=vs.90).aspx
//all pieces of information for primitive types are listed below in comments

using System;

public class p3 {
	public static void Main() {


		//taken literally exactly from the source above, in the same order
		byte b = 1; // unsigned int of width = 8 and range = 0 - 255 bits
		sbyte sb = 1; // signed int of width = 8 and range = -128 - 127 bits

		int i = 1; // unsigned int of width = 32 and range = -2147483648 - 2147483647
		uint ui = 1; // signed int of width = 32 and range = 0 - 4294967295

		short sh = 1; // signed int of width = 16 and range = -32768 - 32767
		ushort us = 1; // unsigned int of width = 16 and range = 0 - 65535

		long l = 1; // signed int of width = 64 and range = -9223372036854775808 to 9223372036854775807
		ulong ul = 1; // unsigned int of width = 64 and range = 0 - 188446744073709551615

		float f = 1.1F; // single precision floating point of width = 32 and range = -3.4 x10 ^38 to 3.4 x 10^38
		double d = 1.1; // double precision floating point of width = 64 and range = -1.79 x 10^308 to 1.79 x 10^28

		char c = 'a'; // A single unicode character of width = 16 and unicode symbols

		bool bo = true; // Logical boolean type (true or false) of width = 8 and range true or false

		string s = "Hello world"; // A sequence of characters (not a primitive type)

		//the sizes of each item will now be printed below

		Console.WriteLine("Size of byte: {0}\n", sizeof(byte));
		Console.WriteLine("Size of sbyte: {0}\n", sizeof(sbyte));
		Console.WriteLine("Size of int: {0}\n", sizeof(int));
		Console.WriteLine("Size of uint: {0}\n", sizeof(uint));
		Console.WriteLine("Size of short: {0}\n", sizeof(short));
		Console.WriteLine("Size of ushort: {0}\n", sizeof(ushort));
		Console.WriteLine("Size of long: {0}\n", sizeof(long));
		Console.WriteLine("Size of ulong: {0}\n", sizeof(ulong));
		Console.WriteLine("Size of float: {0}\n", sizeof(float));
		Console.WriteLine("Size of double: {0}\n", sizeof(double));
		Console.WriteLine("Size of char: {0}\n", sizeof(char));
		Console.WriteLine("Size of bool: {0}\n", sizeof(bool));

	}
}
