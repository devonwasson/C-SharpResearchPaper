/*

c# allows references in any context and pointers in an "unsafe" context.

pointers can only be used if they are in an unsafe context.[source1]
However, my version of mono does not support this and thus cannot be tested.

references can be made using the ref keywork. [source2]

source1: https://msdn.microsoft.com/en-us/library/y31yhkeb.aspx
source2: https://msdn.microsoft.com/en-us/library/14akc2c7.aspx

*/

using System;

public class q22{

  public static void foo(ref int i){
    i++;
  }

  public static void Main(){
    int i = 0;
    foo(ref i);
    Console.WriteLine(i); //should be 1
    //the second line shows we can make a pointer.
    //the method bar shows what happens when we pass an int by ref
    //because it was by ref, i should now be 1.
  }

}
