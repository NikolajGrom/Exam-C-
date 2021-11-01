using Exam_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class SparPeartsEqualityComparer : IEqualityComparer<ProductСategory>
    {
        public bool Equals(ProductСategory b1, ProductСategory b2)
        {
            if (b1.SpName != b2.SpName)
                return false;
            if (b1.СategoryName != b2.СategoryName)
                return false;
            if (b1.Price != b2.Price)
                return false;
            if (b1.production_date != b2.production_date)
                return false;

            return true;
        }

        public int GetHashCode(ProductСategory bx)
        {
            int hCode = bx.SpName.Length + bx.СategoryName.Length;
            return hCode.GetHashCode();
        }
    }
}
