using Kutuphane.Lib.Entities;
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
            return dataSource.Where(x => x.KitapAdi.ToLower().Contains(param)
                                         || x.YazarAdi.ToLower().Contains(param)
                                         || x.YazarSoyadi.ToLower().Contains(param)).ToList();
        }
    }
}
