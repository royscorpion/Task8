using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод на консоль содержимого папки на компьютере и содержимого всех подкаталогов, независимо от уровня вложенности
            string path = "D:\\обмен\\";
            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                Console.WriteLine("Содержимое каталога \n{0}", path);
                GetDirFiles(directory);
                GetSubDir(directory, path);
            }
            Console.ReadKey();
        }

        //Рекурсивный метод вывода содержимого каталога и его подкаталогов
        static void GetSubDir(DirectoryInfo directory, string path)
        {
            DirectoryInfo[] directoryInfos = directory.GetDirectories();
            if (directoryInfos.Length != 0)
            {
                foreach (DirectoryInfo d in directoryInfos)
                {
                    //Console.WriteLine("{0}{1}\\", path, d);
                    GetDirFiles(d);
                    GetSubDir(d, path + d + "\\");
                }
            }
        }

        //Метод вывода списка файлов в указанном каталоге
        static void GetDirFiles(DirectoryInfo directory)
        {
            FileInfo[] fileInfos = directory.GetFiles();
            foreach (FileInfo df in fileInfos)
            {
                Console.WriteLine(df.FullName);
            }
        }
    }
}
