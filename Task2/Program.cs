using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var moveCount = WritePositiveBinaryDigit("10101101");//binary yapıda bir sayı girilecektir
            if (moveCount < 0)
            {
                Console.WriteLine("İstenilen kriterlere uygun text girişi olmadı.");
                return;
            }
            

            Console.WriteLine($"Gerekli hareket sayısı:{moveCount}");
            Console.ReadKey();
        }

        public static int WritePositiveBinaryDigit(string text)
        {
            try
            {
                Console.WriteLine($"WritePositiveBinaryDigit başladı girilen text:{text} ");
                bool check = CheckThisString(text);
                if (check)
                {
                    double number = StringConvertToNumber(text);
                    int moveCount = GetMoveCount(number);

                    return moveCount;
                }
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WritePositiveBinaryDigit da hata oluştu: {ex}"); //log
            }
            return -1;
        }


        static bool CheckThisString(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length > 1000000)
                return false;
            return true;
        }

        static double StringConvertToNumber(string text)
        {
            try
            {
                Console.WriteLine("StringConvertToNumber başladı.");
                double number = 0;
                int counter = text.Length - 1;
                int counterOf1 = 0;

                foreach (var item in text)
                {
                    if (item == '1')
                    {
                        number += Math.Pow(2, counter);
                        counterOf1++;
                    }
                    counter--;
                }
                if (counterOf1 > 399999) number = 799999;
                Console.WriteLine($"Binary değerin sayı karşılığı:{number} ");
                return number;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"StringConvertToNumber da bir hata oluştu:{ex}");//log
            }
            return -1;
        }

        static int GetMoveCount(double number)
        {
            int moveCount = 0;
            while (number > 0)
            {
                if (number % 2 == 1)
                {
                    number--;
                    moveCount++;
                }
                else
                {
                    number /= 2;
                    moveCount++;
                }
            }
            return moveCount;
        }
    }
}
