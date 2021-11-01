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
    public class Drosel : ProductСategory
    {
        string DrName;

        public Drosel(string name, DateTime date, double price, string СategoryName, string DrName)
                     : base( name,  date,  price, СategoryName)
        {
            this.DrName = DrName;
        }
        public override void Вescription()
        {
            WriteLine(" Дросельная заслонка : ");
        }
        public override string ToString()
        {
            return base.ToString() +
                        $" Название : " +
                        $" { DrName }\n";
        }

    }
}