using Mccad.Enviroment;
using Mccad.Enviroment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mccad
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
#pragma warning disable CS0169 // フィールド 'Form1.edge' は使用されていません。
        /// <summary>
        /// 描画領域内における左端の座標を指定する。
        /// システム上のこの位置を左端として指定する
        /// </summary>
        private Point edge;
#pragma warning restore CS0169 // フィールド 'Form1.edge' は使用されていません。
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
        private bool TargetLineFlag = true;
        /// <summary>
        /// 塗りつぶし有効化のフラグ
        /// </summary>
        private bool FillFlag = true;
        /// <summary>
        /// 連続設置のフラグ
        /// </summary>
        private bool ContiPlaceFlag = false;

        private bool AppendFlag = true;
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
                    CurrentPoint.X += RectangleSize;
                    break;
                case Keys.Left:
                    CurrentPoint.X -= RectangleSize;
                    break;
                case Keys.Down:
                    CurrentPoint.Y += RectangleSize;
                    break;
                case Keys.Up:
                    CurrentPoint.Y -= RectangleSize;
                    break;
                case Keys.D1:
                    TargetLineFlag = Not(TargetLineFlag);
                    break;
                case Keys.D2:
                    FillFlag = Not(FillFlag);
                    break;
                case Keys.D3:
                    ContiPlaceFlag = Not(ContiPlaceFlag);
                    break;
                case Keys.Enter:

                    AddPoint();
                    break;
                default:
                    break;
            }
            if (ContiPlaceFlag) AddPoint();
            Draw();
        }

        private void AddPoint()
        {

            squeres.Add(new Squere(CurrentPoint, pen.Color, FillFlag));
        }

        public static bool Not(bool value) => !value;

        private void Form1_Resize(object sender, EventArgs e)
        {
            BufferedGraphicsContext BGC = new BufferedGraphicsContext();
            DrawArea = BGC.Allocate(panel1.CreateGraphics(), panel1.DisplayRectangle);
            Draw();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "開く",
                Filter = "MCADシート(*.mcad)|*.mcad|すべてのシート(*.*)|*.*",
                FilterIndex = 0
            };
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader Sr = new StreamReader(OFD.OpenFile()))
                {
                    DecodeData.DecodeCADData(Sr.ReadToEnd());
                }
            }
        }

        private void 名前をつけて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog
            {
                Title = "保存する",
                Filter = "MCADシート(*.mcad)|*.mcad|すべてのシート(*.*)|*.*",
                FilterIndex = 0
            };
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter SW = new StreamWriter(SFD.FileName))
                {
                    SW.Write(EncodeData.EncodeCADData(squeres));
                }
            }
        }

        private void 色を変更するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            if(CD.ShowDialog() == DialogResult.OK)
            {
                pen =new Pen(CD.Color);
            }
            Draw();
        }
    }
}