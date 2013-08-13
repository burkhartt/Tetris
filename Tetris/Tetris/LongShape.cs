using System;

namespace Tetris {
    class LongShape : IShape
    {
        public LongShape()
        {
            ShapeMap = new LongShapeMap();
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }

        public IShapeMap ShapeMap { get; set; }
    }
}