using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_C_
{
    // Категория товара
    public abstract class ProductСategory : SparPearts
    {
       
        string СategoryName;

        public ProductСategory(string name, DateTime date, double price) 
                              : base(name, date, price)
        {
        }

        public ProductСategory( string name, DateTime date, double price, string СatName)
                              : base(name, date, price)
        {
            СategoryName = СatName;
        }

        public override string ToString()
        {
            return base.ToString() +
                  $"Категория товара:" +
                  $"{ СategoryName }\n";
        }


    }
}
