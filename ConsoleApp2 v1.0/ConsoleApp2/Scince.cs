using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Scince
    {
        private string name, fam, otch, uchstep;
        private int id;
        Org org;
      	Part part;
        public Scince() { //Констурктор класса Scince
            org = new Org();
            part = new Part();
        }
        public void info()
        {
            Console.Write("Фамилия: ");
            Console.WriteLine(fam);
            Console.Write("Имя: ");
            Console.WriteLine(name);
            Console.Write("Отчество: ");
			Console.WriteLine(otch);
            Console.Write("Учёная степень: ");
            Console.WriteLine(uchstep);
            Console.Write("Номер на конференции: ");
            Console.WriteLine(id);
            Console.Write("Название организации: ");
            Console.WriteLine(org.nameorg);
            Console.Write("Страна: ");
            Console.WriteLine(org.countryorg);
            Console.Write("Город: ");
            Console.WriteLine(org.cityorg);
            Console.Write("Тема выступления: ");
            Console.WriteLine(part.theme);
            Console.Write("Тип выступления: ");
            Console.WriteLine(part.typeofpart);
            Console.Write("Публикация: ");
            Console.WriteLine(part.publ);
            Console.Write("Время: ");
            Console.WriteLine(part.date.ToShortTimeString());
        }
        public void readinfo()
        {
            Console.Write("Фамилия: ");
            fam = Console.ReadLine();
            Console.Write("Имя: ");
            name = Console.ReadLine();
            Console.Write("Отчество: ");
            otch = Console.ReadLine();
            Console.Write("Учёная степень: ");
            uchstep = Console.ReadLine();
            Console.Write("Номер на конференции: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Название организации: ");
            org.nameorg = Console.ReadLine();
            Console.Write("Страна: ");
            org.countryorg = Console.ReadLine();
            Console.Write("Город: ");
            org.cityorg = Console.ReadLine();
            Console.Write("Тема выступления: ");
            part.theme = Console.ReadLine();
            Console.Write("Тип выступления: ");
            part.typeofpart = Console.ReadLine();
            Console.Write("Публикация (true/false): ");
            string a = Console.ReadLine();
            if (a.ToLower().Trim().Equals("true"))
                setpubl(true);
            else
                setpubl(false);
            Console.Write("Час: ");
            int hh = int.Parse(Console.ReadLine());
            part.date = part.date.AddHours(hh);
            Console.Write("Минута: ");
            int mm = int.Parse(Console.ReadLine());
             part.date = part.date.AddMinutes(mm);
            Console.WriteLine();
        }
        //get-методы
        public string getfam() { return fam; }
        public string getname() { return name; }
        public string getotch() { return otch; }
        public string getuchstep() { return uchstep; }
        public int getid() { return id; }
        public string getnameorg() { return org.nameorg; }
        public string getcountryorg() { return org.countryorg; }
        public string getcityorg() { return org.cityorg; }
        public string gettheme() { return part.theme; }
        public string gettypeofpart() { return part.typeofpart; }
        public bool getpubl() { return part.publ; }
        public string getdate() { return part.date.ToShortTimeString(); }
        public int gethour() { return part.date.Hour; }
        public int getmin() { return part.date.Minute; }
        //set-методы
        public void setfam(string famm) { fam = famm; }
        public void setname(string namee) { name = namee; }
        public void setotch(string otchh) { otch = otchh; }
        public void setuchstep(string uchstepp) { uchstep = uchstepp; }
        public void setid(int idd) { id = idd; }
        public void setnameorg(string nameorgg) { org.nameorg = nameorgg; }
        public void setcountryorg(string countryorgg) { org.countryorg = countryorgg; }
        public void setcityorg(string cityorgg) { org.cityorg = cityorgg; }
        public void settheme(string themee) { part.theme = themee; }
        public void settypeofpart(string typeofpartt) { part.typeofpart = typeofpartt; }
        public void setpubl(bool publl) { part.publ = publl; }
        public void setdate() { part.date = new DateTime(); }
        public void sethour(int h) { part.date = part.date.AddHours(h); }
        public void setmin(int m) { part.date = part.date.AddMinutes(m); }
    }
}
