using System;
using System.Linq;

namespace BKT1
{
    class Program
    {
        static void Main(string[] args ) {
            //khai bao mot mang
            int [] Array = new int[0];
            //nhap so phan tu mang
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());   
            ///nhap phan tu mang
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap phan tu thu"+ (i + 1) + "cua mang: ");
                Array[i]= int.Parse(Console.ReadLine()));
            }//tim phan tu lon nhat va vi tri
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