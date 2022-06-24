using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОП2_1
{
    public class File
    {
        public List<string> file1 = new List<string>() { };


        public void show()
        {
            int i = 1;
            foreach (string n in file1)
            {
                Console.WriteLine(i + ")" + n);
                i++;
            }

        }
        public void Add1(string n)
        {
            file1.Add(n);
        }

        public void content(string p)
        {
            Console.WriteLine(p);
        }
        public void remove(string t)
        {
            file1.Remove(t);
        }
        public void rename(string q, string z)
        {
            file1.Insert(file1.IndexOf(q), z);
            file1 = file1.Where(x => x != q).ToList();
        }
        public void addtext(string p, string h)
        {
            Console.WriteLine(p + " " + h);
        }
    }
}


