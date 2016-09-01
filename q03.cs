// Devon Wasson
// Question 3, strongly vs weakly vs untyped language

/* 
c# is a more strongly typed language. this is proven by the errors produced
or not produced below. because we can convert int to dbl, it is not perfeclty
strongly typed, but because we can not make any more implicit casts, it 
is not a weakly typed lanauge. 
Soure: class notes on strong vs weak typed language and the code below
*/

using System;

public class q3
{

        public static void Main()
        {
	
	double b = 0.0;
	b = 1;
	//because c# is "more" strongly typed, this is allowed.
	//there is no loss of data, so c# will convert an int to dbl
	//so this proves that it is not "perfectly" strongly typed

	int c = 0;
	c = 'c';
	//this will run because there is a numeric equiv for a char in c#.
	//this is more proof as to why it is not strongly typed, but still
	//does not prove that it is more weakly typed.


	//the code above does not produce errors.
	//the code below produces errors.
	//uncomment the lines below to see the errors they produce

/*
	int i = 0;
	i = 5.5;
	//because c# is more strongly typed, this will not run
	//because you cannot convert a double to an int without a cast


	char a = 'd';
	a = 1;
	//if c# is more strongly typed, this should produce an error at compile time. 
	//if it was more weakly typed, this would produce an error at run time
	//because c# is more strongly typed, this will produce an error at compile time
	//because you cannot convert an int to a char.
*/

        }


}
