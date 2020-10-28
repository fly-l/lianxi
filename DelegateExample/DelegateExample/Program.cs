using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            wrapFactory wrapFactory = new wrapFactory();
            ProductFactory productFactory = new ProductFactory();

            Func<Product> func = new Func<Product>(productFactory.MakePizza);
            Box box = wrapFactory.WrapProduct(func);
            Console.WriteLine(box.product.Name);
            Console.ReadLine();
        }
    }
    class Product     //产品类 有name属性
    {
        public string Name { get; set; }
    }
    class Box          //包装箱子 ，可以包装不同产品
    {
        public Product product { get; set; }
    }
    class wrapFactory      //包装工厂
    {
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            box.product = product;
            return box; 
        }
    }
    class ProductFactory //产品工厂
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "This is pizza";
            return product;
        }
        public Product MakeKole()
        {
            Product product = new Product();
            product.Name = "This is kole";
            return product;

        }
    }
}
