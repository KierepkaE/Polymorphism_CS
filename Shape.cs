using System;

namespace polymorphism {
  public class Shape {
    public int Height { get; set; }
    public int Width { get; set; }
    public Position Position { get; set }
    public ShapeType Type { get; set; }
  }
}