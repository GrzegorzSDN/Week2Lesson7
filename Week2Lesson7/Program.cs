using System;

namespace Week2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Exercise5()
        {
            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 21 && age < 30)
                Console.WriteLine("Możesz zostać posłem");
            else if (age >= 30 && age < 35)
                Console.WriteLine("Możesz zostać posłem lub senatorem");
            else if (age >= 35)
                Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem");
            else
                Console.WriteLine("Jesteś zbyt młody na politykę");
        }

        static void Exercise4()
        {
            Console.WriteLine("Podaj rok:");
            int year = int.Parse(Console.ReadLine());

            string message = (DateTime.IsLeapYear(year)) ? 
                $"{year} jest rokiem przestępnym" : 
                $"{year} nie jest rokiem przestępnym";

            Console.WriteLine(message);
        }

        static void Exercise3()
        {
            Console.WriteLine("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());

            string message = (number > 0) ?
                $"{number} jest liczbą dodatnią" :
                $"{number} nie jest liczbą dodatnią";

            Console.WriteLine(message);
        }


        static void Exercise2()
        {
            Console.WriteLine("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
                Console.WriteLine($"{number} jest liczbą nieparzystą");
            else
                Console.WriteLine($"{number} jest liczbą parzystą");
        }

        static void Exercise1()
        {

            Console.WriteLine("Podaj pierwszą liczbę:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
                Console.WriteLine($"{firstNumber} i {secondNumber} są równe");
            else
                Console.WriteLine($"{firstNumber} i {secondNumber} nie są równe");
        }

    }
}
