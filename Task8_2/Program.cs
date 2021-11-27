using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Calcs";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (!File.Exists(path += "\\Calc_Task8.2.txt"))
                using (File.Create(path)) { };
            int n = 10;
            int Sum = 0;
            Random random = new Random();
            //int[] numbers = new int[n];
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(random.Next(0, 100));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < n; i++)
                {
                    Sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма случайных чисел в файле {0} составляет {1}",path,Sum);
            Console.ReadKey();
        }
    }
}
