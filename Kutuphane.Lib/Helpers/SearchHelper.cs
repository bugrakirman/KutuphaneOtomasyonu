using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Helpers
{
    public class SearchHelper
    {
        public static List<T> Ara<T>(List<T> dataSource, string param) where T : Kitap
        {
            param = param.ToLower();
            return dataSource.Where(x => x.KitapAd.ToLower().Contains(param)
                                         || x.YazarAd.ToLower().Contains(param)
                                         || x.YazarSoyad.ToLower().Contains(param)).ToList();
        }
    }
}
