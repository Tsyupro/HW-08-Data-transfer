using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Data_transfer
{
    
    public class Commodity
    {
        public string? name;
       public int price;
       public string? characteristic;
       public string? description;

        public Commodity(string name, string characteristic,string description, int price)
        {
            this.name = name;
            this.price = price;
            this.characteristic = characteristic;
            this.description = description;

        }
        public override string ToString()
        {
            return $"{name}";
        }
        public string InfoCommodity()
        {
            return $"{name} | {characteristic} | {description} | {price}";
        }



    }
}
