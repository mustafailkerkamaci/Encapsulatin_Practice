using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Practice
{
    internal class Car
    {
        public string Brand { get; set; } // arabanin markasini tutan ozellik 
        public string Model { get; set; } // arabanin modelini tutan ozellik
        public string Color  { get; set; } // arabanin rengini tutan ozellik

        private int _doors; // arabanin kapi sayisini  tutan ozellik, bu alana dogrudan erisilemez sadece sinif icersinden erisilebilir.    

        public int Doors { get { return _doors; }
            set // eger atanmak sistenen kapi sayisi 2 veya 4se _ doors alanini set kisminin icindekiler atanacak
            {
                if(value == 2 || value == 4)
                {
                    _doors = value;
                }
                else // eger 2 veya 4 disinda bir deger ise uyari mesaji verir ve _doorsu -1 olarak ayarlar.
                {
                    Console.WriteLine("!!!WARNING! The number of doors can only be 2 or 4.");
                    _doors = -1;
                }
            }
        }

        // Constructor:

        public Car(string brand, string model, string color, int doors)
        {
            Brand = brand; // gelen degerleri sinifin ozelliklerine atar.
            Model = model;
            Color = color;
            Doors = doors; // set metodu cagrilir ve kapi sayisi kontrol edilir.
        }

        // arabanin bilgilerini yazmasi icin bir metot daha tanimliyorum.

        public void ShowInfo()
        {
            Console.WriteLine("-----Car Information-----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            if (Doors == -1)
            {
                Console.WriteLine("WARNING! The number of doors can only be 2 or 4");
            }
            else
            {
                Console.WriteLine($"Doors: {Doors}");
            }
        }


    }
}
