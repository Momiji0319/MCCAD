using System.Collections.Generic;
using System.Text;

namespace Mccad.Enviroment.Data
{
    public static class EncodeData
    {
        public static string EncodeCADData(List<Squere> Ls)
        {
            StringBuilder Result = new StringBuilder();
            foreach (Squere item in Ls)
            {
                string onedata = item.X + ":" + item.Y + ":" + item.Color.ToArgb().ToString() +":"+ item.IsFill;
                Result.AppendLine(onedata);
            }
            return Result.ToString();

        }

    }
}
