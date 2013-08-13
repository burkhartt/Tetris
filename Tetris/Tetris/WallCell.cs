using System;

namespace Tetris {
    internal class WallCell : Cell {
        public override void Draw() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("#");
        }
    }
}