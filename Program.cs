using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out Parametreler

            string sayi = "999";

            // TryParse metodu sayesinde verilen sayi değişkeni int veri tipine dönüyor mu ? sorusunu sorduk
            // Eğer int veri tipine dönüyorsa true dönmüyorsa false değeri geri döndürür dedik.
            bool sonuc = int.TryParse(sayi, out int sayiCiktisi); // Out parametresi ile sayi int veri tipine 
                                                                  // dönüşüyor ise direk ona atama yaparak ekranda
                                                                  // gösterebildik.

            if(sonuc){
                System.Console.WriteLine("Başarılı!");
                System.Console.WriteLine(sayiCiktisi);
            }else{
                System.Console.WriteLine("Başarısız!");
            }

            metotlar instance = new metotlar(); // Class'ın örneğini oluşturduk.

            instance.Topla(5,4,out int toplamSonucu); // Out parametresi ile burda belirlediğimiz değişkeni 
                                                      // Metot içerisinde atama yapabildik.

            System.Console.WriteLine("Toplama sonucu: "+ toplamSonucu);
            
            System.Console.WriteLine("**** Overloading! ****");
            
            // Overloading : Aynı metotdun bir nevi değişken tipi değişik olanlarını alan 
            // olursa diye kullanılan bir sistem.
            // Burda farklı overloading metodu olması için method_adı + parametre sayısı + parametre türü 
            // farklı olmalı.
            string ad = "Yusuf Tolunay Çağlar";
            int yas = 25;

            instance.EkranaYazdir(sayi); // string gönderiyoruz sıkıntı yok
            instance.EkranaYazdir(yas);  // int gönderiyoruz sıkıntı yok
            instance.EkranaYazdir(yas, ad); // 1 int 1 string gönderiyoruz
            instance.EkranaYazdir(yas,toplamSonucu); // 2 int gönderiyoruz

        }

    }

    class metotlar
    {
        public void Topla(int sayi1,int sayi2, out int toplam){
            toplam = sayi1 + sayi2; 
        }

        // Overloading 1 - String yazmak için
        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }

        // Overloading 2 - Integer yazmak için
        public void EkranaYazdir(int veri){
            System.Console.WriteLine(veri);
        }

        // Overloading 3 - Integer ve String değer alan ve bunları yazdıran metot
        public void EkranaYazdir(int veri1, string veri2){
            System.Console.WriteLine(veri1+" "+veri2);
        }
        
        // Overloading 4 - 2 Integer değer alan ve bunları yazdıran metot
        public void EkranaYazdir(int veri1, int veri2){
            System.Console.WriteLine(veri1+" "+veri2);
        }
    }
}

