using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGeneric
{
    public static class Gauge
    {


        public static char BarCharacter = '\u2590';
        static long _count = 0;
        static int Poucent = 0;
        public static bool ShowSymbol = true;


        public static long count
        {
            get { return _count; }
            set
            {
                _count = value;
                Poucent = 0;
                if (value > 0)
                    Display.RenderConsoleProgress(0, BarCharacter, Console.ForegroundColor, "00%");
            }
        }

        public static bool UpdateGauge(int idx) => UpdateGauge((long)idx);

        public static bool UpdateGauge(long idx)
        {
            if ((int)(((float)(/*id +*/ idx) / (float)count) * 100) > Poucent && Poucent <= 100)
            {
                Poucent = (int)(((float)(/*id +*/ idx) / (float)count) * 100);
                Display.RenderConsoleProgress(Poucent, BarCharacter, Console.ForegroundColor, $"{Poucent:D2} {(ShowSymbol == true ? "%" : "")}");
            }
            return false;
        }

    }
}
