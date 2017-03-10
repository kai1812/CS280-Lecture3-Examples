using StoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Products 豆漿 = new Products();
            豆漿.Name = "永和豆漿";
            豆漿.Price = 15;

            Products 油條 = new Products();
            油條.Name = "永和油條";
            油條.Price = 10;
        }
    }
}