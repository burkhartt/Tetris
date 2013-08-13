using System;

namespace Tetris {
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
}