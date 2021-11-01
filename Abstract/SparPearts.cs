using System;

namespace Exam_C_
{
    [Serializable]
    public abstract class SparPearts
    {
       public string SpName;
       public DateTime production_date;
       public double Price;

        public SparPearts(string SpName, DateTime production_date, double Price)
        {
            this.SpName = SpName;
            this.production_date = production_date;
            this.Price = Price;
        }
        //public abstract void Вescription(); //описание

        public override string ToString()
        {
            return ($"\n Название: { SpName }\n" +
                      $" Дата производства: { production_date.ToLongDateString() }\n" +
                      $" Стоимость : { Price } гр.\n");
        }
        
    }
}