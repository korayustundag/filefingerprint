using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFingerprint
{
    public static class FileSize
    {
        public static string GetString(long lng)
        {
            if (lng < 1024)
            {
                return lng.ToString() + " Bytes";
            }
            else if (lng < 1048576)
            {
                return (lng / 1024).ToString() + " KB";
            }
            else if (lng < 1073741824)
            {
                return ((lng / 1024) / 1024).ToString() + " MB";
            }
            else if (lng < 1099511627776)
            {
                return (((lng / 1024) / 1024) / 1024).ToString() + " GB";
            }
            else if (lng < 1125899906842624)
            {
                return ((((lng / 1024) / 1024) / 1024) / 1024).ToString() + " TB";
            }
            else if (lng >= 1125899906842624)
            {
                return (((((lng / 1024) / 1024) / 1024) / 1024) / 1024).ToString() + " PB";
            }
            else
            {
                return "File size error!";
            }
        }
    }
}
