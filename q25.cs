/*

what operations can you do on numbers? is it different for chars and other int-like types?

you can do + - * / and % operations for math in c#(source). this works on ints, and
ints in other forms. this includes chars. however, chars are implicetly cast to
ints when doing math, so to retain a char value, they must be explicetly cast
back to char. one should check that the int is a valid value for a char when
casting, however. (below code)

source: https://msdn.microsoft.com/en-us/library/aa691371(v=vs.71).aspx

*/

using System;

public class q25{

  public static void Main(){

    int i = 1+1;
    i = 1-1;
    i = 1*1;
    i = 1/1;
    i = 1%1;
    Console.WriteLine(i);

    //you can only do funky math this way.
    //doing math on chars converts to an int implicetly, so you
    //have to convert explicitely back to a char.
    char c = (char)('c'+'d');
    Console.WriteLine(c);

    //this line doesnt work because it returns -1 and there is no ascii for that
    //c = (char)('c'-'d');

    c = (char)('c'*'d');
    Console.WriteLine(c);
    c = (char)('c'/'d');
    Console.WriteLine(c);
    c = (char)('c'%'c');
    Console.WriteLine(c);

    int h = 0xBE - 0xBA;
    Console.WriteLine(h);
    h = 0xBE + 0xBA;
    Console.WriteLine(h);
    h = 0xBE / 0xBA;
    Console.WriteLine(h);
    h = 0xBE * 0xBA;
    Console.WriteLine(h);
    h = 0xBE % 0xBA;
    Console.WriteLine(h);

  }

}
