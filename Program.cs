using System;
using System.Collections.Generic;

namespace polymorphism {
    public class Program {
        static void Main (string[] args) {
            var shapes = new List<Shape> ();
            shapes.Add (new Circle { Width = 100, Height = 100 });
            shapes.Add (new Circle { Width = 60, Height = 60 });
            shapes.Add (new Rectangle { Width = 300, Height = 200 });

            var canvas = new Canvas ();
            canvas.DrawShapes (shapes);
        }
    }
}