using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    public class AutoShop<T> where T :ProductСategory 
    {
       public string Name { get; set; }
        public List<T> Auto;
        public AutoShop()
        {
            this.Auto = new List<T>();
        }

        public void Add(T item)
        {
            this.Auto.Add(item);
        }
        public void ShowAll()
        {
            foreach (T item in this.Auto)
            {
                Console.WriteLine($" {item} ");
                Console.WriteLine("--------------------");
            }
        }
    }
}