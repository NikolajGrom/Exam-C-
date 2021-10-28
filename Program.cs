using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Exam !");
            
         /*SparPearts[] sP =
         {
           new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозная система "," ap21"),
           new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозная система "," ap21"),
           new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2000, " Тормозная система "," aps21"),
           new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2500, " Тормозная система "," AP01"),
           new CarTires( " MICHLIN ", new DateTime( 2020,10,11), 5500, " Автомобильные шины "," Sport4"),
           new CarTires( " PIRELLI ", new DateTime( 2020,02,12), 5500, " Автомобильные шины "," Zero"),
           new Drosel(" BOCSH ", new DateTime( 2021,02,12), 15500, " Дросель "," DZ 121"),
           new Drosel(" BOCSH ", new DateTime( 2021,05,12), 14000, " Дросель2 "," DZ 221"), 
           new Drosel(" Карбюратор ", new DateTime( 1988,05,13), 300, " Дросель "," Карбюратор № 1")
         };
            
         foreach (SparPearts item in sP)
            {
                item.Вescription();
                WriteLine(item);
            }*/

            AutoShop<ProductСategory> auto = new AutoShop<ProductСategory>
            {
               Name = " AUTO # 1 "
            };
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозная система "," ap21"));
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозная система "," ap21"));
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2000, " Тормозная система "," aps21"));
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2500, " Тормозная система "," AP01"));
            auto.Add(new CarTires( " MICHLIN ", new DateTime( 2020,10,11), 5500, " Автомобильные шины "," Sport4"));
            auto.Add(new CarTires( " PIRELLI ", new DateTime( 2020,02,12), 5500, " Автомобильные шины "," Zero"));
            auto.Add(new Drosel(" BOCSH ", new DateTime( 2021,02,12), 15500, " Дросель "," DZ 121"));
            auto.Add(new Drosel(" BOCSH ", new DateTime( 2021,05,12), 14000, " Дросель2 "," DZ 221"));
            auto.Add(new Drosel(" Карбюратор ", new DateTime( 1988,05,13), 300, " Дросель "," Карбюратор № 1"));

            Console.WriteLine( auto.Name);
            auto.ShowAll();


            Console.Read();
        }
    }
}
