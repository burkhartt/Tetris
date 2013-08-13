using System;

namespace Tetris
{
    public class Cell
    {
        private readonly ConsoleColor consoleColor;

        public Cell()
        {
            consoleColor = ConsoleColor.White;
        }

        public Cell(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }

        public virtual void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(" ");
        }
    }
}