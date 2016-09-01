/*

polymorphism-> c# supports polymorphism. the below code demonstrates how
we can refer to derived classes as the base class without error.

source: https://msdn.microsoft.com/en-us/library/ms173152.aspx

*/


using System;

public class Plant{
  public string name;

  public Plant(){}

}

public class Tree : Plant{
  public string name = "TREEE";
}

public class Bush : Plant{
  public string name = "bushhhhh";
}


public class q15{

  public static void Main(){
    Tree t = new Tree();
    Bush b = new Bush();
    Plant[] l = {t, b};
    //this code runs because c# supports polymorphism.
    //we can have an array of plants, but each plant can be a derived class
  }

}
