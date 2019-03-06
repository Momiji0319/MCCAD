using System.Drawing;

namespace Mccad
{
    public partial class Form1
    {
        /// <summary>
        /// 描画処理
        /// </summary>
        private void Draw()
        {

            DrawArea.Graphics.Clear(BackgroundColor); //背景色をいったん白に戻す
            DrawCurrentPoint(); //現在のマスの位置を描画する
            if (TargetLineFlag) DrawTargetLine(); //照準線機能が有効なら照準線を描画する
            DrawSqueres(); //シートのポインタをすべて描画する
            ChangeStatusBarText(); //ステータスバーのステータスを変更する
            DrawArea.Render();
            return;
        }

        private void DrawCurrentPoint() => AddRectToDrawArea(new Squere(CurrentPoint, pen.Color, FillFlag));

        private void DrawSqueres()
        {
            foreach (Squere item in squeres) AddRectToDrawArea(item);
        }

        private void ChangeStatusBarText()
        {
            toolStripStatusLabel1.Text = $"照準線 : {(TargetLineFlag ? "On" : "Off")}";
            toolStripStatusLabel2.Text = $"四角内塗りつぶし : {(FillFlag ? "On" : "Off")}";
            toolStripStatusLabel3.Text = $"連続設置 : {(ContiPlaceFlag ? "On" : "Off")}";
        }

        /// <summary>
        /// 照準線描画処理
        /// </summary>
        private void DrawTargetLine()
        {
            DrawArea.Graphics.DrawLine(pen, new Point(CurrentPoint.X, 0), new Point(CurrentPoint.X, (int)DrawArea.Graphics.ClipBounds.Y * -1));
            DrawArea.Graphics.DrawLine(pen, new Point(0, CurrentPoint.Y), new Point((int)DrawArea.Graphics.ClipBounds.X * -1, CurrentPoint.Y));
        }

        /// <summary>
        /// 描画する四角を追加する
        /// </summary>
        /// <param name="item">その四角</param>
        private void AddRectToDrawArea(Squere item)
        {
            if (item.IsFill) DrawArea.Graphics.FillRectangle(new SolidBrush(item.Color), new Rectangle(item.Point, new Size(RectangleSize, RectangleSize)));
        else DrawArea.Graphics.DrawRectangle(new Pen(item.Color), new Rectangle(item.Point, new Size(RectangleSize, RectangleSize)));
        }
    }
}
