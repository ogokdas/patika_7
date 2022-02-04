using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int saat = DateTime.Now.Hour;

                switch (saat)
                {
                    case 9:
                        Console.WriteLine("Günaydın");
                        break;
                    case 12:
                        Console.WriteLine("Tünaydın");
                        break;
                    case 18:
                        Console.WriteLine("İyi akşamlar");
                        break;
                    default:
                        Console.WriteLine("Vakit nekadar hızlı geçmiş");
                        break;
                }

                Console.ReadLine();

            }
        }
    }
