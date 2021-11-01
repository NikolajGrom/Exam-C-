using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_C_
{
    // Категория товара
    [Serializable]
    public abstract class ProductСategory : SparPearts
    {
       
       public string СategoryName;

        public ProductСategory(string name, DateTime date, double price) 
                              : base(name, date, price)
        {
        }

        public ProductСategory( string name, DateTime date, double price, string СategoryName)
                              : base(name, date, price)
        {
            this.СategoryName = СategoryName;
        }

        public override string ToString()
        {
            return base.ToString() +
                  $" Категория товара: " +
                  $"{ СategoryName }\n";
        }
        public abstract void Вescription(); //описание

        //public override void Вescription()
        //{
        //   // WriteLine(" Запчасти : ");
        //}
    }
}
