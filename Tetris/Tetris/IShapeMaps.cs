using System.Collections.Generic;

namespace Tetris {
    public interface  IShapeMaps
    {
        List<Cell[,]> Maps { get; set; }
    }
}