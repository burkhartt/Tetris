using System;

namespace Tetris {
    public class Program {
        private static void Main(string[] args) {
            var well = new Well(50, 20);
            well.GetWellMap().Draw();
            well.ShapeCompletedDescent += (sender, eventArgs) => { };
            Console.ReadKey();
        }
    }
}
