using System;

namespace polymorphism {
  public class Circle : Shape {
    override Draw () {
      base.Draw ();
      Console.WriteLine ("Draw a circle");
    }
  }
}