using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number != 0)
            {
                //Console.Clear();
                Console.WriteLine("Введите номер задания:\n" +
                    "1 - Написать расчёт чисел Фибоначчи с помощью рекурсии;\n" +
                    "2 - Написать алгоритм поиска N-го простого числа;\n" +
                    "3 - Написать калькулятор с множеством функций;\n" +
                    "4 - Написать методы расчёта площади: прямоугольнику, круга, треугольника ну и любой другой фигуры;\n" +
                    "5 - Найти среднефармфитическое значение массива;\n" +
                    "6 - Дан двуменый массив заполненный случайными числами, необходимо высчитать значение суммы по столбцам и по строчкам.\n" +
                    "0 - Закончить работу программы.");

                string str = Console.ReadLine();
                bool rightEnter = int.TryParse(str, out number);

                while (!rightEnter || number > 6 || number < 0)
                {
                    Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                    str = Console.ReadLine();
                    rightEnter = int.TryParse(str, out number);
                }

                switch (number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Написать расчёт чисел Фибоначчи (до 2500) с помощью рекурсии.");
                        int a = 0,
                            b = 1,
                            sum = 0;
                        Console.Write($"{a}\t{b}");
                        Fibonacci(a, b, sum);
                        Console.Read();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Написать алгоритм поиска Nго простого числа");
                        search();
                        Console.Read();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Написать калькулятор с множеством функций.");
                        calculator();
                        Console.Read();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Написать методы расчёта площади: прямоугольника, круга, треугольника или трапеции.");
                        Console.WriteLine("Введите название фигуры: ");
                        string figure = Console.ReadLine();
                        switch(figure)
                        {
                            case "Прямоугольник":
                            case "прямоугольник":
                                areaRectangle();
                                Console.Read();
                                break;
                            case "Круг":
                            case "круг":
                                areaCircle();
                                break;
                            case "Треугольник":
                            case "треугольник":
                                areaTriangle();
                                break;
                            case "Трапеция":
                            case "трапеция":
                                areaTrapeze();
                                break;
                            default:
                                Console.WriteLine("Вы ввели название, которого нет.");
                                break;
                        }
                        Console.Read();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Найти среднефармфитическое значение массива.");
                        mean();
                        Console.Read();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Дан двуменый массив заполненный случайными числами, необходимо высчитать значение суммы по столбцам и по строчкам.");
                        Sum();
                        Console.Read();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            Console.Read();
        }

        static int Fibonacci(int a, int b, int sum)
        {
            sum = a + b;
            a = b;
            b = sum;
            Console.Write($"\t{b}");
            if(sum < 2000)
            Fibonacci(a, b, sum);
            
            return 0;
        }

        static void search()
        {
            int number;
            Console.WriteLine("Введите номер числа.");
            string str = Console.ReadLine();
            bool check = int.TryParse(str, out number);

            while (!check || number < 0)
            {
                Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                str = Console.ReadLine();
                check = int.TryParse(str, out number);
            }
            int i = 0;
            int num = 2;

            List<int> teams = new List<int>(); // создание списка

            while(i != number)
            {
                int count = 0;
                for (int j = 1; j <= num; j++)//количество делителей
                {
                    if (num % j == 0)
                        count++;
                }
                if (count == 2)
                {
                    teams.Add(num);//добавление элемента
                    i++;
                }

                
                num++;
            }

            //foreach (int team in teams)
                Console.Write($"Ваше число: {teams[i-1]}\t");
        }

        static void calculator()
        {
            Console.WriteLine("Введите пример с учетом следующих пунктов:");
            Console.WriteLine("В калькуляторе есть следующие операции:\n" +
                                "+ - сложение\n" +
                                "- - деление\n" +
                                "* - умножение\n" +
                                "/ - деление\n" +
                                "! - факториал\n" +
                                "^ - возведение в степень\n" +
                                "√ - корень числа, второе число показывает степень корня (Alt+251)");

            double a, b;
            char f;
            Console.Write("Введите первое число:    ");
            string str1 = Console.ReadLine();
            Console.Write("Введите операцию:    ");
            string str2 = Console.ReadLine();
            Console.Write("Введите второе число (при счете факториала второе число равно 0):    ");
            string str3 = Console.ReadLine();

            bool check1 = double.TryParse(str1, out a);
            bool check2 = char.TryParse(str2, out f);
            bool check3 = double.TryParse(str3, out b);
            while (!check1 || !check2 || !check3)
            {
                Console.WriteLine("Вы ввели неправильный пример. Попробуйте снова!");
                str1 = Console.ReadLine();
                str2 = Console.ReadLine();
                str3 = Console.ReadLine();

                check1 = double.TryParse(str1, out a);
                check2 = char.TryParse(str2, out f);
                check3 = double.TryParse(str3, out b);
            }

            double result;

            switch(f)
            {
                case '+':
                    Console.WriteLine($"{a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a / b}");
                    break;
                case '√':
                    Console.WriteLine($"{Math.Pow(a, 1/b)}");
                    break;
                case '!':
                    result = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine($"{result}");
                    break;
                default:
                    Console.WriteLine("Данной операции нет в калькуляторе.");
                    break;
            }

            //Console.Read();
        }

        static void areaRectangle()
        {
            double a, b;
            Console.Write("Введите длину: ");
            string str1 = Console.ReadLine();
            bool check1 = double.TryParse(str1, out a);
            Console.Write("Введите ширину: ");
            string str2 = Console.ReadLine();
            bool check2 = double.TryParse(str2, out b);

            while (!check1 || !check2 || a < 0 || b < 0)
            {
                if (!check1 || a < 0)
                {
                    Console.WriteLine("Вы ввели неправильное значение длины. Попробуйте снова!");
                    str1 = Console.ReadLine();
                    check1 = double.TryParse(str1, out a);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение ширины. Попробуйте снова!");
                    str2 = Console.ReadLine();
                    check2 = double.TryParse(str2, out b);
                }
            }

            Console.WriteLine($"Площадь прямоугольника со сторонами {a} и {b} равна {a * b}");
        }

        static void areaTriangle()
        {
            double a, h;
            Console.Write("Введите длину: ");
            string str1 = Console.ReadLine();
            bool check1 = double.TryParse(str1, out a);
            Console.Write("Введите высоту: ");
            string str2 = Console.ReadLine();
            bool check2 = double.TryParse(str2, out h);

            while (!check1 || !check2 || a < 0 || h < 0)
            {
                if (!check1 || a < 0)
                {
                    Console.WriteLine("Вы ввели неправильное значение стороны. Попробуйте снова!");
                    str1 = Console.ReadLine();
                    check1 = double.TryParse(str1, out a);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение высоты. Попробуйте снова!");
                    str2 = Console.ReadLine();
                    check2 = double.TryParse(str2, out h);
                }
            }

            Console.WriteLine($"Площадь треугольника со стороной {a} и высотой {h} равна {0.5 * a * h}");
        }

        static void areaCircle()
        {
            double r;
            Console.Write("Введите радиус: ");
            string str = Console.ReadLine();
            bool check = double.TryParse(str, out r);

            while (!check || r < 0)
            {
                Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                str = Console.ReadLine();
                check = double.TryParse(str, out r);
            }

            Console.WriteLine($"Площадь круга с радиусом {r} равна {Math.PI * r * r}");
        }

        static void areaTrapeze()
        {
            double a, b, h;
            Console.Write("Введите длину: ");
            string str1 = Console.ReadLine();
            bool check1 = double.TryParse(str1, out a);
            Console.Write("Введите ширину: ");
            string str2 = Console.ReadLine();
            bool check2 = double.TryParse(str2, out b);
            Console.Write("Введите высоту: ");
            string str3 = Console.ReadLine();
            bool check3 = double.TryParse(str2, out h);

            while (!check1 || !check2 || !check3 || a < 0 || b < 0 || h < 0)
            {
                if (!check1 || a < 0)
                {
                    Console.WriteLine("Вы ввели неправильное значение длины. Попробуйте снова!");
                    str1 = Console.ReadLine();
                    check1 = double.TryParse(str1, out a);
                }
                else if (!check2 || b < 0)
                {
                    Console.WriteLine("Вы ввели неправильное значение ширины. Попробуйте снова!");
                    str2 = Console.ReadLine();
                    check1 = double.TryParse(str2, out b);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение высоты. Попробуйте снова!");
                    str3 = Console.ReadLine();
                    check3 = double.TryParse(str3, out h);
                }
            }

            Console.WriteLine($"Площадь трапеции со сторонами {a} и {b} и высотой {h} равна {0.5 * (a + b) * h}");
        }

        static void mean()
        {
            int number;
            Console.Write("Введите количество элементов массива: ");
            string str = Console.ReadLine();
            bool check = int.TryParse(str, out number);

            while (!check)
            {
                Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                str = Console.ReadLine();
                check = int.TryParse(str, out number);
            }

            int[] a = new int[number];
            Random rnd = new Random();
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                a[i] = rnd.Next(1, 101);
                sum += a[i];
            }
            foreach (int element in a)
            Console.Write($"{element}\t");
            Console.WriteLine($"\nСреднее арифметическое массива: {sum / number}.");
        }

        static void Sum()
        {
            int number1, number2;
            Console.Write("Введите количество строк массива: ");
            string str1 = Console.ReadLine();
            bool check1 = int.TryParse(str1, out number1);
            Console.Write("Введите количество столбцов массива: ");
            string str2 = Console.ReadLine();
            bool check2 = int.TryParse(str1, out number2);

            while (!check1 || !check2)
            {
                if (!check1)
                {
                    Console.WriteLine("Вы ввели неправильное значение строк. Попробуйте снова!");
                    str1 = Console.ReadLine();
                    check1 = int.TryParse(str1, out number1);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение столбцов. Попробуйте снова!");
                    str2 = Console.ReadLine();
                    check2 = int.TryParse(str2, out number2);
                }
            }

            int[,] a = new int[number1+1, number2+1];
            Random rnd = new Random();

            int[] b1 = new int[number1];
            int[] b2 = new int[number2];


            for (int i = 0; i < number1; i++)
            {
                a[i, number2] = 0;
                for (int j = 0; j < number2; j++)
                {  
                    a[i, j] = rnd.Next(1, 10);
                    
                    a[i, number2] += a[i,j]; // сумма по строкам
                  
                    Console.Write($"{a[i, j]}\t");
                }
                Console.Write($"|\t{a[i, number2]}\t");
                Console.WriteLine();
            }

            for (int j = 0; j < number2; j++)
            {
                a[number1, j] = 0;
                for (int i = 0; i < number1; i++)
                {
                    a[number1, j] += a[i, j];//сумма по столбцам
                }
                
                Console.Write($"{a[number1, j]}\t");
            }

        }
    }
}
