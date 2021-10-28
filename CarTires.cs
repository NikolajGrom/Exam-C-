using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    //Запасные части
    public class CarTires : ProductСategory
    {
        string Name;

        public CarTires(string name, DateTime date, double price, string СatName, string Name): base( name,  date,  price)
        {
            this.Name = Name;
        }
        public override void Вescription()
        {
            WriteLine(" Автомобильные шины : ");
        }
        public override string ToString()
        {
            return base.ToString() +
                        $" {Name}\n";
        }

    }
}