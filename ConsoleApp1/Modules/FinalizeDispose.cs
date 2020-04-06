using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class FinalizeDispose
    {
        public static void Run()
        {
            var f = new Fin();            
        }
    }

    class Fin: System.Object
    {
        //даже после завершения метода Test и соответственно удаления из стека ссылки на объект Person в куче,
        //может не последовать немедленного вызова деструктора.Лишь при завершении всей программы 
        //гарантировано произойдет очистка памяти и вызов деструктора.
        //Поэтому для более быстой очистки памяти применяется метод GC.Collect.
        ~Fin()
        {
            Console.WriteLine("In destructor");
        }
        

    }
}
