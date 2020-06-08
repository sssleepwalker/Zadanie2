using System;
using static lib2;
namespace zadanie2
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            string po = "";
            char ws = 'f';
            Console.WriteLine("Введите строку: ");
            po = Console.ReadLine();
            po = po.ToLower();
            int kj = 0;
            int fc = 0;
            for (int i = 0; i < po.Length; i++)
            {
                if (po[i] == ws) kj++;
                if (kj == 2)
                {
                    fc = i;
                }
            }
            if (kj == 0) Console.WriteLine("-2");
            else if (kj == 1) Console.WriteLine("-1");
            else if (kj > 1) Console.WriteLine(fc +"\n");

            Console.WriteLine("\n" + "Задание №2" + "\n" + lib2.dva("ЁжИк") + "\n");

            Console.WriteLine("\n" + "Задание №3");
            Console.WriteLine("Введите строку: ");
            string pk = "";
            pk = Console.ReadLine();
            int ki = pk.IndexOf("h");
            int ho = pk.LastIndexOf("H");
            string kiho = "";
            for (int min = 0; min < pk.Length; min++)
            {
                string won = (pk[min] + "");
                if (String.Compare("h", won) == 0 && min != ki && min != ho) kiho = kiho + "H";
                else kiho = kiho + pk[min];
            }
            Console.WriteLine(kiho);


        }


    }
   
    
}

            

            

        
