namespace _5_TernaryIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TernaryIf (Satır iç ıf) kulllanımı,bildiğimiz if ifadesinin daha basit kullanımıdır.Genellikle bir koşulun sonucuna bağlı olarak bir değişkene bir değer atamak istediğimizde kullanılır.

            //Temel Kullanım: Koşul ? true:false

            #region Ornek1
            //Eğer kullanıcı bir değer girdiyse consolda göster.Girmediyse "default" yaz.

            Console.WriteLine("Kullanıcı Adı:");
            string userName = Console.ReadLine();

            string result = userName.Length > 0 ? userName : "Default";
            Console.WriteLine("kullanıcı adı: " + result);
            #endregion

            #region Ornek2
            //Belirlenen sayıdan hangisinin büyük olduğunu bulun ve ekrana yazdırın.

            int sayi1 = 45;
            int sayi2 = 56;
            Console.WriteLine(sayi1 > sayi2 ? "1.sayı 2.sayıdan büyüktür" : "2.sayı 1.sayıdan büyüktür.");
            #endregion

            #region Ornek3
            //Kullanıcın girdiği sayının pozitif mi, negatif mi veya sıfır olup olumadığını ternary if kontrol edin.

            int number = -2;

            if (number == 0)
            {
                Console.WriteLine("Sıfır");
            }
            else if (number > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else
            {
                Console.WriteLine("Negatif");
            }

            Console.WriteLine(number == 0 ? "Sıfır" : number > 0 ? "Pozitif" : "Negatif");
            #endregion
        }
    }
}
