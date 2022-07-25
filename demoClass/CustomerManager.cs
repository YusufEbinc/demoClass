using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClass
{
    class CustomerManager
    {
       

            public void Add()
            {
                Console.WriteLine("bu metod çalıştıysa switch case yapısı kullanılmıştır");

            int Number = 12;
            switch (Number)
            {
                case 1:
                    Console.WriteLine("bu sayı bir değil");
                    break;
                case 56:

                    Console.WriteLine("bu sayı 56 degil");
                    break;

                case 12:

                    Console.WriteLine("bu sayı:" + Number);
                    break;
                default:
                    Console.WriteLine("bu sayı bulunamdı: " + Number);
                    break;

            }

        }


    }
}
