using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    // S — Single responsibility principle
    // O — Open/closed principle
    // L — Liskov substitution principle
    // I — Interface segregation principle
    // D - Dependency inversion principle
    class SOLID
    {
        // S - класс или подобная структура в вашем коде должна отвечать только за одну цель.
        // Наш класс не должен быть похож на швейцарский нож, AddEmpoyee, GenerateReport - вынести в разные классы        
        // O - Главной концепцией данного принципа является то, что класс должен быть открыт для расширений, 
        // но закрыт от модификаций (virtual override) 
        public void GenerateReport(string type)
        {
            if (type == "CSV") // Генерация отчета в формате CSV
            if (type == "PDF")// Генерация отчета в формате PDF
                { }
        }
        public virtual void GenerateReport(object em)
        {
            // Базовая реализация, которую нельзя модифицировать
        }
        // L вы должны иметь возможность использовать любой производный класс вместо родительского класса 
        // и вести себя с ним таким же образом без внесения изменений
        // (Должна быть возможность вместо базового типа подставить любой его подтип)
        // abstract с двумя методами переделать на 2 интерфейса
        // I - что клиенты не должны принудительно внедрять интерфейсы, которые они не используют.
        //D - Принцип Инверсии Зависимостей
        //1.классы высокого уровня не должны зависеть от низкоуровневых классов.Оба должны зависеть от абстракций.
        //2.Абстракции не должны зависеть от деталей. Но детали должны зависеть от абстракций.
    }
}
