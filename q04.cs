// Devon Wasson
// Question 4
// static vs dynamic method binding

/*
Dynamic method binding is when the method being called is looked up at run time
Static method binding si when the method being called is looked up at compile time
If we can have an object be of one type but actually be another type,
and have the methods of the second type be attributes of the object
then we have dynamic method binding.
In the example below, a Bird object is defined as a tucan.
If calling bird.fly() prints the method for tucan, then we know
C# uses dynamic method binding. The function was called at run time rather than
compile time. If it was called at compile time, the compiler wouldnt "know"
the function of the tucan and it would bind the method for the bird to our obj.

source: class notes/homework on dynamic method binding and the code below
*/

using System;

public class q04 {

    public static void Main() {
        Bird bird = new Tucan(); //has type bird but obj will be tucan
        bird.fly();
	//if bird.fly() produces "Tucan is flying" then we have dynamic method binding
	//if we get "Generic Birds are flying" then we have static method binding

    }
}

public class Bird {

    public Bird() { }

    public virtual void fly() {
        Console.WriteLine("Generic Birds are Flying");
    }
}

public class Tucan : Bird {

    public Tucan() { }


    public override void fly() {
        Console.WriteLine("Toucan is Flying");
    }
}
