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
        void Continue();
        IWellMap GetWellMap();
    }

    public interface IWellMap {
    } 
    public interface IShape {
        void Rotate();
        IShapeMap ShapeMap { get; set; }
    }

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
    public interface  IShapeMap
    {
        bool[,] ShapeMap { get; set; }
    }

    public class LongShapeMap : IShapeMap
    {
        public LongShapeMap()
        {
            ShapeMap = new[,]
                {
                    {true},
                    {true},
                    {true},
                    {true}
                };
        }

        public bool[,] ShapeMap { get; set; }
    }
}
