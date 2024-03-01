using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;
using System.Drawing;

namespace RiyanHomes
{
    class Constants
    {
        public static String DBConnString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ToString();
        //DBConnString = Encoding.Unicode.GetString(Convert.FromBase64String(DBConnString));

        public static readonly CultureInfo UnitedKingdom = CultureInfo.GetCultureInfo("en-GB");
        public static readonly CultureInfo India = CultureInfo.GetCultureInfo("en-IN");

        
        public enum  Colors
        {
            MediomVioletRed =12,
            Crimson=11,
            DeepPink=10,
            Chocolate=9,
            Coral=8,
            Gold=7,
            Orange=6,
            Khaki=5,
            LightYellow=4,
            MintCream=3,
            Ivory=2,
            FloralWhite=1,
            LightSeaGreen=0
        }
    }

    public class Indianformat
    {
        public static string ConvertString(string sParam)
        {
            decimal parsed = decimal.Parse(sParam, CultureInfo.InvariantCulture);
            CultureInfo hindi = new CultureInfo("hi-IN");
            string text = string.Format(hindi, "{0:c0}", parsed);
            return text;
        }
    }
    public class MyFormat : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            // Convert argument to a string.
            string result = arg.ToString();

            // Format the result as needed.
            decimal parsed = decimal.Parse(result, CultureInfo.InvariantCulture);
            CultureInfo hindi = new CultureInfo("hi-IN");
            string text = string.Format(hindi, "{0:c0}", parsed);
            
            return text;
        }
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }
    }
}
