using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork09122023.Domain.Models
{
      public class Book : Product
    {
        public Book( string name, int price, int count, int totalCome, int sell) : base(name, price, count, totalCome, sell)
        {
        }

        public override void Selll()
        {
            if (Count > 0)
            {
                Count--;
                TotalCome += Price;
                Console.WriteLine($"{TotalCome} {Count}");
            }
            else
            {
                Console.WriteLine("Satilmaga kitab yoxdu");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name},{Count},{Price},{TotalCome},{Sell}");
        }
    }
}
