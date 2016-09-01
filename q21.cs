/*

super classes in c# -> a constructor for the derived class can call the constructor
for a super class which will allow the derived class to inherit all methods and fields
from the super class

source: https://msdn.microsoft.com/en-us/library/ms228387(v=vs.90).aspx

*/


using System;

public class Animal{
  public string name;

  public Animal(){}

  public Animal(string name){
    this.name = name;
  }

  public void getName(){
    Console.WriteLine(this.name);
  }

}


public class Cat : Animal{

    private int age;

    public Cat(string name, int age){
      this.age = age;
      this.name = name;
    }

    public void getAge(){
      Console.WriteLine(this.age);
    }

}

public class q21{

  public static void Main(){
    Cat cat = new Cat("Mike", 20);
    cat.getName(); //inherited
    cat.getAge(); //from the derived class
  }

}
