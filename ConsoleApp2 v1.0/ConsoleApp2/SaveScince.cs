using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SaveScince
    {
        public void ss() { }
        public void savescince(Scince scince, string file)
        {
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
        }
    }
}
