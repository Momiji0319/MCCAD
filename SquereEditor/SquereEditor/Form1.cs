using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquereEditor
{
    public partial class Form1 : Form
    {
        private BufferedGraphics DrawArea;
        private Point CurrentPoint = new Point(0, 0);
        private Pen pen = Pens.Black;
        private Color BackgroundColor = Color.White;
        private int RectangleSize = 3;
        private List<Squere> squeres = new List<Squere>();

        bool TargetLineFlag = true;
        bool FillFlag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BufferedGraphicsContext BGC = new BufferedGraphicsContext();
            DrawArea = BGC.Allocate(panel1.CreateGraphics(), panel1.DisplayRectangle);
            DrawArea.Graphics.Clear(BackgroundColor);
            DrawArea.Render();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    CurrentPoint.X += 3;
                    break;
                case Keys.Left:
                    CurrentPoint.X -= 3;
                    break;
                case Keys.Down:
                    CurrentPoint.Y += 3;
                    break;
                case Keys.Up:
                    CurrentPoint.Y -= 3;
                    break;
                case Keys.D1:
                    TargetLineFlag = !TargetLineFlag;
                    break;
                case Keys.D2:
                    FillFlag = !FillFlag;
                    break;
                case Keys.Enter:
                    squeres.Add(new Squere(CurrentPoint,pen.Color,FillFlag));
                    break;
            }
            Draw();
        }

        private void Draw()
        {
            DrawArea.Graphics.Clear(BackgroundColor);
            //現在のカーソル位置を表示
            DrawArea.Graphics.FillRectangle(new SolidBrush(pen.Color), new Rectangle(CurrentPoint, new Size(RectangleSize, RectangleSize)));
            //照準線処理はじめ
            if (TargetLineFlag)
            {
                DrawArea.Graphics.DrawLine(pen, new Point(CurrentPoint.X, 0), new Point(CurrentPoint.X, (int)DrawArea.Graphics.ClipBounds.Y * -1));
                DrawArea.Graphics.DrawLine(pen, new Point(0, CurrentPoint.Y), new Point((int)DrawArea.Graphics.ClipBounds.X * -1, CurrentPoint.Y));
            }
            toolStripStatusLabel1.Text = "照準線 : " + (TargetLineFlag ? "On" : "Off");
            //照準線処理おわり
            //図面処理はじめ
            foreach (Squere item in )
            {

            }
            //図面処理終わり
            DrawArea.Render();
            return;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            BufferedGraphicsContext BGC = new BufferedGraphicsContext();
            DrawArea = BGC.Allocate(panel1.CreateGraphics(), panel1.DisplayRectangle);
            Draw();
        }
    }
}