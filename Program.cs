using Exam;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Console;

namespace Exam_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Exam !");
            #region
            /*
            SparPearts[] sP =
            {
              new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозная система "," ap21"),
              new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозная система "," ap21"),
              new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2000, " Тормозная система "," aps21"),
              new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2500, " Тормозная система "," AP01"),
              new CarTires( " MICHLIN ", new DateTime( 2020,10,11), 5500, " Автомобильные шины "," Sport4"),
              new CarTires( " PIRELLI ", new DateTime( 2020,02,12), 5500, " Автомобильные шины "," Zero"),
              new Drosel(" BOCSH ", new DateTime( 2021,02,12), 15500, " Дросель "," DZ 121"),
              new Drosel(" BOCSH ", new DateTime( 2021,05,12), 14000, " Дросель2 "," DZ 221"), 
              new Drosel(" Карбюратор ", new DateTime( 1988,05,13), 300, " Дросель "," Карбюратор № 1")
            };
            
            foreach (SparPearts item in sP)
            {
               //item.Вescription();
                WriteLine(item);
            }
            
            */
            #endregion

            WriteLine($"\n{new string('*',30)}\n");
            AutoShop<ProductСategory> auto = new AutoShop<ProductСategory>
            {
               Name = " AUTO # 1 "
            };
            
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозные колодки ", " ap21"));
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 1500, " Тормозные колодки ", " ap21"));
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2000, " Тормозные колодки ", " aps21"));
            auto.Add(new BrakePads(" Bocsh ", new DateTime( 2020,10,05), 2500, " Тормозные колодки ", " AP01"));
            auto.Add(new CarTires( " MICHLIN ", new DateTime( 2020,10,11), 5500, " Шины летние "," Sport4"));
            auto.Add(new CarTires( " PIRELLI ", new DateTime( 2020,02,12), 5500, " Шины зимние ", " Zero"));
            auto.Add(new Drosel(" BOCSH ", new DateTime( 2021,02,12), 15500, " Дросель "," DZ 121"));
            auto.Add(new Drosel(" BOCSH ", new DateTime( 2021,05,12), 14000, " Дросель2 "," DZ 221"));
            auto.Add(new Drosel(" Карбюратор ", new DateTime( 1988,05,13), 300, " Дросель "," Карбюратор № 1"));
           
            WriteLine(auto.Name);

            //auto.ShowCategory();
            auto.ShowAll();
            
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("auto.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, auto);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("auto.dat", FileMode.OpenOrCreate))
            {
                AutoShop<ProductСategory> newauto = (AutoShop<ProductСategory>)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newauto.Name} ");
            }
            /*
            XmlSerializer formatter = new XmlSerializer(typeof(AutoShop<ProductСategory>));
             using(FileStream stream = new FileStream("auto.xml", FileMode.OpenOrCreate))
             {
                formatter.Serialize(stream, auto);
                Console.WriteLine("Объект сериализован");
            }
            */
            Console.Read();
        }
        
    }
}
