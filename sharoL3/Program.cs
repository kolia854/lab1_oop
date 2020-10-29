using System;
using System.IO;

namespace sharpL3
{
    public class Vector    // создание класса
    { 
        public int[] Value;
        public int Length;
        public string Error;
        public static byte Amount = 0; 
        public readonly int Id;
        public const int MaxValue = 99;

        // методы
        public int[] Sum(ref int a)
        { 
            for (int i = 0; i <= Length; i++)
            {
                Value[i] += a;
            }
            return Value;
        }
        public int[] Multiply(int a)
        {
            for (int i = 0; i <= Length; i++)
            {
                Value[i] = Value[i]*a;
            }
            return Value;
        }

        public void Print()
        {
            foreach(int a in this.Value)
            {
                Console.WriteLine($"Elem: {a}");
            }
            //Console.WriteLine(arr);
            Console.WriteLine($"massive length {this.Length}");
            Console.WriteLine($"error: {this.Error}");
        }

        // конструкторы
        public int length   // get set 
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("vector must have 1 or more elements");
                }
                else
                {
                    Length = value;
                }
            }
            get { return Length; }
        }

        public Vector(int[] Arr, string b, int a)  // конструктор с параметрами
        {
            Value = new int[a];
            for (int i = 0; i < a; i++)
            {
                Value[i] = Arr[i];

            }
            Error = b;
            Length = a;
            Amount++;
        }

        public Vector()    // конструктор без параметров 
        {
            Value = new int[5];
            Error = "err";
            Length = 5;
        }
        static Vector() // статический конструктор 
        {
            Console.WriteLine("Created new vector");
            Amount++;
        }

        public Vector(int[] a, int b = 4, string c = "abc")    // конструктор с параметрами по умолчанию 
        {
            Value = new int[b];
            for (int i = 0; i < b; i++)
            {
                Value[i] = a[i];

            }
            Error = c;
            Length = b;
            Amount++;
        }

        //Vector aVector = new Vector(); // закрытый конструктор используются, 
        // чтобы не допустить создания экземпляров класса при 
        // отсутствии полей или методов экземпляра
        //void Output()

    }


    class Program
    {
        static void Main()
        {


            Vector[] vcs = new Vector[3];
            vcs[0] = new Vector();
            int[] Arr = { 1, 2, 3, 0 };
            vcs[1] = new Vector(Arr, "no error", 4);

            vcs[2] = new Vector(Arr, b: 4, c: "cdw");
            Console.WriteLine(vcs[2].Value[0]);
            vcs[2].Print();
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 4; x++)
                {

                    if (vcs[i].Value[x] == 0)
                    {
                        Console.WriteLine($"zero element is in vector {i}");
                        break;
                    }
                }

            }
        }
    }
}
