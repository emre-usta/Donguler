using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------FOR--------");

            // Kullanıcının girdiği sayıya kadar olan tek sayıları yazdırma
            
            Console.Write("Lütfen Bir Sayı Giriniz...");
            int enteredValue = int.Parse(Console.ReadLine());
            for(int i = 1; i <= enteredValue; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }


            // 1 ile 10000 sayıları arasındaki tek ve çift sayıların ayrı ayrı toplamını ekrana yazdırmak

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 10000; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            Console.WriteLine("---------WHILE--------");

            // 1 den başlyarak konsoldan girilen sayı da dahil sayıların ortalmasını yazdırın

            Console.WriteLine("Bir sayı girininiz..");
            //int sayi = int.Parse(Console.ReadLine());
            string sayi1 = Console.ReadLine();
            int sayi = int.Parse(sayi1);
            int sayac = 1;
            float toplam = 0;

            while(sayac <= sayi){
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine("Bir'den girdiğiniz sayıya kadar olan sayıların ortalamsı : " + toplam / sayi);

            Console.WriteLine("---------FOR-EACH--------");
            
            string[] cars = {"BMW" , "Mercedes", "Ford", "Opel", "Hyundai", "Phorsche", "Toyota", "Audi"};

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }   
    }
}