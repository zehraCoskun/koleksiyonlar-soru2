using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
     //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        int i = 0;
        int kontrol =1;
        ArrayList sayilar = new ArrayList();
        

        while (i < 10)
        {
            i++;
            basla:
            Console.WriteLine("sayı giriniz");
            string sayi = (Console.ReadLine()); 
            bool dogrulama = int.TryParse(sayi,out kontrol); //alınan verinin tipini kontrol etme
            if (dogrulama==true)
            {
                int n = Convert.ToInt32(sayi);
                sayilar.Add(n);

            }
            else //sayı değer girilmediğinde prorgram tekrar başlar
            {
                Console.WriteLine( "bir tam sayı giriniz");
                goto basla;
            }
      
        }
        
        Console.WriteLine("diziyi yazdırma");
        foreach (var item in sayilar)
            Console.WriteLine(item);
        Console.WriteLine("diziyi büyükten küçüğe sıralama");    
        sayilar.Sort();
        foreach (var item in sayilar)
            Console.WriteLine(item);  
          
        //en küçük 3 sayıyı bulma, toplama, ortalama alma   
        Console.WriteLine("en küçük üç sayı : "+sayilar[0]+", "+sayilar[1]+", "+sayilar[2]);
        int kucukToplam=0;
        for (int j = 0; j < 3; j++)
        {
            int z =Convert.ToInt32(sayilar[j]);
            kucukToplam+=z;
        }
        Console.WriteLine("en küçük üç sayıının toplamı : "+kucukToplam);
        Console.WriteLine("en küçük üç sayının ortalaması : "+kucukToplam/3);

        //büyükten küçüğe yazdırma 
        sayilar.Reverse();
        Console.WriteLine("en büyük üç sayı : "+sayilar[0]+", "+sayilar[1]+", "+sayilar[2]);
        int buyukToplam=0;
        for (int j = 0; j < 3; j++)
        {
            int z =Convert.ToInt32(sayilar[j]);
            buyukToplam+=z;
        }
        Console.WriteLine("en büyük üç sayıının toplamı : "+buyukToplam);
        Console.WriteLine("en büyük üç sayının ortalaması : "+buyukToplam/3);
      

    }
}