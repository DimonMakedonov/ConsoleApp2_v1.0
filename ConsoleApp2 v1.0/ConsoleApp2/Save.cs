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
        public string file;
        public Save(string filee, int n)//Констурктор класса Save
        {
            file = filee;
            System.IO.File.AppendAllText(file, n.ToString() + "\n");
        } 

        public void savetofile(Scince scince)
        {
            scince.Write(this);
        }
        public void WriteLine(string s)
        {
            System.IO.File.AppendAllText(file, s+"\n");
        }
        /*public void savetofile(Scince scince, Сonf conf, int n, string file)
        {
            SaveConf sc = new SaveConf();
            SaveScince ss = new SaveScince();
            if (fs == 0)
            {
                fs = 1;
                System.IO.File.WriteAllText(file, "");
                System.IO.File.AppendAllText(file, n.ToString());
                System.IO.File.AppendAllText(file, "\n");
            }
            //sc.saveconf(conf, file);
            //ss.savescince(scince, file);
            /*System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.getnameconf());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.getplaceconf());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.getd().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.getmon().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.gety().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.geth().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, conf.getm().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getfam());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getname());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getotch());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getuchstep());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getid().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getnameorg());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getcountryorg());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getcityorg());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.gettheme());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.gettypeofpart());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getpubl().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.gethour().ToString());
            System.IO.File.AppendAllText(file, "\n");
            System.IO.File.AppendAllText(file, scince.getmin().ToString());
        }*/
    }
}
