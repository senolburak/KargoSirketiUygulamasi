using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoSirketiUygulamasi.Data
{
   public class KargoSirketi
    {
		public delegate void DagitimMetotTemsilcisi(string no);

		public event DagitimMetotTemsilcisi DagitimaCikar;

		private string  _kargoNo;

		public string  KargoNo
		{
			get { return _kargoNo; }
			set 
			{
                if (value.Length != 8)
                    throw new Exception("Kargo numarası 8 haneli olmak zorundadır");
				if (!value.StartsWith("25"))
					throw new Exception("25 ile başlamalıdır");

                if (!int.TryParse(value.Substring(3), out int sayi))
					throw new Exception("Son beş basamak 0-99999 arasında olmalıdır");

				
				if (value[2] != 'K')
					throw new Exception("3. hane K olmalıdır");

				if (sayi > 99999 && sayi < 0)
					throw new Exception("Son beş hanesi 0-99999 arasında olmalıdır");

				_kargoNo = value;
				DagitimaCikar(_kargoNo);

            }
		}

	}
}
