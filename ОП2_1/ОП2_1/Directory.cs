using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОП2_1
{
    public class Directory
    {

        public List<string> directory = new List<string>() { "Навчання", "Робота" };

        public void show()
        {
            int i = 1;
            foreach (string n in directory)
            {
                Console.WriteLine(i + ")" + n);
                i++;
            }

        }
    }
}


