using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris {
    public class Program {
        static void Main(string[] args) {
        }
    }

    public interface IWell {
        void AddShape(IShape shape);
    }

    public interface IShape {
        void Rotate();
        IShapeMap GetShapeMap();
    }

    public interface IShapeMap {

    }
}
