/*

c# support for multidimensional arrays -> these behave exactly like regular arrays.
A multi dimensional array is just an array whos values are filled with arrays.
You can assign it values or just initialize an empty array, like normal.

source: https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx

*/


using System;

public class q28{

  public static void Main(){
    int[,] twoD = new int[2,2]; //init empty array
    int[,] twoD2 = new int[,] {{1,1}, {2,2}};

    for (int i = 0; i  < 2; i++){
      for (int j = 0; j < 2; j++){
        Console.WriteLine(twoD2[i,j]); //prints 1122
      }
    }

  }


}
