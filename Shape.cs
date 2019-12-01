using System;

namespace polymorphism {

  public class Shape {
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void Draw () {
      Console.WriteLine ("Parent draw . . . ");
    }
  }
}