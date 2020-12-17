using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 6, 7, 8, 6, 3 };
            bool checkedArray = CheckThisArray(array);
            if (checkedArray)
            {
                int binarianArray = GetBinarianArray(array);
                Console.WriteLine($"BinarianArray= {binarianArray}");
            }

            Console.ReadKey();
        }

        static int GetBinarianArray(int[] arr)
        {
            try
            {
                Console.WriteLine("GetBinarianArray başladı.");//log
                int binarian = 0;
                int number = 1;
                int i = 1;
                foreach (var item in arr)
                {
                    //Math.pow double değer döndürdüğü için kullanılmamıştır
                    if (item == 0)
                    {
                        binarian += 1;
                        continue;
                    }
                    else
                    {
                        while (i <= item)
                        {
                            number *= 2;
                            i++;
                        }
                        binarian += number;
                        number = 1;
                        i = 1;
                    }
                }
                return binarian;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CheckThisArray de hata oluştu: {ex}"); //log
            }
            return -1;
        }

        static bool CheckThisArray(int[] arr)
        {
            Console.WriteLine("CheckThisArray başladı."); //log

            if (arr.Length > 100000)
            {
                Console.WriteLine("Diziye 100,000 den fazla item girilmemelidir."); ;
                return false;
            }
            foreach (var item in arr)
            {
                if (item < 0)
                {
                    Console.WriteLine("Girilen dizide negatif değer var."); ;
                    return false;
                }

                if (item > 100000)
                {
                    Console.WriteLine("Girilen dizide değerler 100,000 den büyük olmamalıdır."); ;
                    return false;
                }
            }
            return true;
        }
    }
}
