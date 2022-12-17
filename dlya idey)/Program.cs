using System.Diagnostics;

namespace лаба4
{
    internal class Program
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("1 - Отгадай ответ");
            Console.WriteLine("2 - Об авторе");
            Console.WriteLine("3 - Выход");
            Console.WriteLine("4 - Проверка Try/Catch/Finally");
            Console.WriteLine("5 - Сортировки массивов");
            Console.WriteLine("6 - Крестики-нолики");
            Console.Write("Выберите пункт: ");
        }
        static int Int()
        {
            bool info = false;
            int x = 0;
            while (!info)
            {
                info = int.TryParse(Console.ReadLine(), out x);
                if (!info)
                {
                    Console.WriteLine("Ошибка.");
                }
            }
            return x;
        }
        static double Doublehz()
        {
            bool info = false;
            double x = 0;
            while (!info)
            {
                info = double.TryParse(Console.ReadLine(), out x);
                if (!info)
                {
                    Console.WriteLine("Ошибка.");
                }
            }
            return x;
        }
        static void Case1()
        {
            Console.Clear();
            double f = 0, b = 0, a = 0;
            int s = 0;
            Console.WriteLine("F = (ln^2(b))/(cos(a)-1)");
            Console.Write("Введите b: ");
            b = Znacheniya();
            Console.Write("Введите a: ");
            a = Znacheniya();
            f = Primer(a, b);
            f = Math.Round(f);
            Ugadayka(f);
            Console.WriteLine("Приблизительное значениe функции: " + f);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
        static double Primer(double a, double b)
        {
            double logarifm = 0, cosinus = 0, f = 0;
            logarifm = Math.Pow(Math.Log(b), 2);
            cosinus = Math.Cos(a) - 1;
            f = logarifm / cosinus;
            return f;
        }
        static double Znacheniya()
        {
            double s = 0;
            bool znachenie1 = false;
            while (!znachenie1)
            {
                try
                {
                    s = Doublehz();
                    int proverka = (int)s;
                    int hqd = 5 / proverka;
                    znachenie1 = true;
                }
                catch (DivideByZeroException)
                {
                    znachenie1 = false;
                    Console.WriteLine("Вы ввели неверное значение.");
                }
            }
            return s;
        }
        static void Ugadayka(double f)
        {
            for (int num = 2; num >= 0; num--)
            {
                Console.Write("Введите приблизительное значение функции: ");
                int k = Int();
                if (k == f)
                {
                    Console.WriteLine("Вы угадали значение функции!");
                    num = -1;
                }
                else
                {
                    Console.WriteLine("Вы не угадали значение функции.");
                    Console.WriteLine("Осталось попыток: " + num);
                }
                if (num == 0)
                {
                    Console.WriteLine("Вы не смогли угадать ни одного значения");
                }
                Console.WriteLine();
            }
        }

        static void InfoAboutAuthor()
        {
            Console.Clear();
            Console.WriteLine("Молчанов Александр");
            Console.WriteLine("Группа 6101-090301D");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }

        static bool Over()
        {
            bool vixod = false, chek1 = false;
            while (!vixod)
            {
                Console.Clear();
                int choose = 0;
                bool exit = false;
                Console.WriteLine("Вы уверены, что желаете выйти?");
                Console.WriteLine("Введите 1, если хотите выйти");
                Console.WriteLine("Введите 2, чтобы остаться в программе");
                while (!exit)
                {
                    exit = int.TryParse(Console.ReadLine(), out choose);
                    if (!exit)
                    {
                        Console.WriteLine("Вы ввели неверное значение");
                    }
                }
                switch (choose)
                {
                    case 1:
                        chek1 = true;
                        vixod = true;
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали остаться в программе.");
                        vixod = true;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное значениe");
                        break;
                }
            }
            return chek1;
        }

        static void Proverka()
        {
            Console.Clear();
            double result = 0;
            int c = 0;
            Console.WriteLine("Проверка деления на ноль");
            Console.WriteLine("100/c");
            Console.Write("Введите число с: ");
            c = Int();
            try
            {
                result = 100 / c;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Ответ: " + result);
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }

        static void CocktailSort(int[] array)
        {
            int left = 0, i, right = array.Length - 1;
            while (left < right)
            {
                for (i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                right--;
                for (i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }
                left++;
            }
        }
        static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int sort = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = sort;
                    }
                }
            }
        }
        static ulong InputArray()
        {
            ulong n = 0;
            bool kk = false;
            while (!kk)
            {
                kk = ulong.TryParse(Console.ReadLine(), out n);
                if (!kk)
                {
                    Console.WriteLine("Ошибка");
                }
            }
            if(n < 0)
            {
                Console.WriteLine("Error");
            }
            return n;
        }
        static int[] CreateArr()
        {
            ulong n = 0;
            Console.Write("Введите количество элементов массива: ");
            n = InputArray();
            int[] array = new int[n];
            return array;
        }
        static int[] CopyArr(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
        static void RandomArr(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }
        static void OutputArr(int[] array)
        {
            if (array.Length < 20)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
        static void Sorts()
        {
            Console.Clear();
            int[] array = CreateArr();
            RandomArr(array);
            int[] array2 = CopyArr(array);
            DateTime dateTime = DateTime.Now;
            Bubble(array);
            TimeSpan sp = DateTime.Now - dateTime;
            Console.WriteLine("Время, за которое отсортировался 1-ый массив(пузырьком): " + sp);
            DateTime dateTime2 = DateTime.Now;
            CocktailSort(array2);
            TimeSpan sp2 = DateTime.Now - dateTime;
            Console.WriteLine("Время, за которое отсортировался 2-ой массив(перемешиванием): " + sp2);
            Console.WriteLine("Сортированный массив: ");
            OutputArr(array);
            Console.ReadKey();
        }
        static void OutputArray(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static (int x, int y) Pole(string[,] arr)
        {
            int vvodX = 0, vvodY = 0;
            bool proverka = false;
            while (!proverka)
            {
                proverka = true;
                Console.Write("Введите значение по высоте: ");
                vvodX = InputCoord();
                Console.Write("Введите значение по ширине: ");
                vvodY = InputCoord();
                if (!(arr[vvodX, vvodY] == "."))
                {
                    Console.WriteLine("Эта ячейка занята");
                    proverka = false;
                }
            }
            proverka = false;
            return (vvodX, vvodY);
        }
        static int InputCoord()
        {
            bool enterX = false;
            int vvodX = 0;
            while (!enterX)
            {
                enterX = int.TryParse(Console.ReadLine(), out vvodX);
                if (!enterX)
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }
                if (vvodX > 2 || vvodX < 0)
                {
                    Console.WriteLine("Введите значение от 0 до 2");
                    enterX = false;
                }
            }
            return vvodX;
        }
        static int VictoryTest(int game, string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, 0] == arr[i, 1] && arr[i, 0] == arr[i, 2] && !(arr[i, 0] == "."))
                {

                    Console.WriteLine("Вы выиграли");
                    game = 11;
                }
                if (arr[0, i] == arr[1, i] && arr[0, i] == arr[2, i] && !(arr[0, i] == "."))
                {
                    Console.WriteLine("Вы выиграли");
                    game = 11;
                }
            }
            if (arr[0, 0] == arr[1, 1] && arr[0, 0] == arr[2, 2] && !(arr[1, 1] == "."))
            {
                Console.WriteLine("Вы выиграли");
                game = 11;
            }
            if (arr[0, 2] == arr[1, 1] && arr[0, 2] == arr[2, 0] && !(arr[1, 1] == "."))
            {
                Console.WriteLine("Вы выиграли");
                game = 11;
            }
            return game;
        }
        static void XO()
        {

            string[,] arr = new string[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = ".";
                }
            }
            for (int game = 0; game < 10; game++)
            {
                Console.Clear();
                Console.WriteLine("  0 1 2");
                OutputArray(arr);
                int vvodX = 0, vvodY = 0;
                Console.WriteLine("Ход для Х");
                (vvodX, vvodY) = Pole(arr);
                arr[vvodX, vvodY] = "x";
                Console.WriteLine("  0 1 2");
                OutputArray(arr);
                game = VictoryTest(game, arr);
                if (game == 11)
                {
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Ход для O");
                (vvodX, vvodY) = Pole(arr);
                arr[vvodX, vvodY] = "o";
                Console.WriteLine("  0 1 2");
                OutputArray(arr);
                game = VictoryTest(game, arr);
                if (game == 11)
                {
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            bool chek = false;
            while (!chek)
            {
                int x;
                Menu();
                x = Int();
                switch (x)
                {                       //3
                    case 1:
                        Case1();
                        break;
                    case 2:
                        InfoAboutAuthor();
                        break;
                    case 3:
                        chek = Over();
                        break;
                    case 4:
                        Proverka();
                        break;
                    case 5:
                        Sorts();
                        break;
                    case 6:
                        XO();
                        break;
                }
            }
        }
    }
}