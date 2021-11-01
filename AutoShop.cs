using Exam;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_C_
{
    [Serializable]
    public class AutoShop<T> where T :ProductСategory 
    {
        public string Name { get; set; }
        public List<T> Auto { get; set; }

        public AutoShop()
        {
            Auto = new List<T>();
        }

        public void Add(T item)
        {
            Auto.Add(item);
        }
        public void ShowCategory()
        {
            //Убрать дубли
             var res = Auto.Distinct(new SparPeartsEqualityComparer()).ToList();
            foreach (var item in res)
            {
                //item.Вescription();
                WriteLine($" {item.СategoryName} ");
            }
            WriteLine($"\n{new string('-', 30)}\n");
           
        }
        public void ShowAll()
        {
            foreach (T item in this.Auto)
            {
                item.Вescription();
                WriteLine($" {item} ");
                WriteLine($"\n{new string('=', 30)}\n");
            }
        }
       
    }
}