using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n;
            int[] a= new int[1000];
            n=Convert.ToInt32(Console.ReadLine());
            Random random= new Random();
            for (int i = 0;i < n; i++)
            {
                a[i]=50-random.Next(100);
                Console.Write(a[i]+" ");
            }
            double s = 0;
            for (int i = 0;i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    s += Math.Pow(Convert.ToDouble(a[i]), 2);
                }
            }
            Console.WriteLine();
            Console.WriteLine(s);
            int count=0;
            for (int i = 0;i < n; i++)
            {
                if (a[i]%2==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            double s1 = 1;
            s = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    s1 *= Convert.ToDouble(a[i]);
                    s += Convert.ToDouble(a[i]);
                }
            }
            Console.WriteLine(s+" "+ s1);
            s=0;
            count=0;
            for (int i = 0; i < n; i++)
            {
                if (a[i]%2==1)
                {
                    s += Convert.ToDouble(a[i]);
                    count++;
                }
            }
            Console.WriteLine(s/count);
            s=0;
            count=0;
            for (int i = 0; i < n; i++)
            {
                if (a[i]%2==1)
                {
                    s += Math.Pow(Convert.ToDouble(a[i]),2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(s / count));
            s=1; count=0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    s *= Convert.ToDouble(a[i]);
                    count++;
                }
            }
            Console.WriteLine(s +" "+ count);
            count=0;
            for(int i = 0; i < n;i++)
            {
                if (a[i]==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            s=0; count=0;   
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 3==0)
                {
                    s+= Convert.ToDouble(a[i]);
                    count++;
                }
            }
            Console.WriteLine(s/count);

            s = 0; count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 5 == 0)
                {
                    s += Math.Pow(Convert.ToDouble(a[i]), 2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(s / count));
            count=0;
            for (int i = 0; i < n;i++) 
            {
                if (a[i]%7==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.Write("k = ");
            int k=Convert.ToInt32(Console.ReadLine());
            s = 0;
            for (int i = 0;i < n;i++)
            {
                if (a[i]%k==0) 
                {
                    s+= Convert.ToDouble(a[i]);
                }
            }
            Console.WriteLine(s);
            s = 1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % k == 0)
                {
                    s *= Convert.ToDouble(a[i]);
                }
            }
            Console.WriteLine(s);
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % k == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            s = 1;
            for (int i = 0;i<n; i++)
            {
                if (a[i]%5==2)
                {
                    s*= Convert.ToDouble(a[i]);
                }
            }
            Console.WriteLine(s);
            s = 0;
            for (int i = 0;i<n;i++)
            {
                if ((i + a[i])%3==0)
                {
                    s += Math.Pow(Convert.ToDouble(a[i]),2);
                }
            }
            Console.WriteLine(s);
            s = 0;
            count= 0;
            for (int i = 1;i<n;i++)
            {
                if(Math.Sqrt(Convert.ToDouble(i))%1==0)
                {
                    s += a[i];
                    count++;
                }
            }
            Console.WriteLine(s/count);
            count= 0;
            s= 0;
            for(int i = 0;i<n;i++)
            {
                if (a[i]>i)
                {
                    s += Math.Pow(Convert.ToDouble(a[i]), 2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(s/count));
            s=0;
            for (int i = 0; i < n; i++)
            {
                if ((i + a[i])%k==0)
                {
                    s+= a[i];
                }
            }
            Console.WriteLine(s);
            s=0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(a[i]-i)>k)
                {
                    s += a[i];
                }
            }
            Console.WriteLine(s);
            s = 1;
            for (int i = 0; i < n; i++)
            {
                if ((i * a[i])%3==2)
                {
                    s *= a[i];
                }
            }
            Console.WriteLine(s);



            Console.ReadKey();
        }
    }
}
