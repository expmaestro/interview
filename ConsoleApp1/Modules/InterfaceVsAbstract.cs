using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Экземпляр абстрактного класса создать нельзя
// Конструктор абстрактному классу создавать можно
namespace ConsoleApp1.Modules
{
    // если классы относятся к единой системе классификации, то выбирается абстрактный класс. 
    // Иначе выбирается интерфейс.
    // Когда следует использовать абстрактные классы:
    // - Если надо определить общий функционал для родственных объектов
    // - Если проектируем функционал со многим базовых функцоионалом с общей реализацией
    // Инт Если нам надо определить функционал для группы разрозненных объектов, которые могут быть никак не связаны между собо
    public abstract class AbstractClass : Abs2
    {
        
        public AbstractClass()
        {

        }
        public abstract string Name { get; set; }
        public string CarName { get; set; }
        public void Speed()
        {
            object t = 1;
            
            Console.WriteLine("Speed 10 now");
        }
        public virtual string Print() //virtual abstratct не бывает, только abstract
        {
            return "Print";
        }

        public abstract void Drive();
       // private abstract void Drive2(); Error
    }
    

    public abstract class Abs2 {
        public Abs2()
        {

        }
        public void Run()
        {
           // var t = new AbstractClass(); // Экземпляр абстрактного класса создать нельзя
        }
    }

    public class FromAbs : AbstractClass
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Drive() //abstract
        {
            throw new NotImplementedException();
        }
        public override string Print() // virtual
        {
            return base.Print();
        }

    }

    public class FromAbs2: FromAbs
    {

    }

    // Когда следует использовать абстрактные классы:
    // 1. Если надо определить общий функционал для родственных объектов
    // 2. Если мы проектируем довольно большую функциональную единицу, которая содержит много базового функционал
    // 3. Если нужно, чтобы все производные классы на всех уровнях наследования имели некоторую общую реализацию.При использовании абстрактных классов, если мы захотим изменить базовый функционал во всех наследниках, то достаточно поменять его в абстрактном базовом классе.
    // 4.Если же нам вдруг надо будет поменять название или параметры метода интерфейса, то придется вносить изменения и также во всех классы, которые данный интерфейс реализуют.

    // 1. Когда следует использовать интерфейсы:
    // 2. Если нам надо определить функционал для группы разрозненных объектов, которые могут быть никак не связаны между собой.
    // 3. Если мы проектируем небольшой функциональный тип

    // internal, то есть такой интерфейс доступен только в рамках текущего проекта.
    public interface IMove
    {
        int MyProperty { get; set; }
        string Name { get; set; }
        string GetName();
    }
}
