using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Load
    {
        private int fl = 0;
        public Load() { } //Констурктор класса Load
        public void loadfile(int n, Scince[] scince, Сonf conf)
        {
            
            StreamReader sr = new StreamReader("File.txt");
            if (fl == 0)
            {
                fl = 1;
                sr.ReadLine();
                sr.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                conf.setnameconf(sr.ReadLine());
                conf.setplaceconf(sr.ReadLine());
                conf.setdateconf();
                conf.setd(int.Parse(sr.ReadLine()));
                conf.setmon(int.Parse(sr.ReadLine()));
                conf.sety(int.Parse(sr.ReadLine()));
                conf.seth(int.Parse(sr.ReadLine()));
                conf.setm(int.Parse(sr.ReadLine()));
                scince[i].setfam(sr.ReadLine());
                scince[i].setname(sr.ReadLine());
                scince[i].setotch(sr.ReadLine());
                scince[i].setuchstep(sr.ReadLine());
                scince[i].setid(int.Parse(sr.ReadLine()));
                scince[i].setnameorg(sr.ReadLine());
                scince[i].setcountryorg(sr.ReadLine());
                scince[i].setcityorg(sr.ReadLine());
                scince[i].settheme(sr.ReadLine());
                scince[i].settypeofpart(sr.ReadLine());
                if (sr.ReadLine().ToLower().Trim().Equals("true"))
                    scince[i].setpubl(true);
                else
                    scince[i].setpubl(false);
                scince[i].setdate();
                scince[i].sethour(int.Parse(sr.ReadLine()));
                scince[i].setmin(int.Parse(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
