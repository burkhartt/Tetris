namespace Tetris
{
    public interface IShape {
        void Rotate();
        IShapeMap ShapeMap { get; set; }
    }    
}