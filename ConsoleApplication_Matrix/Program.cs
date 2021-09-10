using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            b:
            int a=0;
            string pth_file = "";

            Console.WriteLine("Программа работет с файлами разрешения \".txt\".\n");
            Console.Write("Введите полный путь к файлу ");
            pth_file = @"\\main\RDP\44П\ГоршенинАА\Desktop\пере\1.txt"; 
            

            List<int> res_lst = ClassReadFile.ReadFiles(pth_file);
            int count = ClassReadFile.Counter(res_lst);

            string res = "Количество совпадений равно " + count.ToString() + ".";
            ClassReadFile.WriteFile(res);
            Console.WriteLine("\n\nКонец работы программы.");
            Console.WriteLine("\n\nПродолжить работу? 1-да");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto b;
            else
                Console.ReadKey();
        }
    }
}
