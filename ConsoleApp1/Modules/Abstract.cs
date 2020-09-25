using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public abstract class BaseShip
    {
        //public string GetName()
        //{
        //    Console.WriteLine("Antares");
        //    return "Antares";
        //}
        public BaseShip()
        {
            Console.WriteLine("Called abstract base constructor");
        }
        public virtual string Move(int distance)
        {
            var result = $"Пройдено километров: { distance}";
            return result;
        }

        public virtual string Fight()
        {
            return "Произошел бой";
        }

        public abstract void Land(int x, int y);
    }

    public class TransportShip : BaseShip
    {
        public TransportShip()
        {
            Console.WriteLine("Called TransportShip constructor");
        }
        public override void Land(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override string Fight()
        {
            return "Транспортный корабль биться не умеет";
        }
    }

    public class Test111 : TransportShip
    {

    }

    // ==============
    class CommonClass : PageBase
    {
        protected override void RenderPage()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class PageBase
    {
        protected abstract void RenderPage();
    }
    public abstract class MainPageBase: PageBase
    {
        protected override sealed void RenderPage()
        {
            // Отрисовка будет строкго в таком порядке
            this.RenderHeader();
            this.RenderBody();
            this.renderFooter();
        }
        protected abstract void RenderHeader();
        protected abstract void RenderBody();
        protected abstract void renderFooter();
    }

   
    class Abstract
    {
        public static void Run()
        {

            BaseShip ship = new TransportShip();
            Console.WriteLine(ship.Fight());
        }
    }
}
