using System;
delegate void Enigma(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 9;


        public static void F1(int p)
        {
            num += p;
            Console.WriteLine("caso 1: {0}", num);
        }


        public static void F2(int q)
        {
            num /= q;
            Console.WriteLine("caso 2: {0}", num);
        }
        static void Main(string[] args)
        {
            Enigma nc = delegate (int x) {
                Console.WriteLine("caso 3: {0}", x);
            };
            nc(20);
            nc = new Enigma(F1);
            nc(6);
            nc = new Enigma(F2);
            nc(3);
        }
    }
}
