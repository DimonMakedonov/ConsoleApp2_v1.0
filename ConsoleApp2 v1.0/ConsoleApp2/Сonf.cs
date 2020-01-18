using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Сonf
    {
        public String nameconf, placeconf;
        public DateTime dateconf = new DateTime();
        public Сonf() { } //Констурктор класса Conf
        public void confreadinfo()
        {
            int d, mon, y, h, m;
            Console.Write("Название конференции: ");
            nameconf = Console.ReadLine();
            Console.Write("Место проведения конференции: ");
            placeconf = Console.ReadLine();
            Console.WriteLine("Дата начала конференции: \n");
            Console.Write("День: ");
            d = int.Parse(Console.ReadLine());
            dateconf = dateconf.AddDays(d - 1);
            Console.Write("Месяц: ");
            mon = int.Parse(Console.ReadLine());
            dateconf = dateconf.AddMonths(mon - 1);
            Console.Write("Год: ");
            y = int.Parse(Console.ReadLine());
            dateconf = dateconf.AddYears(y - 1);
            Console.Write("Час: ");
            h = int.Parse(Console.ReadLine());
            dateconf = dateconf.AddHours(h);
            Console.Write("Минута: ");
            m = int.Parse(Console.ReadLine());
            dateconf = dateconf.AddMinutes(m);
            Console.WriteLine();
        }

        public void info()
        {
            Console.Write("Название конференции: ");
            Console.WriteLine(nameconf);
            Console.Write("Место проведения конференции: ");
            Console.WriteLine(placeconf);
            Console.Write("Дата начала конференции: ");
            Console.Write(dateconf.ToShortDateString());
            Console.Write(" ");
            Console.WriteLine(dateconf.ToShortTimeString());
        }
        //get-методы
        public string getnameconf() { return nameconf; }
        public string getplaceconf() { return placeconf; }
        public string getdateconf() { return dateconf.ToUniversalTime().ToString(); }
        public int getd() { return dateconf.Day; }
        public int getmon() { return dateconf.Month; }
        public int gety() { return dateconf.Year; }
        public int geth() { return dateconf.Hour; }
        public int getm() { return dateconf.Minute; }
        //set-методы
        public void setnameconf(String nameconff) { nameconf = nameconff; }
        public void setplaceconf(String placeconff) { placeconf = placeconff; }
        public void setdateconf() { dateconf = new DateTime(); }
        public void setd(int dd) { dateconf = dateconf.AddDays(dd - 1); }
        public void setmon(int monn) { dateconf = dateconf.AddMonths(monn - 1); }
        public void sety(int yy) { dateconf = dateconf.AddYears(yy - 1); }
        public void seth(int hh) { dateconf = dateconf.AddHours(hh); }
        public void setm(int mm) { dateconf = dateconf.AddMinutes(mm); }
    }
}
