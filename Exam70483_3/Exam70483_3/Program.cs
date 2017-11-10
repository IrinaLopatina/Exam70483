using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var transformer = new StateLessTransformer();
            transformer.Run();
            
            /*
            var transformer = new StateFullTransformer();
            transformer.Run();
            */
        }
    }
}
