namespace prjDelegates
{
    public delegate void CalculateDelagate(int no1, int no2);
    public delegate int IntDelegate();
    internal class Program
    {
        public static int WhatWhat()
        {
            return 0;
        }
        public static void test(int no1, int no2)
        {
            Console.WriteLine("Tests 1...2.....3");
        }
        public static void CalcSum(int no1, int no2)
        {
            Console.WriteLine("Sum is :" + (no1 + no2));

        }
        public static void CalcProd(int no1, int no2)
        {
            Console.WriteLine("Product is :" + (no1 * no2));
        }

        public static void CalcSub(int no1, int no2)
        {
            Console.WriteLine("Sub is :" + (no1 - no2));

        }

        static void Main(string[] args)
        {
            CalculateDelagate del = new CalculateDelagate(CalcSum);
            if (6 < 16)
            {
                del += CalcSub;
                del -= CalcSum;

            }
            else
            {
                del += CalcProd;
            }
            del += test;
            CalcSub(50, 20);
            del(901, 20);
            IntDelegate DelNotInt = new IntDelegate(WhatWhat);
            Console.WriteLine("Int value :" + DelNotInt());
            Console.WriteLine("");
        }
    }
}