using System;

namespace CsharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verilmis n - ededinin 3 ve 7 'e bolunmesi
            static void IsDivided(int n)
            {
                if (n <= 1)
                {
                    Console.WriteLine("Enter the correct number");
                }
                else if (n % 3 == 0 && n % 7 == 0)
                {
                    Console.WriteLine("Number is divided to 3 and 7");
                }
                else
                {
                    Console.WriteLine("Number is not divided to 3 and 7");
                }
            }
            
            }
            // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapan algoritm
            static int OddSum(int n, int m)
            {
                int sum = 0;
                if (n < 1 || m < 1)
                {
                    Console.WriteLine("Enter the correct number");
                }
                else
                {
                    for (int i = n; i < m; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += i;
                        }
                    }
                }
                return sum;
            }
            // Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapan algoritm
            static void IsSimpleOrComplex(int n)
            {
                int count = 0;
                if (n <= 1)
                {
                    Console.WriteLine("Enter correct number");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count > 2)
                    {
                        Console.WriteLine("Complex");
                    }
                    else
                    {
                        Console.WriteLine("Simple");
                    }
                }
            // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapan algoritm
            static int OddNum(int n, int m)
            {
                int count = 0;
                if (n < 1 || m < 1)
                {
                    Console.WriteLine("Enter the correct number");
                }
                else
                {
                    for (int i = n; i < m; i++)
                    {
                        if (i % 2 != 0)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
            // Verilmish arrayin icindeki cut ededlerin cemini tapan algoritm
            static void EvenSum(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        sum += array[i];
                    }
                }
                Console.WriteLine(sum);
            }
    }
}
