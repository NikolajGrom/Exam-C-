using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    //Запасные части
    [Serializable]
    public class CarTires : ProductСategory
    {
        string Name;

        public CarTires(string name, DateTime date, double price, string СategoryName, string Name)
                        : base( name,  date,  price, СategoryName)
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
                        $" Название : " +
                        $" {Name}\n";
        }

    }
}