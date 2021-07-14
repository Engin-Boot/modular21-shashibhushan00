using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class PrintAllPairColorCodes
    {
        public static Color[] MajorColor = ColorMap.colorMapMajor;
        public static Color[] MinorColor = ColorMap.colorMapMinor;

        public static void PrintAllColorCodes()
        {
            int i = 1;
            foreach(var majColor in MajorColor)
            {
                Console.Write("{0}. {1} -> ", i++, majColor);
                foreach(var minCol in MinorColor)
                {
                    Console.Write("{0} ", minCol);
                }
                Console.WriteLine();
            }
        }

    }
}
