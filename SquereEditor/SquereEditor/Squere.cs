using System.Drawing;

namespace MCCAD
{
    /// <summary>
    /// 
    /// </summary>
    internal class Squere
    {
        private int x;
        private int y;
        private Color color;
        bool isFill;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Color Color { get => color; set => color = value; }
        public bool IsFill { get => isFill; set => isFill = value; }

        internal Squere(Point p,Color c,bool isf)
        {
            X = p.X;
            Y = p.Y;
            Color = c;
            IsFill = isf;
        }
        internal Point Point => new Point(x, y);
    }
}