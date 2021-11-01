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
    public class BrakePads : ProductСategory
    {
        string BpName;

        public BrakePads(string name, DateTime date, double price, string СategoryName, string BpName)
                         : base( name,  date,  price, СategoryName)
        {
            this.BpName = BpName;
        }
        public override void Вescription()
        {
            WriteLine(" Тормозная система : ");
        }

        public override string ToString()
        {
            return base.ToString() +
                        $" Название : " +
                        $" {BpName}\n";
        }

    }
}
