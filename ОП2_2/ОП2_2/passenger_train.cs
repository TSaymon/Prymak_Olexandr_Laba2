using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОП2_2
{
    public class PassTrain
    {
        public string train { get; set; }


        List<Carriage> passcar = new List<Carriage>()
        {
       new Carriage(){carriage="C-class"},
       new Carriage(){carriage="B-class"},
       new Carriage(){carriage ="A-class" },
        };
        

        public void show()
        {
            Console.WriteLine(" Типи вагону ");
            for (int i = 0; i < passcar.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(passcar[i].carriage + " ");
                Console.ResetColor();
            }
        }
        public void comfortable()
        {
            IEnumerable<Carriage> passcar3 = passcar.OrderBy(passcar => passcar.carriage);
            foreach (Carriage k in passcar3)
            {
                Console.WriteLine(k.carriage);
            }
        }

    }
}
