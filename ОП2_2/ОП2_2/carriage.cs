using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОП2_2
{
    public class Carriage
    {
        public string carriage { get; set; }


        int[] numberofcarriage = new int[5];
        public int people()
        {
            Random rnd = new Random();
            int valueofpassenger = 0;
            for (int i = 0; i < numberofcarriage.Length; i++)
            {
                numberofcarriage[i] = rnd.Next(0, 50);
                Console.WriteLine(" вагон " + "  " + (i + 1) + " " + " к-ть пасажирiв " + " " + numberofcarriage[i]);
                valueofpassenger += numberofcarriage[i];

            }
            return valueofpassenger;
        }
        public void choiseacarriage(int a, int b)
        {
            bool f = false;
            for (int i = 0; i < numberofcarriage.Length; i++)
            {
                if (a <= numberofcarriage[i] && b >= numberofcarriage[i])
                {
                    Console.WriteLine(" вагон" + "  " + (i + 1) + "  " + numberofcarriage[i]);
                    f = true;
                }
            }
            if (f == false)
            {
                Console.WriteLine(" Подiбного вагону немає");
            }
        }

    }
}
