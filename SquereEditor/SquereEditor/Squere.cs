using System.Drawing;

namespace Mccad
{
    /// <summary>
    /// 
    /// </summary>
    public class Squere
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
            x = p.X;
            y = p.Y;
            color = c;
            isFill = isf;
        }
        internal Point Point => new Point(x, y);
    }
}