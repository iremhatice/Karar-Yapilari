namespace _4_SwitchCase_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1-Mevsimlere Gore Aylar
            //Dışarıdan girilen mevsime gore aylar dondurulecek.

            string mevsim;
            Console.WriteLine("Mevsim giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kis":
                    Console.WriteLine("Aralık-Ocak-Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Mart-Nisan-Mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("Haziran-Temmuz-Ağustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Eylül-Ekim-Kasım");
                    break;
                default:
                    Console.WriteLine("Böyler bir mevsim yok");
                    break;
            }
            #endregion

            #region Ornek2-Kullanıya Gore Giris
            /*Eğer kullanıcı "Admin","Yonetici","CEO","Başkan" ise "Yönetim paneline hoşgeldiniz."
            Eğer "uye" ise "Ana sayfaya hoşgeldiniz."
            Hiçbiri ise "Bu siteye giriş yetkiniz yok." */

            Console.WriteLine("Kullanıcı: ");
            string user = (Console.ReadLine());

            switch (user)
            {
                case "admin":
                case "Yonetici":
                case "ceo":
                case "baskan":
                    Console.WriteLine("Yönetim paneline hoşgeldiniz");
                    break;
                case "uye":
                    Console.WriteLine("Anasayfaya hoşgeldiniz.");
                    break;
                default:
                    Console.WriteLine("Bu siteye giriş yetkiniz yok");
                    break;
            }
            #endregion

            #region Ornek3-Nota Gore Geçme Durumu Hesaplama
            //Kullanıcıdan not isteyin A-B - C - D - E - F ,A - B - C girerse "GEÇTİNİZ",D girerse "ORTALAMA İLE GEÇTİNİZ",E - F girerse "KALDINIZ" yazdıran program

            Console.WriteLine("Not giriniz: ");
            string not = Console.ReadLine().ToUpper();

            switch (not)
            {
                case "A":
                case "B":
                case "C":
                    Console.WriteLine("Geçtiniz");
                    break;
                case "D":
                    Console.WriteLine("Ortalama İle Geçtiniz");
                    break;
                case "E":
                case "F":
                    Console.WriteLine("Kaldınız");
                    break;
                default:
                    Console.WriteLine("Böyle bir harf notu yoktur.");
                    break;
            }
            #endregion

            #region Ornek4-Gunler
            //Kullanıcıdan aldığı rakama göre gün ismi döndüren program

            Console.Write("Bir gün numarası girin (1-7): ");
            int gunNumarasi = Convert.ToInt32(Console.ReadLine());
            switch (gunNumarasi)
            {
                case 1: Console.WriteLine("Pazartesi"); break;
                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Çarşamba"); break;
                case 4: Console.WriteLine("Perşembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Cumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;
                default: Console.WriteLine("Geçersiz gün numarası!"); break;
            }
            #endregion
        }
    }
}
