namespace Tetris {
    public interface IWell {
        void AddShape(IShape shape);
        void Continue();
        IWellMap GetWellMap();
    }
}