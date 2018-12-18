using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Data
{
    public class MockData
    {
        public Context Context { get; set; }

        public MockData()
        {
            Context = new Context();

            for (int i = 0; i < 5; i++)
            {
                Context.Yazarlar.Add(new Yazar()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname()
                });
            }
            for (int i = 0; i < 5; i++)
            {
                Context.Uyeler.Add(new Uye()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname()
                });
            }
            for (int i = 0; i < 5; i++)
            {
                Context.Kitaplar.Add(new Kitap()
                {
                    KitapAd = FakeData.PlaceData.GetCountry()
                });
            }
        }
    }
}
