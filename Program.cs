using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiyanHomes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Darkroom);
            ////apply vector skin and choose a palette
            //UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Darkroom, SkinSvgPalette.Bezier.CherryInk);
            ////disable skinning, apply the "Flat" style
            ////note that several DevExpress controls (for example, the Ribbon) cannot be displayed without a skin
            //UserLookAndFeel.Default.SetStyle(LookAndFeelStyle.Style3D, false, true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
