using System;
using System.Threading;

namespace Tetris {
    public class Program {
        private static void Main(string[] args) {
            var userQuit = false;

            var well = new Well(20, 20);
            well.AddShape(new LongShape());
            well.ShapeCompletedDescent += (sender, eventArgs) => { };

            ConsoleKeyInfo keyinfo;
            do {
                well.Continue();
                well.GetWellMap().Draw();
                Thread.Sleep(100);
                keyinfo = Console.ReadKey();
                Console.WriteLine(keyinfo.Key + " was pressed");
            } while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();
        }
    }
}