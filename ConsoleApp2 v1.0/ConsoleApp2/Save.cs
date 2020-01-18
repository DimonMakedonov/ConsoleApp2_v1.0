using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Save
    {
        private int fs = 0;
        public Save() { } //Констурктор класса Save
        public void savetofile(Scince scince, Сonf conf, int n)
        {
            if (fs == 0)
            {
                fs = 1;
                System.IO.File.WriteAllText("File.txt", "");
                System.IO.File.AppendAllText("File.txt", n.ToString());
                System.IO.File.AppendAllText("File.txt", "\n");
            }

            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.getnameconf());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.getplaceconf());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.getd().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.getmon().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.gety().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.geth().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", conf.getm().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getfam());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getname());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getotch());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getuchstep());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getid().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getnameorg());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getcountryorg());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getcityorg());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.gettheme());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.gettypeofpart());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getpubl().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.gethour().ToString());
            System.IO.File.AppendAllText("File.txt", "\n");
            System.IO.File.AppendAllText("File.txt", scince.getmin().ToString());
        }
    }
}
