/*

scope in c#-> given the below code, we can infer that c# is static scope.
if it was dyanamic, when bar calls foo, the value for b would be 3.
but bceause it is static, foo searches the global name space instead of
the function that called it. 

source: the below code.

*/

using System;

public class q08{

  const int b = 2;

  public static int foo(){
    int a = b + 1;
    return a;
  }

  public static int bar(){
    int b = 3;
    return foo();
  }


  public static void Main(){
    Console.WriteLine(foo()); //should be 3
    Console.WriteLine(bar()); //if static scope, should be 3
                              //if dynamic, should be 4
    //output: 3 3
  }

}
