using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mccad.Enviroment.Data
{
    public static class DecodeData
    {

        public static List<Squere> DecodeCADData(string objects)
        {
            List<Squere> Result = new List<Squere>();
            foreach (string item in objects.Split('\n'))
            {
                string[] nest = item.Split(':');

                int x = Convert.ToInt32(nest[0]);
                int y = Convert.ToInt32(nest[1]);
                Color c = Color.FromArgb(Convert.ToInt32(nest[2]));
                bool isf = Convert.ToBoolean(nest[3]);
                Point p = new Point(x, y);
                Squere jona = new Squere(p, c, isf);
                Result.Add(jona);
            }
            return Result;
        }


    }
}
