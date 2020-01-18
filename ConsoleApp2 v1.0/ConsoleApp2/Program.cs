using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//0.3
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Load load = new Load(); //Создание объектов классов загрузки, сохранение и конференции
            Save save = new Save(); //
            Сonf conf = new Сonf(); //
            string a;
            int n = 0;
            conf.confreadinfo(); //Метод ввода данных о конференции
            conf.info(); //Метод вывода данных о конференции
            Console.Write("Введите количество учёных: ");
            n = int.Parse(Console.ReadLine());
            Scince[] scince = new Scince[n]; //Создание массива учёных
            for (int i = 0; i < n; i++)
            {
                scince[i] = new Scince(); //Создание объекта класса Scince в каждом элементе массива 
                scince[i].readinfo(); //Метод ввода данных об учёном
            }
            for (int i = 0; i < n; i++)
                scince[i].info(); //Метод вывода данных об учёном
            Console.Write("Сохранить данные в файл? (д/н) ");
            a = Console.ReadLine();
            if (a == "д")
            {
                System.IO.File.Create("File.txt").Close(); //Создание файла
                for (int i = 0; i < n; i++)
                    save.savetofile(scince[i], conf, n);   //Метод сохоанения данных в файл
                Console.WriteLine("Сохранено");
            }
            if (System.IO.File.Exists("File.txt")) //Проверка существует ли файл
            {
                Console.Write("Загрузить данные из файла? (д/н) ");
                a = Console.ReadLine();
                if (a == "д")
                {
                    StreamReader sr = new StreamReader("File.txt"); //Считывание количества учёных в файле
                    n = int.Parse(sr.ReadLine());                   //
                    sr.Close();                                     //
                    scince = new Scince[n];                         //Создание нового массива учёных
                    for (int i = 0; i < n; i++)                     //
                    {                                               //
                        scince[i] = new Scince();                   //Создание объекта класса Scince в каждом элементе массива
                    }                                               //
                    load.loadfile(n, scince, conf);                 //метод загрузки данных из файла
                    Console.WriteLine("Загружено");
                }
            }
            else
            {
                Console.WriteLine("Для выхода нажмите на любую клавишу . . . ");
                Console.ReadKey();
                Environment.Exit(0); //Выход из программы если нет ранее сохранённого файла
            }
            conf.info();
            for (int i = 0; i < n; i++)
                scince[i].info(); //Вывод информации послезагрузки из файла
            Console.WriteLine("Для выхода нажмите на любую клавишу . . . ");
            Console.ReadKey();
        }
    }
}
