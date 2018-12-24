using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Lib.Helpers
{
    public class ClearHelper
    {
        public static void Temizle(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }
    }
}
