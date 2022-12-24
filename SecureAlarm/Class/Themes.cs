using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmoSecure.Class
{
    public static class Themes
    {
        public static Color Panel;
        public static Color Button;
        public static Color PanelButton;
        public static Color FuenteA;
        public static Color FuenteB;
        public static Color Program;

        //Theme Dark
        private static readonly Color PanelD = Color.FromArgb(25, 25, 25);
        private static readonly Color ButtonD = Color.FromArgb(22, 22, 22);
        private static readonly Color PanelButtonD = Color.FromArgb(22, 22, 22);
        private static readonly Color FuenteAD = Color.White;
        private static readonly Color FuenteBD = Color.Silver;
        private static readonly Color ProgramD = Color.FromArgb(31, 31, 31);

        //Theme Light
        private static readonly Color PanelL = Color.FromArgb(245, 245, 245);
        private static readonly Color ButtonL = Color.FromArgb(235, 235, 235);
        private static readonly Color PanelButtonL = Color.FromArgb(235, 235, 235);
        private static readonly Color FuenteAL = Color.FromArgb(36, 36, 36);
        private static readonly Color FuenteBL = Color.FromArgb(60, 60, 60);
        private static readonly Color ProgramL = Color.White;

        public static void ThemeSelect(string Thema)
        {
            if (Thema == "Dark")
            {
                Panel = PanelD;
                Button = ButtonD;
                PanelButton = PanelButtonD;
                FuenteA = FuenteAD;
                FuenteB = FuenteBD;
                Program = ProgramD;
            }
            if (Thema == "Light")
            {
                Panel = PanelL;
                Button = ButtonL;
                PanelButton = PanelButtonL;
                FuenteA = FuenteAL;
                FuenteB = FuenteBL;
                Program = ProgramL;
            }
        }
    }
}
