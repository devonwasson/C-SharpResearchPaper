/*

are strings primitive types? what can you do with strings? ->

strings are not primitave types. they are reference types. strings are
series of characters. Chars are primitive types, so a string is a reference
to a series of primitive types. [source1]

you can use the = and + operators on strings, and can index strings. [source2]

source1: https://msdn.microsoft.com/en-us/library/ms228360(v=vs.90).aspx
source2: https://msdn.microsoft.com/en-us/library/362314fe.aspx

*/

using System;

public class q24{

  public static void Main(){

    string s = "string";
    string s2 = "strong";
    string s4 = "string";

    Console.WriteLine(s==s2); // false
    Console.WriteLine(s==s4); //true

    string s3 = s+s2;
    Console.WriteLine(s3); //stringstrong

    Console.WriteLine(s[0]); // s

  }
}
