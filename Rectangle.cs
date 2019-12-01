using System;

namespace polymorphism {
  public class Rectangle : Shape {
    override Draw () {
      base.Draw ();
      Console.WriteLine ("Draw a rectangle");
    }
  }
}