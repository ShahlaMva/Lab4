using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Task1
    {
        public void Ex1()
        {
            int trueCount = 0;
            int falseCount = 0;
            int point = 0;
            int sumResult = 0;

            string isContiuned;
            Random random = new Random();

            do
            {
                int num1 = random.Next(1, 100);
                int num2 = random.Next(1, 100);
                sumResult = num1 + num2;
                Console.WriteLine($"{num1}+{num2} cavabi?");

                string userSum = Console.ReadLine();
                int userResult;
                bool result = int.TryParse(userSum, out userResult);
                if (result)
                {
                    if (sumResult == userResult)
                    {
                        trueCount++;
                        point += 5;
                        Console.WriteLine("Duzdur");
                    }
                    else
                    {
                        falseCount++;
                        point -= 2;
                        Console.WriteLine("Sehvdir");
                    }
                }
                else
                {
                    Console.WriteLine("Eded daxil edin!");


                }
                Console.WriteLine("Davam etmek isteyirsinizmi?yes/no");
                isContiuned = Console.ReadLine();

            } while (isContiuned=="yes"||isContiuned=="Yes");

            Console.WriteLine($"Duzgun cavablarin sayi:{trueCount}");
            Console.WriteLine($"Sehv cavablarin sayi:{falseCount}");
            Console.WriteLine($"Xal:{point}");

        }
    }
}
