using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SchedulingApp.Utilities
{
    internal class Localization
    {
        public static string GetLocationSummary()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            string region;
            try
            {
                region = new RegionInfo(culture.Name).EnglishName;
            }
            catch
            {
                region = "Unknown Region";
            }

            return $"{culture.Name} ({region})";
        }
    }
}