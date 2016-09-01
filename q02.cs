/*
Devon Wasson
Phase 6
question 2
is c# static or dynamically typed? duck typed?


C# requires you to define the type of the variable when writing the code. This is because it is intreperated at compile time.
If instead it was determined at run time, type errors would be caught much later.
Instead, type errors are caught as soon as you compile.
The following program has two version. One compiles, and the commented one does not.
The commented program will not compile if uncommented, proving that C# is not dynamically typed

source: class notes for understanding, the below program for proof

There is a .NET library for duck typing but it is not specifically included with C#
source:https://github.com/deftflux/DuckTyping

*/

using System;

public class p6
{

    public static void Main()
    {

        int i = 0;
        char b = 'c';

/*        
        q = 0;
        a = 'c';
 compiles with these two errors:
p6.cs(29,9): error CS0103: The name `q' does not exist in the current context
p6.cs(30,9): error CS0103: The name `a' does not exist in the current context

*/  
      

    }

}

