using System;

namespace ODEV
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun urun1 = new Urun();
			urun1.Adi = "Peynir";
			urun1.Turu = "Çeçil Peyniri";
			urun1.Yore = "Kars";

			Urun urun2 = new Urun();
			urun2.Adi = "Peynir";
			urun2.Turu = "Tulum Peyniri";
			urun2.Yore = "İzmir";

			Urun urun3 = new Urun();
			urun3.Adi = "Peynir";
			urun3.Turu = "Örgü Peynir";
			urun3.Yore = "Erzincan";

			Urun urun4 = new Urun();
			urun4.Adi = "Peynir";
			urun4.Turu = "Otlu Peynir";
			urun4.Yore = "Van";


			Urun[] urunler = new Urun[] { urun1,urun2,urun3,urun4};
			//foreach ile yapımı

			foreach (var Urun in urunler)
			{
				Console.WriteLine("Ürünün Adı:" + Urun.Adi);
				Console.WriteLine("Ürünün Türü:" + Urun.Turu);
				Console.WriteLine("Ürünün Yöresi:" + Urun.Yore);

			}
			// while döngüsü ile yapımı

			int i = 0;
			while (i < urunler.Length) 
			{
				Console.WriteLine("Ürünün Adı:" + urunler[i].Adi);
				Console.WriteLine("Ürünün Türü:" + urunler[i].Turu);
				Console.WriteLine("Ürünün Yöresi:" + urunler[i].Yore);

				i++;
			}
			// for ile yapımı
			for (int j = 0; j < urunler.Length; j++)
			{
				Console.WriteLine("Ürünün Adı:" + urunler[j].Adi);
				Console.WriteLine("Ürünün Türü:" + urunler[j].Turu);
				Console.WriteLine("Ürünün Yöresi:" + urunler[j].Yore);
			}
		}
		class Urun
		{
			public string Adi { get; set; }
			public string Turu { get; set; }
			public string Yore { get; set; }

		}
	}
}
