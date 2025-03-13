using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoSirketiUygulamasi.Data
{
    public class Nakliyat
    {
        public void KargoyuTasi(string kargoNo)
        {
            MessageBox.Show(kargoNo + "nolu Kargo adresinize teslim edilmek üzere dağıtıma çıkarılmıştır");
        }
    }
}
