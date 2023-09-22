using System;
using System.Linq;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao mot mang
            int[] Array = new int[100];
            //nhap so phan tu mang
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            //nhap phan tu mang
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap phan tu thu" + (i + 1) + "cua mang: ");
                //Sửa lỗi ở đây
                Array[i] = int.Parse(Console.ReadLine());
            }

            //tim phan tu lon nhat va vi tri
            int max = Array[0];
            int index = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                    index = i;
                }
            }

            Console.WriteLine("phan tu lon nhat la: " + max);
            Console.WriteLine("vi tri phan tu : " + index);
            Console.ReadKey();
        }
    }
}