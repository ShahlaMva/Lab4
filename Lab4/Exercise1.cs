using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{    
    class Exercise1
    {  //Nurkhanin kodlari,Nurkhan yazdi
        public void Summary()
        {
            Console.WriteLine("IMTAHAN");
            Random random = new Random();
            int counttrue = 0;
            int countfalse = 0;
            string cavab;
            do
            {
                int num1 = random.Next(1,100);
                int num2 = random.Next(1,100);
                Console.WriteLine($"{num1}+{num2}");
                int summary = num1 + num2;
                string existnumber = Console.ReadLine();
                int existnumbertoint = int.Parse(existnumber);
                if (summary== existnumbertoint)
                {
                    Console.WriteLine("Cavabiniz Duzdur");
                    counttrue++;
                    

                }
                else
                {
                    countfalse++;
                    Console.WriteLine("Cavabiniz sehvdir");
                }
                Console.WriteLine("Davam etmek istiyirsinizmi? he/yox");
                cavab = Console.ReadLine();
            } 

            while (cavab.ToLower() == "he");
            if (cavab == "yox")
            {
                Console.WriteLine($"Neticeniz:\nDuzgun cavablarin sayi: {counttrue}\nSehv cavablarin sayi: {countfalse}\nTopladiginiz Bal: {(counttrue * 5) - (countfalse * 2)}");
            }
            else
            {
                Console.WriteLine("He yada yox yaz !");
            }






        }
    }
}
