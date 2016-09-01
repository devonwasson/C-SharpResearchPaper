/*

exceptions and error handling -> try and catch blocks can be used to catch code
that might cause an error. Finally blocks can be included to specify code to be
run regardless of if an expection was thrown or not. You can specify the type of
exception to catch with a catch block which can be derived from exception.
Naturally, different catch blocks catching different exceptions can be together.

source: https://msdn.microsoft.com/en-us/library/ms173162.aspx

*/

using System;

public class q35{

  public static void Main(){
    int[] a = {1,2,3};
    try{
      Console.WriteLine(a[3]); //will error out of bounds
    }
    catch (System.IndexOutOfRangeException e){
      Console.WriteLine("Index out of range!");
    }
    finally{
      Console.WriteLine("In the finally block.");
    }
  }


}
