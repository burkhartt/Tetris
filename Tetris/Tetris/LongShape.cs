using System;
using System.Collections.Generic;

namespace Tetris {
    class LongShape : IShape
    {
        private Cell[,] currentMap;
        public LongShape()
        {
            ShapeMaps = new LongShapeMaps();
            currentMap = ShapeMaps.Maps[0];
        }

        public void Rotate()
        {
            currentMap = (ShapeMaps.Maps.IndexOf(currentMap) + 1) > ShapeMaps.Maps.Count ? ShapeMaps.Maps[0] : ShapeMaps.Maps[ShapeMaps.Maps.IndexOf(currentMap) + 1];
        }

        public IShapeMaps ShapeMaps { get; set; }
    }
}