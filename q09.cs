/*
q09 -> how does c# handle parameter passing?

c# passes arguments by value by default, but can also pass by reference using the
ref keyword. The below example highlights this.


source: https://msdn.microsoft.com/en-us/library/0f66670z.aspx

*/

using System;

public class q09{

  static void Main(){

    //pass by value
    int i = 0;
    foo(i);
    Console.WriteLine(i);
    /* i should still be 0 */

    //pass by reference
    int j = 0;
    foo(ref j);
    Console.WriteLine(j);
    /* j should now be 1 instead of 0 */

  }

  public static void foo(int x){
    x = 1;
  }

  //overload method for pass by ref
  public static void foo(ref int x){
    x = 1;
  }



}
