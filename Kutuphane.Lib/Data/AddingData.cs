using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Data
{
    class AddingData
    {
        public Context Context { get; set; }

        public AddingData()
        {
            Context = new Context();

            Context.Kitaplar.Add(new Kitap()
            {

            });
            Context.Yazarlar.Add(new Yazar()
            {

            });
            Context.Uyeler.Add(new Uye()
            {

            });


        }
    }
}

