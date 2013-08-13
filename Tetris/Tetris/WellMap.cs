using System;

namespace Tetris {
    internal class WellMap : IWellMap {
        private readonly Cell[,] cells;
        private readonly int height;
        private readonly int width;

        public WellMap(int height, int width) {
            this.height = height;
            this.width = width;
            cells = new Cell[height,width];
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    cells[i, j] = new Cell();
                }
            }
            for (var i = 0; i < height; i++) {
                cells[i, 0] = new WallCell();
                cells[i, width - 1] = new WallCell();
            }
            for (var i = 0; i < width; i++) {
                cells[height - 1, i] = new WallCell();
            }
        }

        public void Draw() {
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    cells[i, j].Draw();
                }
                Console.Write("\r\n");
            }
        }
    }
}