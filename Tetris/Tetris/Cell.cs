using System;

namespace Tetris {
    internal class Cell {
        public virtual void Draw() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ");
        }
    }
}