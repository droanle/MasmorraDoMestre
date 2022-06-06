using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MasmorraDoMestre.View;

namespace MasmorraDoMestre.Model
{
    internal class Utilities
    {
        private Thread window;

        public void GoMenu(Form currentWindow, ParameterizedThreadStart start)
        {
            currentWindow.Close();
            window = new Thread(start);
            window.SetApartmentState(ApartmentState.MTA);
            window.Start();
        }

        public string[] formatDate(string input) 
        {
            string dataPattern = @"(\d{2})+\/+(\d{2})+\/+(\d{4})+ +(\d{2})+\:+(\d{2})+\:+(\d{2})";

            Match match = Regex.Matches(input, dataPattern)[0];

            return new string[] { 
                match.Groups[0].Value,
                match.Groups[1].Value,
                match.Groups[2].Value,
                match.Groups[3].Value,
                match.Groups[4].Value,
                match.Groups[5].Value,
            };
        }

        public string formatDate(string input, string separator, int[] getOption)
        {
            string value = "";
            Boolean init= true;
            string[] match = formatDate(input);

            foreach (int option in getOption)
            {
                if (init) init = false;
                else value += separator;

                value += match[option];
            }

            return value;
        }

        public Image getImagePrefile(int v)
        {
            switch (v)
            {
                case 1: return global::MasmorraDoMestre.Properties.Resources.image1; break;
                case 2: return global::MasmorraDoMestre.Properties.Resources.image2; break;
                case 3: return global::MasmorraDoMestre.Properties.Resources.image3; break;
                case 4: return global::MasmorraDoMestre.Properties.Resources.image4; break;
                default: return global::MasmorraDoMestre.Properties.Resources.image5; break;
            };
        }

        public void FontDefine(Panel e)
        {
            try
            {
                PrivateFontCollection pf = new PrivateFontCollection();
                pf.AddFontFile((Path.GetFullPath(@"..\..\Resources\Fonts") + @"\Minecraftia-Regular.ttf"));
                pf.AddFontFile((Path.GetFullPath(@"..\..\Resources\Fonts") + @"\alagard.ttf"));
                foreach (Control c in e.Controls)
                {
                    if (c.Font.Name == "Microsoft Sans Serif") c.Font = new Font(pf.Families[1], c.Font.Size, c.Font.Style);
                    if (c.Font.Name == "Microsoft Tai Le") c.Font = new Font(pf.Families[0], c.Font.Size, c.Font.Style);
                }

                pf = null;
            }
            catch { }
        }

        public void FontDefine(Form e)
        {
            try
            {
                PrivateFontCollection pf = new PrivateFontCollection();
                pf.AddFontFile((Path.GetFullPath(@"..\..\Resources\Fonts") + @"\Minecraftia-Regular.ttf"));
                pf.AddFontFile((Path.GetFullPath(@"..\..\Resources\Fonts") + @"\alagard.ttf"));
                foreach (Control c in e.Controls)
                {
                    if (c.Font.Name == "Microsoft Sans Serif") c.Font = new Font(pf.Families[1], c.Font.Size, c.Font.Style);
                    if (c.Font.Name == "Microsoft Tai Le") c.Font = new Font(pf.Families[0], c.Font.Size, c.Font.Style);
                }
            }
            catch { }
        }
    }
}
