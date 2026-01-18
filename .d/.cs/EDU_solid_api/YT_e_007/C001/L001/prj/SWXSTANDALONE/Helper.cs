using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SWXSTANDALONE
{
    internal static class Helper
    {
        internal static string[] GetCADFlsFrmDr(string dr)
        {
            // check isDirectory
            if (!Directory.Exists(dr))
               return null;
            // get sldprts from dr
            string[] prts = Directory.GetFiles(dr,"sldpart");
            // get sldasm from dr
            string[] asms = Directory.GetFiles(dr, "sldasm");

            List<string> cadFiles = new List<string>();

            // add to list necessary fl_nm
            if (prts!=null)
             cadFiles.AddRange(prts);
            if (asms != null)
                cadFiles.AddRange(asms);

            // return list as array
            return cadFiles.ToArray();
        }
    }
}
