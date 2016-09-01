/*

What can you overload? Can you overload function names? Can you overload operators yourself? Does the language
come with any overloaded operators?

c# lets you overload operators with user-defined types by defining static member
functions. comparison operators must be overloaded in pairs; if == is overloaded,
then != must be too.

can overload + - ! ~ ++ -- true false * / % & | ^ << >> == != < > >= <= [source1]
and function names[source2]. can make two different functions with different parameters
but the same name, and compiler will check to see which one is being used when
compiling.

source1: https://msdn.microsoft.com/en-us/library/8edha89s.aspx
source2: the below code

*/

using System;

public class Line{
  private int length;

  public Line(){}

  public Line(int i){
    this.length = i;
  }

  public int getLength(){
    return this.length;
  }
  public static Line operator + (Line l1, Line l2){
    Line line = new Line();
    line.length = l1.getLength() + l2.getLength();
    return line;
  }
}

public class q44{

  static void bar(int x){
    Console.WriteLine("printing an int");
  }

  static void bar(string s){
    Console.WriteLine("printing a str");
  }

  public static void Main(){
    bar(5);  //both will run because overloaded method
    bar("ello");

    Line l = new Line(1);
    Line l2 = new Line(2);
    Line l3 = new Line();
    l3 = l + l2;
    Console.WriteLine(l3.getLength()); //should be 3

  }

}
