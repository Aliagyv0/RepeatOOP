using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task3
{
    internal class MultiFunctionPrinter : IScanable,IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Print Method is started");
        }

        public void Scan()
        {
            Console.WriteLine("Scan Method is started");

        }
    }
}
