using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine(a);
namespace sharpL2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte sbyte_var = -101;
            //Console.WriteLine($"sbyte variable value: {sbyte_var}");  
            //byte byte_var = 205;
            //Console.WriteLine($"byte variable value: {byte_var}");
            //short short_var = -30000;
            //Console.WriteLine($"short variable value: {short_var}");
            //ushort ushort_var = 60000;
            //Console.WriteLine($"ushort variable value: {ushort_var}");
            //int int_var = -5;
            //Console.WriteLine($"int variable value: {int_var}");
            //uint uint_var = 5u;
            //Console.WriteLine($"uint variable value: {uint_var}");
            //long long_var = -50L;
            //Console.WriteLine($"long variable value: {long_var}");
            //ulong ulong_var = 50ul;
            //Console.WriteLine($"ulong variable value: {ulong_var}");
            //char char_var = 'A';
            //Console.WriteLine($"char variable value: {char_var}");
            //float float_var = 10.1f;
            //Console.WriteLine($"float variable value: {float_var}");
            //double double_var = 100.1d;
            //Console.WriteLine($"double variable value: {double_var}");
            //bool bool_var = true;
            //Console.WriteLine($"bool variable value: {bool_var}");
            //decimal decimal_var = 104.33m;
            //Console.WriteLine($"decimal variable value: {decimal_var}");
            //Console.WriteLine("enter string");
            //string string_var = Console.ReadLine();
            //Console.WriteLine($"string variable value (from console): {string_var}");
            //object object_var_float = 567.1F;
            //Console.WriteLine($"object variable value (float): {object_var_float}");
            //Console.WriteLine("enter object variable value");
            //object object_var = Console.ReadLine();
            //Console.WriteLine($"object variable value, (from console): {object_var}");
            //Console.WriteLine(":press any button:");
            //Console.Read();

            // преобразования

            // неявные
            //byte vara = 1;
            //short varb = vara;
            //int varc = varb;
            //int vard = vara;
            //long vare = vara;
            //long varf = varc;

            //// явные
            //double x = -1234.7;
            //int a;
            //byte b;
            //short c;
            //long d;
            //ulong e;
            //a = (int)x;
            //b = (byte)x;
            //c = (short)x;
            //d = (long)x;
            //e = (ulong)x;

            //System.Console.WriteLine(a);
            //System.Console.WriteLine(b);
            //System.Console.WriteLine(c);
            //System.Console.WriteLine(d);
            //System.Console.WriteLine(e);

            //// упаковка

            //int value = 10;
            //object obj = value;
            //// распаковка
            //int value2 = (int)obj;

            //// невная типизация 

            //var i = 5;
            //i = i + 17;
            //System.Console.WriteLine(i);
            //// s is compiled as a string
            //var str = "it's a string";
            //System.Console.WriteLine(str);
            //// a is compiled as int[]
            //var arr = new[] { 0, 1, 2 };

            //// nullable

            //int? z1 = 13;
            //bool? enabled1 = null;
            //Double? d1 = 2.4;
            //                                    // варианты эквивалентны
            //Nullable<int> z2 = 13;
            //Nullable<bool> enabled2 = null;
            //Nullable<System.Double> d2 = 2.4;

            //System.Console.WriteLine(enabled1); // выводит пустую область (ничто)
            //System.Console.WriteLine(enabled2);
            //System.Console.WriteLine(d1);
            //System.Console.WriteLine(d2);
            ////
            //var k = "kolya";
            ////k = 4;
            ////int k2 = (int)k;
            //// при объявлении переменной с использованием вар тип переменной определяется самостоятельно
            //// преобразовать этот тип невозможно

            ////strings

            //string kolya = "kolya";
            //string kolennka = "kolennka";
            //int comparsion = String.Compare(kolya, kolennka); // сравниваем строки (1 - первая строка меньше. 0 - строки равны. -1 - первая строка больше)
            //System.Console.WriteLine(comparsion); // выводим результат сравнения строк


            //string who = "kolya";
            //string wwho = " bovkun";
            //string is_who = " is genius";
            //// сцепление
            //string sentence = who + wwho + is_who;
            //System.Console.WriteLine(sentence);
            //// копирование 
            //string who_copy = who;
            //// выделение подстроки 
            //System.Console.WriteLine(is_who.Substring(4, 6));
            //// разделение строки на слова
            //string longstring = "actually i am not genius";
            //// разбитие на слова 
            //string[] words = longstring.Split(new char[] { ' ' });
            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}
            //// добавление подстроки
            //String added = longstring.Insert(24, ", but i'm still pretty smart");
            //Console.WriteLine(added);
            //// удаление подстроки
            //longstring = longstring.Remove(13, 4);
            //Console.WriteLine(longstring);
            //// интерполирование строк
            //int z = 8;
            //int y = 7;
            //string result = $"{z} + {y} = {z + y}";
            //Console.WriteLine(result);

            // массивы

            //// создание и вывод двумерного массива
            //int n = 5;
            //int m = 5;
            //int[,] mas = new int[n, m];
            //Random rn = new Random();
            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        mas[i, j] = rn.Next(11);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //        Console.Write(String.Format("{0,3}", mas[i, j]));
            //    Console.WriteLine();
            //}
            //// массив строк 
            //string[] strings = new string[4];
            //strings[0] = "Kolya";
            //strings[1] = "Anton";
            //strings[2] = "Jenya";
            //strings[3] = "Nastya";
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(strings[i]);

            //}
            //Console.WriteLine("Length of Array: {0}", strings.Length);
            //Console.Write("enter the index: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter the new element value: ");
            //string newelem = Console.ReadLine();
            //strings[index] = newelem;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(strings[i]);
            //}

            // зубчатый массив

            //int[][] stairs = new int[3][];
            //stairs[0] = new int[2];
            //stairs[1] = new int[3];
            //stairs[2] = new int[4];
            //foreach (int[] str in stairs)
            //{
            //    for (int l = 0; l < str.Length; l++)
            //    {
            //        Console.Write("enter the value: ");
            //        str[l] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //foreach (int[] str in stairs)
            //{
            //    foreach (int el in str)
            //    {
            //        Console.Write(el + " ");
            //    }
            //    Console.WriteLine();
            //}

            //// неявно типизированные массив и строка

            //var arr = new Object[0];
            //var streng = new[] { 'B', 'L', 'M'};

            // кортежи

            (int, string, char, string, ulong) t1 = (11, "Коля ", '-', " гей", 131231231);
            Console.WriteLine($"{t1.Item2} {t1.Item3} {t1.Item4}");
            var genius = t1.Item2; // распаковка 
            var num = t1.Item5;
            Console.WriteLine(num);

            var (a, b, c, d, e) = t1;
            (var a1, var b1, var c1, var d1, var e1) = t1;

            var firstTuple = Tuple.Create(3, 9);
            var secondTuple = Tuple.Create(3, 9);
            Console.WriteLine(firstTuple.Equals(secondTuple));

            // функция 

            int[] arr = new int[3] { 1, 3, 2 };
            string l = "wdww";
            static (int, int, int, char) Totuple(int[] ar, string str)
            {
                int a = ar.Min();
                int b = ar.Max();
                int c = ar.Sum();
                char d = str.First();
                return (a, b, c, d);
            }
            Console.WriteLine(Totuple(arr, l));

            // Работа с checked/unchecked

            static void function()
            {
                checked
                {
                    int i = int.MaxValue;
                    try
                    {
                        i += 1;
                    }
                    catch
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            function();
            static void func()
            {
                unchecked
                {
                    int i = int.MaxValue;
                    i += 1;
                    Console.WriteLine(i);
                }
            }
            func();
        }
    }
}
