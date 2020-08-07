using System;
using System.Globalization;
using System.Linq;

namespace Week2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();
            Exercise10();
            Exercise11();
            Exercise12();
            Exercise13();
        }

        static void Exercise13()
        {
            Console.WriteLine("Ćwiczenie 13:");

            Console.WriteLine("Podaj pierwszą liczbę:");
            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Podaj drugą liczbę");
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("   1. Dodawanie");
            Console.WriteLine("   2. Odejmowanie");
            Console.WriteLine("   3. Mnożenie");
            Console.WriteLine("   4. Dzielenie");

            int chosenOperation = int.Parse(Console.ReadLine());

            switch (chosenOperation)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to: {firstNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to: {firstNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to: {firstNumber * secondNumber}");
                    break;
                case 4:
                    Console.WriteLine($"Twój wynik to: {firstNumber / secondNumber}");
                    break;
                default:
                    Console.WriteLine("Błedny numer operacji.");
                    break;
            }

        }


        static void Exercise12()
        {
            Console.WriteLine("Ćwiczenie 12:");

            Console.WriteLine("Podaj dzień tygodnia (od 1 do 7):");
            int dayOfWeek = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Błędny dzień tygodnia");
                    break;
            }
        }

        static void Exercise11()
        {
            Console.WriteLine("Ćwiczenie 11:");

            Console.WriteLine("Podaj ocenę (od 1 do 6):");
            int grade = int.Parse(Console.ReadLine());

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Błędna ocena");
                    break;
            }
        }

        static void Exercise10()
        {
            Console.WriteLine("Ćwiczenie 10:");

            Console.WriteLine("Podaj 3 długości a powiem Ci czy utworzą trójkąt:");

            int firstLength = int.Parse(Console.ReadLine());
            int secondLength = int.Parse(Console.ReadLine());
            int thirdLength = int.Parse(Console.ReadLine());

            if ((firstLength < (secondLength + thirdLength)) &&
                (secondLength < (firstLength + thirdLength)) &&
                (thirdLength < (firstLength + secondLength)))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }

        static void Exercise9()
        {
            Console.WriteLine("Ćwiczenie 9:");

            Console.WriteLine("Podaj temperaturę:");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 0)
                Console.WriteLine("Cholernie piździ");
            else if (temperature >= 0 && temperature < 10)
                Console.WriteLine("Zimno");
            else if (temperature >= 10 && temperature < 20)
                Console.WriteLine("Chłodno");
            else if (temperature >= 20 && temperature < 30)
                Console.WriteLine("W sam raz");
            else if (temperature >= 30 && temperature < 40)
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            else
                Console.WriteLine("A weź wyprowadzam się na Alaskę.");
        }


        static void Exercise8()
        {
            Console.WriteLine("Ćwiczenie 8:");

            Console.WriteLine("Podaj ocenę:");
            int mathGrade = int.Parse(Console.ReadLine());
            int physicsGrade = int.Parse(Console.ReadLine());
            int chemistryGrade = int.Parse(Console.ReadLine());


            if ((mathGrade + physicsGrade > 150) ||
                (mathGrade + chemistryGrade > 150) ||
                (mathGrade > 70) || (physicsGrade > 55) || (chemistryGrade > 45) ||
                (mathGrade + physicsGrade + chemistryGrade > 180))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Nie tym razem leniuszku, do nauki!!!");
            }

        }

        static void Exercise7()
        {
            Console.WriteLine("Ćwiczenie 7:");

            Console.WriteLine("Podaj 3 liczby:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int[] numbers = { firstNumber, secondNumber, thirdNumber };

            Console.WriteLine($"{numbers.Max()} jest największa z podanych.");
        }


        static void Exercise6()
        {
            Console.WriteLine("Ćwiczenie 6:");

            Console.WriteLine("Podaj wzrost:");
            int height = int.Parse(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("Jesteś krasnoludem");

            else if (height >= 150 && height < 190)
                Console.WriteLine("Twój wzrost jest w normie");

            else
                Console.WriteLine("Jesteś wielkoludem.");
        }
        static void Exercise5()
        {
            Console.WriteLine("Ćwiczenie 5:");

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
            Console.WriteLine("Ćwiczenie 4:");

            Console.WriteLine("Podaj rok:");
            int year = int.Parse(Console.ReadLine());

            string message = (DateTime.IsLeapYear(year)) ?
                $"{year} jest rokiem przestępnym" :
                $"{year} nie jest rokiem przestępnym";

            Console.WriteLine(message);
        }

        static void Exercise3()
        {
            Console.WriteLine("Ćwiczenie 3:");

            Console.WriteLine("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());

            string message = (number > 0) ?
                $"{number} jest liczbą dodatnią" :
                $"{number} nie jest liczbą dodatnią";

            Console.WriteLine(message);
        }


        static void Exercise2()
        {
            Console.WriteLine("Ćwiczenie 2:");

            Console.WriteLine("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
                Console.WriteLine($"{number} jest liczbą nieparzystą");

            else
                Console.WriteLine($"{number} jest liczbą parzystą");
        }

        static void Exercise1()
        {
            Console.WriteLine("Ćwiczenie 1:");

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
