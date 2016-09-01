/*

How does c# handel the dangling else?

c# uses the in-most if statement when pairing with a dangling else.
In the below example, it is ambiguious to which if statement the else statement
belongs. Because c# pairs else statemets with the in-most if statemet,
the else statement in this case belongs to the if (i==0) statement. So in this
example, the program will not print anything, which is correct for c#.

sourcE: the below code

*/

using System;

public class q30{

  public static void Main(){

    int i = 0;
    if(i == 1)
      if (i == 0)
        Console.WriteLine("Here");

      else
        Console.WriteLine("Here2");

  }

}
