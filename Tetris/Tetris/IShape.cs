using System.Collections.Generic;

namespace Tetris
{
    public interface IShape
    {
        IShapeMaps ShapeMaps { get; set; }
        void Rotate();
    }
}