using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCAD
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 描画領域
        /// </summary>
        private BufferedGraphics DrawArea;
        /// <summary>
        /// 現在のポイント位置
        /// </summary>
        private Point CurrentPoint = new Point(0, 0);
        /// <summary>
        /// 現在のペン色
        /// </summary>
        private Pen pen = Pens.Black;
        /// <summary>
        /// 現在の背景色
        /// </summary>
        private Color BackgroundColor = Color.White;
        /// <summary>
        /// 描画領域内における左端の座標を指定する。
        /// システム上のこの位置を左端として指定する
        /// </summary>
        private Point edge;
        /// <summary>
        /// 四角のサイズ
        /// </summary>
        private const int RectangleSize = 3;
        /// <summary>
        /// 四角のリスト
        /// </summary>
        private List<Squere> squeres = new List<Squere>();

        /// <summary>
        /// 照準線有効化のフラグ
        /// </summary>
        bool TargetLineFlag = true;
        /// <summary>
        /// 塗りつぶし有効化のフラグ
        /// </summary>
        bool FillFlag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BufferedGraphicsContext BGC = new BufferedGraphicsContext();
            DrawArea = BGC.Allocate(panel1.CreateGraphics(), panel1.DisplayRectangle);
            Draw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    CurrentPoint.X++;
                    break;
                case Keys.Left:
                    CurrentPoint.X--;
                    break;
                case Keys.Down:
                    CurrentPoint.Y++;
                    break;
                case Keys.Up:
                    CurrentPoint.Y--;
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

        /// <summary>
        /// 描画処理
        /// </summary>
        private void Draw()
        {
            DrawArea.Graphics.Clear(BackgroundColor);
            //現在のカーソル位置を表示
            if (FillFlag)
            {
                DrawArea.Graphics.FillRectangle(new SolidBrush(pen.Color), new Rectangle(CurrentPoint, new Size(RectangleSize, RectangleSize)));
            }
            else
            {
                DrawArea.Graphics.DrawRectangle(pen, new Rectangle(CurrentPoint, new Size(RectangleSize, RectangleSize)));
            }
            //照準線処理はじめ
            if (TargetLineFlag)
            {
                DrawArea.Graphics.DrawLine(pen, new Point(CurrentPoint.X, 0), new Point(CurrentPoint.X, (int)DrawArea.Graphics.ClipBounds.Y * -1));
                DrawArea.Graphics.DrawLine(pen, new Point(0, CurrentPoint.Y), new Point((int)DrawArea.Graphics.ClipBounds.X * -1, CurrentPoint.Y));
            }
            toolStripStatusLabel1.Text = "照準線 : " + (TargetLineFlag ? "On" : "Off");
            //照準線処理おわり
            //図面処理はじめ
            foreach (Squere item in squeres)
            {
                if (item.IsFill)
                {
                    DrawArea.Graphics.FillRectangle(new SolidBrush(pen.Color), new Rectangle(item.Point, new Size(RectangleSize, RectangleSize)));
                }
                else
                {
                    DrawArea.Graphics.DrawRectangle(pen, new Rectangle(item.Point, new Size(RectangleSize, RectangleSize)));
                }
            }
            toolStripStatusLabel2.Text = "四角内塗りつぶし : " + (FillFlag ? "On" : "Off");
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

namespace System.Drawing
{
    
}