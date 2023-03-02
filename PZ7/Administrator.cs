using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7
{
    public class Administrator : IObserver
    {
        private string name;
        public string Name { get { return name; } }
        public Administrator(string name)
        {
            this.name = name;
        }

        public void Update(Object obj)
        {
            Console.WriteLine(name + " " + obj.ToString());
        }
    }
}
