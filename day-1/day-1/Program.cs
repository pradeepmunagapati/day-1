using System;

namespace day_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] a = new int[3];
            int[] b = new int[3];
            int i,j,count=0;
            Console.WriteLine("enter values");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<a.Length;i++)
            {
               for(int k=0;k<b.Length;k++)
                {
                    if (a[i] == b[k])
                        break;
                }
                for (j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        count++;
                    b[i] = a[i];
                }

                Console.WriteLine("count "+count);
                count = 0;
                
            }
        }
    }
}
