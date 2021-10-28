using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    //Запасные части
    public class BrakePads : ProductСategory
    {
        string Name;

        public BrakePads(string name, DateTime date, double price, string СatName, string Name): base( name,  date,  price)
        {
            this.Name = Name;
        }
        public override void Вescription()
        {
            WriteLine("Тормозные колодки : ");
        }
        public override string ToString()
        {
            return base.ToString() +
                        $" {Name}\n";
        }

    }
}
