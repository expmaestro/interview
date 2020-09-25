using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    //  если удалить pdb file то в экзепшинах не будет номера строки
    // если хотим получить трасировку стека с метода Main, то нужно его оборачивать в try catch
    // throw - full stack trace, 
    // throw ex - сбрасывает трасировку стека, выбрашенное исключение становится исходным
    class ExceptionTest
    {
        public void FirstMethod(int a, int b)
        {
            SecondMethod(a, b);
        }
        public void SecondMethod(int a, int b)
        {
            ThirdMethod(a, b);
        }
        public void ThirdMethod(int a, int b)
        {
           // try {
                if (a < 0) throw new ArgumentException("параметр должен быть больше нуля!", "a");
                if (b < 0) throw new ArgumentException("параметр должен быть больше нуля!", "b");
        //    }
           // catch (Exception ex)
           // {
                //пишем лог
             //   throw ; // пробрасываем далее
            //}
        }
        //public void Divide()
        //{
        //    try
        //    {

        //    }
        //    catch (DivideByZeroException ex)
        //    {

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {

        //    }
        //}
    }

    class Exceptions
    {
        public static void Run()
        {
          try
            {
                ExceptionTest test = new ExceptionTest();
                test.FirstMethod(-1, 2);
            }
            catch (Exception ex)
            {
                
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                throw ; // будет полный стек, а если throw ex- то только с этого места
            }          
          
        }
    }
}
