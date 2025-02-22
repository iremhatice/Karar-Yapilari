namespace _2_IfElse_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1-Kullanıcı Adı ve Parola ile Giris
            // Kullanici adi ve parolasini kullanicidan alalim. Eger basarili ise Basariyla giris yapildi, basarisizsa Kullanici adi veya parola hatalidir... seklinde uyarı verdirelim.

            string dogruKullaniciAdi = "admin";
            string dogruSifre = "12345";

            Console.WriteLine("Kullanıcı adı giriniz: ");
            string user = Console.ReadLine();

            Console.WriteLine("Parola Griniz: ");
            string password = Console.ReadLine();

            if (user == dogruKullaniciAdi && password == dogruSifre)
                Console.WriteLine("Başarılı Giriş");
            else
                Console.WriteLine("Başarısız Giriş");
            #endregion

            #region Ornek2-Sayının Pozitiflik ve Negatiflik Durumu
            // Gonderilen sayi pozitifmi negatifmi yoksa notr mu ? kontrolunu gerceklestiriniz.
            Console.Write("Bir sayi giriniz : ");
            int sayim = int.Parse(Console.ReadLine());

            if (sayim > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if (sayim < 0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Notr");
            }
            #endregion

            #region Ornek3-Vize-Final Notu Hesaplama
            //Kullanicidan Vize ve Final Notlarını alın. Vizenin % 30 ve Finalin % 70 hesaplayıp sonucu bulun.
            double vize, final, ortalama;

            Console.WriteLine("Vize Notu Giriniz: ");
            vize = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Notu Giriniz: ");
            final = double.Parse(Console.ReadLine());

            ortalama = (vize * 0.3) + (final * 0.7);

            if (ortalama >= 0 && ortalama < 30)
            {
                Console.WriteLine("FF");
                Console.WriteLine("Sonuc:" + ortalama);
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                Console.WriteLine("CC");
                Console.WriteLine("Sonuc:" + ortalama);

            }
            else if (ortalama >= 50 && ortalama < 70)
            {
                Console.WriteLine("BB");
                Console.WriteLine("Sonuc:" + ortalama);

            }
            else if (ortalama >= 70 && ortalama <= 100)
            {
                Console.WriteLine("AA");
                Console.WriteLine("Sonuc:" + ortalama);

            }
            else
            {
                Console.WriteLine("Yanlış Bilgi");
            }
            #endregion

            #region Ornek4-Bolumlere Ayirma
            /* Dışarıdan ürün adı girilecek bize hangi bölümde olduğunu söyleyecek.
            Domates,biber,patlıcan => Meyve ve Sebze bölümüne bak
            Diş macunu, Parfüm, Sabun => Kozmetik Bölümüne bak
            Cep Telefonu,TV,Bilgisayar => Teknoloji bölümüne bak
            Bunların dışında bir ürün => "Bu ürün bizde yok!"
            */

            string product;
            Console.WriteLine("Ürün adı giriniz:");
            product = Console.ReadLine();

            if (product == "Domates" || product == "Biber" || product == "Patlıcan")
            {
                Console.WriteLine("Meyve sebze bölümüne bakınız.");
            }
            else if (product == "Dişmacunu" || product == "Parfüm" || product == "Sabun")
            {
                Console.WriteLine("Kozmetik bölümüne bakınız.");
            }
            else if (product == "Cep Telefonu" || product == "TV" || product == "Bilgisayar")
            {
                Console.WriteLine("Teknoloji bölümüne bak");
            }
            else
            {
                Console.WriteLine("üzgünüz,Bu ürün bizde yok!");
            }
            #endregion

            #region Ornek5-Vucut Kitle Indeksi Hesaplama
            /*Kullanıcıdan kilo ve boy alınarak vucut kitle indeksini hesaplayan programı yazınız.
            Formül:  VKI = kilo/ (boy*boy) */
            /* VKI<18.5 - Zayıf
             * 18.5< VKI <24.9 - Normal
             * 25 <= VKI <29.9 - Kilolu
             * 30 <= VKI - Obez
             */

            try
            {
                Console.Write("Kilonuzu (kg) giriniz: ");
                double kilo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Boyunuzu (metre) giriniz: ");
                double boy = Convert.ToDouble(Console.ReadLine());

                if (boy <= 0 || kilo <= 0)
                {
                    Console.WriteLine("Geçerli bir kilo ve boy giriniz.");
                    return;
                }

                double vki = kilo / (boy * boy);
                Console.WriteLine($"Vücut Kitle Indeksiniz (VKİ): {vki:F2}");

                if (vki < 18.5)
                    Console.WriteLine("Sonuç: Zayıf");
                else if (vki < 24.9)
                    Console.WriteLine("Sonuç: Normal");
                else if (vki < 29.9)
                    Console.WriteLine("Sonuç: Kilolu");
                else
                    Console.WriteLine("Sonuç: Obez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
            #endregion

            #region Ornek6-Faktoriyel Hesaplama
            /*Kullanıcıdan alınan bir sayının faktöriyelini hesapayan ve ekrana yazdıran programı yazınız.
            0 girerse fak 1
            negatif sayı girerse negatif sayının fak hesaplanamaz.*/

            int sayi, sayac, fak = 1;
            Console.WriteLine("Sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                Console.WriteLine($"Girilen sayı= {sayi} Faktöriyel=1");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Negatif sayının faktöriyeli hesaplanamaz.");
            }
            else
            {
                sayac = sayi;
            faktoriyel: fak = fak * sayac;
                sayac--;
                if (sayac > 1)
                {
                    goto faktoriyel;
                }
                if (sayac == 1)
                {
                    Console.WriteLine($"Girilen sayı= {sayi} " + " Faktöriyeli= " + fak);
                }
            }
            #endregion

            #region Ornek7-En Kucuk Sayi Hesaplama
            // Kullanıcıdan alınan 3 sayıdan en küçüğünü bulan ve ekrana yazdıran programı yazınız.

            int sayi1, sayi2, sayi3;
            Console.WriteLine("1.sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayıyı giriniz:");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 < sayi2 && sayi1 < sayi3 || sayi1 == sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine($"Sayılar eşit sayı= {sayi1}");
            }
            else if (sayi2 < sayi1 && sayi2 < sayi3 || sayi2 == sayi3 && sayi2 < sayi1)
            {
                Console.WriteLine("En küçük sayı: " + sayi2);
            }
            else if (sayi3 < sayi1 && sayi3 < sayi2 || sayi1 == sayi3 && sayi1 < sayi2)
            {
                Console.WriteLine("En küçük sayı: " + sayi3);
            }
            else
            {
                Console.WriteLine("En küçük sayı:" + sayi1);
            }
            #endregion
        }
    }
}
