// Devon Wasson
// Question 5
// deep vs shallow copying of objects

/*
c# uses shallow copying of objects. This is proven given my understanding of copying from class and the code below.
The code below says a new object is equal to an existing object.
if they language used deep copying, altering one object would not change the other
however, because c# uses shallow copying, the new object points to the old object in its assignment
so changing one object changes the other, as seen in the code and what prints out below.

source: class notes and the code below
*/

using System;

public class Person
{

//a person class can only have a name

        public string name;

        public Person() { }

        public Person(string n) //base constructor for the base class
        {
                this.name = n;
        }

        public string getName()
        {
                return this.name;
        }

	public void setName(string n)
	{
		this.name = n;
	}

}


public class p5
{

        public static void Main()
        {

        Person person = new Person("andy");

	Person person2 = person;
	person2.setName("Nadeem");
	Console.WriteLine("{0}", person.getName());
	Console.WriteLine("{0}", person2.getName());

	//if the two outputs are the same (Nadeem), then we know c# does shallow copying
	//if it prints andy and Nadeem, then we know is does deep copying. 

        }


}
