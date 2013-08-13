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

    internal class Well : IWell {
        private readonly WellMap wellMap;
        private IShape movingShape;

        public Well(int height, int width) {
            wellMap = new WellMap(height, width);
        }

        public void AddShape(IShape shape) {
            movingShape = shape;
        }

        public void Continue() {
            // other logic here
            if (ShapeHasCompletedDescent()) {
                ShapeCompletedDescent(this, null);
            }
        }

        public IWellMap GetWellMap() {
            return wellMap;
        }

        public event EventHandler ShapeCompletedDescent;

        private bool ShapeHasCompletedDescent() {
            throw new NotImplementedException();
        }
    }

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

    internal class WallCell : Cell {
        public override void Draw() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("#");
        }
    }

    internal class Cell {
        public virtual void Draw() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ");
        }
    }

    public interface IWell {
        void AddShape(IShape shape);
        void Continue();
        IWellMap GetWellMap();
    }

    public interface IWellMap {
        void Draw();
    }

    public interface IShape {
        void Rotate();
        IShapeMap GetShapeMap();
    }

    public interface IShapeMap {
    }
}