using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
            HW1.QueueTime(new int[] { 10, 2, 3 }, 2);
            HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
        }
    }
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int k = 0;
            int ind = 0;
            int[] cassa = new int[n];

            for (int i = 0; i < n; i++)
            {
                cassa[i] = customers[i];
                k++;
            }
            ind = k;
            bool chek = false;
            k = 0;
            while (true)
            {
                chek = true;
                for (int i = 0; i < n; i++)
                {
                    cassa[i] -= 1;
                    if ((cassa[i] == 0) && (ind < customers.Length))
                    {
                        cassa[i] = customers[ind];
                        ind++;
                    }
                    if (i == n - 1)
                    {
                        k++;
                    }
                    if (cassa[i] > 0)
                    {
                        chek = false;
                    }
                }
                if ((chek == true))
                {
                    break;
                }
            }
            Console.WriteLine(k);
            return k;
        }
    }
}