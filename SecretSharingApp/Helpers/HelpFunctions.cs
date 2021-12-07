using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSharingApp.Helpers
{
    public class HelpFunctions
    {
        public static IList<int> SplitBitsString(string colors)
        {
            return Enumerable.Range(0, colors.Length / 8)
                .Select(i => Convert.ToInt32(colors.Substring(i * 8, 8), 2)).ToList();
        }
        public static string ColorToString(string colorValue)
        {
            while (colorValue.Length < 8)
            {
                colorValue = '0' + colorValue;
            }
            return colorValue;
        }
        public static string ARGBToString(string A, string R, string G, string B)
        {
            return A + R + G + B;
        }
    }
}
