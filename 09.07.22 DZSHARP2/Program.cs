using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Program1();
            Program2();
            //Program3();
            //Program4();
            //Program5();
            //Program6();
            //Program7();
            Console.OutputEncoding = Encoding.Unicode;
            Console.ReadKey(true);

        }

        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string str = Console.ReadLine();
                if (int.TryParse(str, out int value))
                {
                    return value;
                }
                Console.WriteLine("\t\tError!!!");
            }
        }

        static void Program1()
        {
            int n = 5;
            int[] Data = new int[n];
            int i = 0;
            int j = 0;
            int min = 0;
            Console.WriteLine("Enter 5 digits array:");
            while (i < n)
            {
                Data[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(Data[i]);
            }
            Array.Sort(Data);
            int max = int.MinValue;
           foreach(int a in Data)
            {
                if(a > max)
                {
                    max = a;
                   
                }
            }
            Console.WriteLine($"Max:{max}");

            int minimum = int.MaxValue;
            foreach(int b in Data)
            {
                if(b < minimum)
                {
                    minimum = b;
                }
            }
            Console.WriteLine($"Min:{minimum}");

            int dabl = 0;

            for ( i = 0; i < Data.Length; i++) 
            if (Data[i]%2 == 0)
                {
                    dabl+= Data[i];
                }
            
           Console.WriteLine($"Dabl:{dabl}");


            int summ = 0;
            for (i = 0; i < Data.Length; i++)
                summ += Data[i];
            Console.WriteLine($"Summ:{summ}");
            //--------------------------------------
            //--------------------------------------
            Random rnd = new Random();
            double[,] arr = new double[3, 4];
            for (i = 0; i < 3; i++)
            {
                for(j = 0; j < 4; j++)
                {
                    arr[i, j] = rnd.NextDouble()*100;  
                    Console.WriteLine(arr[i, j]); 
                }
                Console.WriteLine();
            }

            double maximum = double.MinValue;
            foreach (double c in arr)
            {
                if (c > maximum)
                {
                    maximum = c;

                }
            }
            Console.WriteLine($"Max:{maximum}");

            double minimumm = double.MaxValue;
            foreach (double d in arr)
            {
                if (d < minimumm)
                {
                    minimumm = d;
                }
            }
            Console.WriteLine($"Min:{minimumm}");

            double dabll = 0;

            for (i = 0; i < 3; i++)
            {
                for(j = 0; j  < 4; j++)
                {
                    if (arr[i,j] % 2 == 0)
                    
                        dabll += arr[i,j];
                    
                }
            }
            Console.WriteLine($"Dabl:{dabll}");

            double summm = 0;
            for (i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    summm += arr[i,j];
                }
            }
            Console.WriteLine($"Summ:{summm}");

            double sumstolb = 0;
            if(j%2 != 0)
            {
               for(i = 0; i < 3; i++)
                {
                    sumstolb += arr[i, j];
                }
            }
            Console.WriteLine($"Sum nechetnih stolb:{sumstolb}");
        }

        static void Program2()
        {
            Console.WriteLine("Random array 5x5 from -100 to 100");
            int i = 0;
            int j = 0;
            int sum = 0;
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.WriteLine($"{arr[i, j]}\t\t");
                }
                Console.WriteLine();
            }
            int max = int.MinValue;
            foreach (int a in arr)
            {
                if (a > max)
                {
                    max = a;

                }
            }

            int minimum = int.MaxValue;
            foreach (int b in arr)
            {
                if (b < minimum)
                {
                    minimum = b;
                }
            }
            if (minimum < max)
            {
                for( i = minimum + 1; i < max; i++)
                {
                    for(j = minimum + 1; j < max; j++)
                    {
                        sum = sum + arr[i,j];
                    }
                }
            }
            else
            {
                for (i = max + 1; i < minimum; i++)
                {
                    for (j = max + 1; j < minimum; j++)
                    {
                        sum = sum + arr[i,j];
                    }
                }
            }
            Console.WriteLine($"Sum between min and max:{sum}");
        }
    }
}