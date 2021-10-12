using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text;

namespace MsiSneakAttack
{
    public class Msi
    {

        [DllImport("msi.dll", CharSet = CharSet.Unicode)]
        static extern Int32 MsiGetProductInfo(string product, string property,
       [Out] StringBuilder valueBuf, ref Int32 len);

        [DllImport("msi.dll", SetLastError = true)]
        static extern int MsiEnumProducts(int iProductIndex,
            StringBuilder lpProductBuf);

      
        static string GetProperty(string guid, string name, int len = 512)
        {
            var sb = new StringBuilder(len);
            MsiGetProductInfo(guid, name, sb, ref len);
            return sb.ToString();
        }

        public static IEnumerable<MsiInfo> GetProducts()
        {
            var result = new List<MsiInfo>();

            var sbProductCode = new StringBuilder(39);
            int iIdx = 0;
            while (0 == MsiEnumProducts(iIdx++, sbProductCode))
            {
                var guid = sbProductCode.ToString();

                var dtStr = GetProperty(guid, "InstallDate");

                DateTime? dt = null;

                // 20210102 
                if (dtStr.Length == 8
                    && int.TryParse(dtStr.Substring(0, 4), out var dtYear)
                    && int.TryParse(dtStr.Substring(4, 2), out var dtMonth)
                    && int.TryParse(dtStr.Substring(6, 2), out var dtDay))
                {
                    dt = new DateTime(dtYear, dtMonth, dtDay);
                }

                result.Add(new MsiInfo
                {
                    ProductCode = guid,
                    ProductName = GetProperty(guid, "ProductName"),
                    PackageName = GetProperty(guid, "PackageName"),
                    InstallLocation = GetProperty(guid, "InstallLocation"),
                    InstallSource = GetProperty(guid, "InstallSource"),
                    InstallDate = dt,
                    Version = GetProperty(guid, "VersionString"),
                });
            }

            return result;
        }
    }

    public class MsiInfo
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Version { get; set; }

        public string DisplayName { get; set; }
        public string PackageName { get; set; }

        public string Language { get; set; }

        public string InstallLocation { get; set; }
        public string InstallSource { get; set; }

        public DateTime? InstallDate { get; set; }
    }

}
