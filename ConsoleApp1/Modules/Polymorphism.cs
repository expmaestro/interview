using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class Polymorphism
    {
        public static void Run()
        {
            var apple = new Apple() { Name = "Apple" };
            var bannana = new Bannana() { Name = "Bannana" };

            var products = new BaseProduct[]
            {
                apple,
                bannana
            };

            foreach(var pr in products)
            {
                pr.GetDiscount();
            }
            Console.WriteLine("=============");
            var derivedInstance = new Apple();
            BaseProduct p = derivedInstance;
            p.GetDiscount();
            p.GetName();
            Console.WriteLine("=============");
            var baseInstance = new BaseProduct();
            
            //ap.GetDiscount();
            //ap.GetName();
        }
    }

    class BaseProduct
    {
        public string Name { get; set; }
        public virtual void GetDiscount()
        {
            Console.WriteLine("No Discount");
        }

        public void GetName()
        {
            Console.WriteLine("Base Product");
        }

        public void GetParentName()
        {
            Console.WriteLine("This is base functional");
        }
    }

    class Apple : BaseProduct
    {
        public override void GetDiscount()
        {
           
            Console.WriteLine($"Discount {this.Name} 10%");
        }
        public void GetName()
        {
            base.GetParentName();
            Console.WriteLine("Apple");
        }

        
    }
    class Bannana : BaseProduct
    {
        public override void GetDiscount()
        {
            Console.WriteLine($"Discount: {this.Name} 50%");
        }
    }
}
