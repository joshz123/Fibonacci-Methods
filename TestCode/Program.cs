using System;

namespace TestCode
{
    class Program
    {
        static int fibrecurs(int a){
            if (a == 1 || a == 0){
                return 1;
            }

            return fibrecurs(a - 1) + fibrecurs(a - 2);
        }

        static int[] array = new int[4000];


        static int FibTopDown(int n){
            if (n == 1 || n == 0){
                return 1;
            }
            if (array[n] != 0){
                return array[n];
            }
            else{
                array[n] = FibTopDown(n - 1) + FibTopDown(n - 2);
                return array[n];
            }
        }
        static int fibbottom(int n){
            int[] array = new int[n + 1];
            array[0] = 1;
            array[1] = 1;
            for (int index = 2; index <= n; index++){
                array[index] = array[index - 1] + array[index - 2];
            }

            return array[n];
        }

        static double binet( int n){
            ++n;
          double phi = (1 + Math.Sqrt(5))*0.5;
          double fib = (Math.Pow(phi,n) - Math.Pow(1-phi,n))/Math.Sqrt(5);
            return Math.Round(fib);
    }

        public static void Main(string[] args){
            var x = 400;

            var mytime = DateTime.Now;
            /*Console.WriteLine("recursive:{0}",fibrecurs(x));
            Console.WriteLine(DateTime.Now-mytime);*/
            mytime = DateTime.Now;
            Console.WriteLine("topdown:{0}",FibTopDown(x));
            Console.WriteLine(DateTime.Now-mytime);
            mytime = DateTime.Now;
            Console.WriteLine("bottomup{0}",fibbottom(x));
            Console.WriteLine(DateTime.Now-mytime);
            mytime = DateTime.Now;
            Console.WriteLine("bonets: {0}",binet(x));
            Console.WriteLine(DateTime.Now-mytime);
            
        }
    }
}