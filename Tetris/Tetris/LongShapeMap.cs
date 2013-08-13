namespace Tetris {
    public class LongShapeMap : IShapeMap {
        public LongShapeMap() {
            ShapeMap = new[,] {
                {true},
                {true},
                {true},
                {true}
            };
        }

        public bool[,] ShapeMap { get; set; }
    }
}