/*
// Devon Wasson
//csci208

//q19 -> implicitly or explicitly typed?

c# supports both explicit and implicit typing for variables.
this is demonstrated by the fact that we can call variables an int, or a var.

however, we cannot have implicit function types. functions must have a return type.
This can be checked by uncommenting the bar function and compiling the code.

source: the below code

*/





using System;

public class q19
{

	public static void Main()
	{

	int i = 0;
  var p = 0;

	}

  public int foo(){
    return 0;
  }
/*
  public bar(){
    return 0;
  }*/


}
