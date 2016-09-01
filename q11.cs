/*

Does c# have list comprehension -> yes, by implimenting the library Linq.
List comprehension is not built in, but can be added. To do so,
one should use the keywords below. from 'x' in 'range(a,z)' select 'something'

source: the below code

*/

using System;
using System.Linq;

public class q11{

  public static void Main(){
    int[] list1 = {1,2,3,4,5};

    //gives the square of all numbers in the range of 1 to 5
    var list = from x in list1 select x*x;
    //makes an array of type System.Collections.Generic.IEnumerable<int>

  }

}
