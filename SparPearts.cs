using System;

namespace Exam_C_
{
    public abstract class SparPearts
    {
        string Name;
        DateTime production_date;
        double Price;

        public SparPearts(string name, DateTime date, double price)
        {
            Name = name;
            production_date = date;
            Price = price;
        }
        public abstract void Вescription(); //описание

        public override string ToString()
        {
            return ($"\n Название: { Name }\n" +
                      $"Дата производства:{ production_date.ToLongDateString() }\n" +
                      $"Стоимость :{ Price } гр.\n");
        }
    }
}