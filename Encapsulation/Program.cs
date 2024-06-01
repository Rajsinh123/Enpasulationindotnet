using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    class Program
    {

        private string name;
        public string Name { get; set; }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Name = "rajsinh";
            Console.WriteLine(p.Name);
            Console.ReadLine();
        }
    }
}
