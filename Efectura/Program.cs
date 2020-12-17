using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(1, 100000);
            int[] randomArray = CreateNArray(n);

            //int[] trial= new int[] { 1,3,4,2,5 };
            //bool check = CheckThisArray(trial);

            bool check = CheckThisArray(randomArray);
            if (check)
            {
                var parlama = ShiningsBulbs(randomArray);
                Console.WriteLine($"Parlama sayısı: {parlama}");
            }


            Console.ReadKey();
        }



        static int[] CreateNArray(int numberOfArray)
        {
            Random rnd = new Random();
            int[] numbers = new int[numberOfArray];
            int counter = 0;
            int number;
            while (counter < numberOfArray)
            {
                number = rnd.Next(1, numberOfArray);
                if (Array.IndexOf(numbers, number) == -1)
                {
                    numbers[counter] = number;
                    counter++;
                }
            }
            return numbers;
        }

        static bool CheckThisArray(int[] array)
        {
            if (array.Length > 100000)
            {
                Console.WriteLine("Dizi uzunluğu 100,000 den fazla olamaz.");
                return false;
            }
            if (array.Length == 0)
            {
                Console.WriteLine("Diziye en az bir karakter girilmelidir.");
                return false;
            }

            foreach (var item in array)
            {
                if (array.Equals(item))
                {
                    Console.WriteLine("Dizideki her bir eleman birbirinden farklı olmalıdır.");
                    return false;
                }
            }
            return true;
        }


        static int ShiningsBulbs(int[] arr)
        {
            int min = arr.Min();
            int ardisik = 1;
            int turned = 0;
            int shining = 0;
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                turned++;

                if (i == 0)
                {
                    newArr[i] = arr[i];
                    if (arr[i] == min)
                    {
                        shining++;
                        continue;
                    }
                    else
                        continue;
                }

                else
                {
                    newArr[i] = arr[i];
                    for (int j = 0; j < newArr[i]; j++)
                    {
                        if (newArr[j] - arr[i] == 1 || newArr[j] - arr[i] == -1)
                        {
                            ardisik++;
                            if (newArr.Contains(min)&& ardisik==turned)
                            {
                                shining++;
                                continue;
                            }
                            else
                                continue;
                        }
                        else
                            continue;
                    }
                }


            }
            return shining;
        }
    }



}
