using System;
using System.Collections.Generic;

namespace Tetris
{
    public class LongShapeMaps : IShapeMaps
    {
        public LongShapeMaps()
        {
            Maps = new List<Cell[,]>
                {
                    new[,]
                        {
                            {new Cell(ConsoleColor.Red)},
                            {new Cell(ConsoleColor.Red)},
                            {new Cell(ConsoleColor.Red)},
                            {new Cell(ConsoleColor.Red)}
                        },
                    new[,]
                        {
                            {
                                new Cell(ConsoleColor.Red), new Cell(ConsoleColor.Red), new Cell(ConsoleColor.Red), new Cell(ConsoleColor.Red)
                            }
                        },
                    new[,]
                        {
                            {new Cell(ConsoleColor.Red)},
                            {new Cell(ConsoleColor.Red)},
                            {new Cell(ConsoleColor.Red)},
                            {new Cell(ConsoleColor.Red)}
                        },
                    new[,]
                        {
                            {
                                new Cell(ConsoleColor.Red), new Cell(ConsoleColor.Red), new Cell(ConsoleColor.Red), new Cell(ConsoleColor.Red)
                            }
                        },
                };
        }

        public List<Cell[,]> Maps { get; set; }
    }
}