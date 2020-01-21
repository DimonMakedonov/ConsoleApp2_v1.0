using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SaveConf
    {
        public void sc() { }
        public void saveconf(Сonf conf, string file) {
            System.IO.File.AppendAllText(file, "\n");
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
        }
    }
}
