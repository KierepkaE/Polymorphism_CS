using System;

namespace polymorphism {
  public class Circle : Shape {
    public override void Draw () {
      base.Draw ();
      Console.WriteLine ("Draw a circle");
    }
  }
}