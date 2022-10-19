using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_2_Klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] broj = { 0, 0, 0, 0, 0 };
            KlasaC klasac = new KlasaC();
           
            for (int i = 0; i < broj.Length; i++)
            {
                Console.WriteLine("Unesi broj: ");
                broj[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine(klasaC.Zbroj(broj));
            Console.WriteLine(klasaC.Prosjek(broj));

            Console.ReadKey();

        }

        
    
    
    
    
    
    }
}

 class KlasaC
        {
            public int Zbroj(int[] broj)
            {
                int zbroj = 0;
                for (int i = 0; i < broj.Length; i++)
                {
                    zbroj += broj[i];
                }
                return zbroj;
            }
            public double Prosjek(int[] broj)
            {
                double prosjek = 0;
                for (int i = 0; i < broj.Length; i++)
                {
                    prosjek += broj[i];
                }
                prosjek /= broj.Length;
                return prosjek;
            }

        }



    

}