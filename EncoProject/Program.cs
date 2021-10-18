using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load...");

            //ввод чисел 
            int[] nums = new int[7];
            Console.WriteLine("Введите семь чисел");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0}-е число: ", i +1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            //Sort
            int temp;
            for (int i = 0; i  < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[j];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }      
                }
            }

            //Output
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}