using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    //Запасные части
    public class Drosel : ProductСategory
    {
        string Name;

        public Drosel(string name, DateTime date, double price, string СatName, string Name)
                     : base( name,  date,  price)
        {
            this.Name = Name;
        }
        public override void Вescription()
        {
            WriteLine(" Дросельная заслонка : ");
        }
        public override string ToString()
        {
            return base.ToString() +
                        $" { Name }\n";
        }

    }
}