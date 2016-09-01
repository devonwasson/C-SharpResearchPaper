// Devon Wasson
// Question 16
// overriding methods

/*
C# allows for overriding of methods.
The parent class needs to have its method being overwritten be labeled as "virtual"
The child class needs to inherit the parent class
and mark the method they are overriding as "override"
Then, the overriding of methods will work

Source: https://msdn.microsoft.com/en-us/library/ebca9ah3.aspx
*/

using System;

public class q16 {

    public static void Main() {
        BigDog bigDog  = new BigDog();
        bigDog.bark();
	Dog dog = new Dog();
	dog.bark();
	//because c# allows for overriding, calling bark on bigDog will print
	// BARK BARK BARK!!!
	//and calling bark on dog will print bark bark bark!


    }
}

public class Dog {

    public Dog() { }

    public virtual void bark() {
        Console.WriteLine("bark bark bark!");
    }
}

public class BigDog : Dog {

    public BigDog() { }


    public override void bark() {
        Console.WriteLine("BARK BARK BARK!!!");
    }
}
