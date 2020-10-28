using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter1();
            Counter2();
            Console.WriteLine("Give me the first number");
            
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me the second number");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Counter3(x, y);

            Console.WriteLine("Give me a random number");
            int z = Convert.ToInt32(Console.ReadLine());
            Counter4(z);

            Console.WriteLine("Give me a random number");
            int q = Convert.ToInt32(Console.ReadLine());
            Counter5(q);

            Console.WriteLine("How old are you?");
            Counter6(int.Parse(Console.ReadLine()));

            Console.WriteLine("Give me a random number");
            Counter7(int.Parse(Console.ReadLine()));

            Counter8(12);

            var newArray = Counter9(8);
           foreach (var number in newArray)
            {
                Console.WriteLine(number);
            }

            int sum = Counter10(newArray);
            Console.WriteLine($"The sum of this array is {sum}");

            Console.WriteLine("What would you like the cube of?");
            Counter11(int.Parse(Console.ReadLine()));

        }

        public static void Counter1()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void Counter2()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
            
        }

        public static void Counter3(int x, int y)
        {
         if (x == y)
            {
                Console.WriteLine("These are equal");
            }
         else
            {
                Console.WriteLine("These are not equal");
            }
        }

        public static void Counter4(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }

        public static void Counter5(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("This is a positive number");
            }
            else
            {
                Console.WriteLine("This is a negative number");
            }
        }

        public static void Counter6(int x)
        {
            if (x >= 18)
            {
                Console.WriteLine("Congratulations you can vote!");
            }
            else
            {
                Console.WriteLine("Sorry you cannot vote");
            }
        }

        public static void Counter7(int x)
        {
            if (x <= 10 && x >= -10)
            {
                Console.WriteLine("Your number is in the correct range");
            }
            else
            {
                Console.WriteLine("Your number is not in the correct range");
            }
        }

        public static void Counter8(int x)
        {
            for (int f =1; f <= x; f++)
            {
                var y = f * 12;
                
                Console.WriteLine($"{y}");
            }

        }

        public static int[] Counter9(int x)
        {
            var random = new Random();

            var array = new int[x];
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = random.Next(1, 100);
            }
            return array;

        }

        public static int Counter10(int[] x)
        {
            var sum = 0;
            for (int a = 0; a < x.Length; a++)
            {
                sum += x[a];
            }

            return sum;
        }

        public static void Counter11(int x)
        {
            var cube = 1;
            for (int a = 1; a <= x; a++)
            {
                cube = a * a * a;
                Console.WriteLine(cube);
            }

        }

    }
}
