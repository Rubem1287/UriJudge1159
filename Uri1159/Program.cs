using System;

namespace Uri1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,total,cont,n;

            cont = 0;
            
            a = int.Parse(Console.ReadLine());
            total = a;
            if (a%2==0&&a!=0)
            {
                while (cont != 4)
                {
                    a += +2;
                    total += +a;
                    cont += +1;

                }

            }
            else if(a!=0)
            {
                a += +1;
                total += +1;
                while (cont != 4)
                {
                    a += +2;
                    total += +a;
                    cont += +1;
                }

            }


            Console.WriteLine(total);
                    

        }
    }
}
