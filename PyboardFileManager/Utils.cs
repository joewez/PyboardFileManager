using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyboardFileManager
{
    public static class Utils
    {      

        public static Color DecodeColor(string ColorSettingName)
        {
            Color color = new Color();

            string ColorSetting = ConfigurationManager.AppSettings[ColorSettingName];

            if (ColorSetting.Contains(","))
            {
                string[] rgb = ColorSetting.Split(',');
                color = Color.FromArgb(Convert.ToInt32(rgb[0]), Convert.ToInt32(rgb[1]), Convert.ToInt32(rgb[2]));
            }
            else
                color = Color.FromName(ColorSetting);

            return color;
        }

        public static bool DecodeBoolean(string BooleanSettingName)
        {
            bool result = false;

            string BooleanSetting = ConfigurationManager.AppSettings[BooleanSettingName];
            if (!String.IsNullOrEmpty(BooleanSetting) && BooleanSetting.Trim().ToUpper().Substring(0, 1) == "Y")
            {
                result = true;
            }

            return result;
        }

    }
}
