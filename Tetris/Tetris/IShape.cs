namespace Tetris
{
    public interface IShape {
        void Rotate();
        ShapeMap ShapeMap { get; set; }
    }
}