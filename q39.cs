/*

does c# use short circuit evaluation? -> yes it does. the below code
demonstrates this [source1]. we can avoide short circuit evaluation by
using just a single bar or ampersand [source2].

source1: the below code
source2: the below code
*/


using System;

public class q39{

  public static void Main(){
    int a = 1;
    int b = 2;

    if ((a == 2) && (b == b++)){
      Console.WriteLine(b); //this will not print because a short circuit evaled to false
    }
    else{
      Console.WriteLine(b); //b will still be 2 because the second arg was never evaluated
    }

    if ((a == 2) & (b == b++)){
      Console.WriteLine(b); //this will not print because the condition is not met
    }
    else{
      Console.WriteLine(b); //but b will now be 3 because the entire expression was evaluated
    }
    //expected output: 2 3

  }


}
