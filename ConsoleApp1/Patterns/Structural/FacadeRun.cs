using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Structural
{
    //пример со старальной машинко - разные системы: сушка, двигатель, отжим
    // соззается фасад стиральной машины

    // двигатель стартует и стопает барабан
    public class EngineSubsystem
    {
        public void Rotate()
        {
            Console.WriteLine("Start rotating");
        }
        public void Stop()
        {
            Console.WriteLine("Stop rotating");
        }
    }

    public class WaterManagingSubsystem
    {
        public void FillWater(int litres)
        {
            Console.WriteLine($"Fill with  {litres} of water");
        }
        public void EmptyWater()
        {
            Console.WriteLine("Empty water tank");
        }
    }
    
    // Класс занимается подогревом воды
    class ThermoSubsystem
    {
        public void WarmUp(int degrees)
        {
            Console.WriteLine($"Warm for {degrees} degrees");
        }
    }
    // Класс позволяет сушить одежду
    class DryerSubsystem
    {
        public void Dry(int seconds, int intensity)
        {
            Console.WriteLine($"Drying {seconds} with intensity {intensity}");
        }
    }

    class WashingMachineFacade
    {
        private DryerSubsystem _dryer;
        private EngineSubsystem _engine;
        private ThermoSubsystem _thermo;
        private WaterManagingSubsystem _water;

        public WashingMachineFacade(DryerSubsystem dryer, EngineSubsystem engine, ThermoSubsystem thermo, WaterManagingSubsystem water)
        {
            _dryer = dryer;
            _engine = engine;
            _thermo = thermo;
            _water = water;
        }

        // вводим 2 режима хлопка и шерсти

        public void WashCottonOperation()
        {
            Console.WriteLine($"=== стираем хлопок ===");
            _water.FillWater(10);
            _thermo.WarmUp(70);
            _engine.Rotate();
            _engine.Rotate();
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(30, 1000); // отжимаем белье 30 секунда, интенсивность 1000 оборотов
            _water.FillWater(15);
            _thermo.WarmUp(50); // полоскаем
            _engine.Rotate();
            _engine.Rotate();
            _engine.Rotate();
            _water.EmptyWater(); // сливаем воду
            _dryer.Dry(60, 1500);
        } 

        public void WashWoolOperation()
        {
            Console.WriteLine($"=== стираем шерсть ===");
            _water.FillWater(7);
            _thermo.WarmUp(30);
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(20, 500); // отжимаем белье 30 секунда, интенсивность 1000 оборотов
            _water.FillWater(10);
            _thermo.WarmUp(520); // полоскаем
            _engine.Rotate();
            _engine.Rotate();
            _water.EmptyWater(); // сливаем воду
            _dryer.Dry(60, 700);
        }
    }

    public class FacadeRun
    {
        public static void Run()
        {
            Console.WriteLine($"================== Facade  ==================");
            var waterSubsystem = new WaterManagingSubsystem();
            var thermoSubsystem = new ThermoSubsystem();
            var engineSubsystem = new EngineSubsystem();
            var dryerSubsystem = new DryerSubsystem();

            var washingMachine = new WashingMachineFacade(dryerSubsystem, engineSubsystem, thermoSubsystem, waterSubsystem);
            washingMachine.WashCottonOperation();
            // стираем хлопок(Cotton)
            //Console.WriteLine($"=== стираем хлопок ===");
            //water.FillWater(10);
            //thermo.WarmUp(70);
            //engine.Rotate();
            //engine.Rotate();
            //engine.Rotate();
            //engine.Stop();
            //water.EmptyWater();
            //dryer.Dry(30, 1000); // отжимаем белье 30 секунда, интенсивность 1000 оборотов
            //water.FillWater(15);
            //thermo.WarmUp(50); // полоскаем
            //engine.Rotate();
            //engine.Rotate();
            //engine.Rotate();
            //water.EmptyWater(); // сливаем воду
            //dryer.Dry(60, 1500);

            washingMachine.WashWoolOperation();
            // стираем шерсть(Wool)
            //Console.WriteLine($"=== стираем шерсть ===");
            //water.FillWater(7);
            //thermo.WarmUp(30);
            //engine.Rotate();
            //engine.Stop();
            //water.EmptyWater();
            //dryer.Dry(20, 500); // отжимаем белье 30 секунда, интенсивность 1000 оборотов
            //water.FillWater(10);
            //thermo.WarmUp(520); // полоскаем
            //engine.Rotate();
            //engine.Rotate();
            //water.EmptyWater(); // сливаем воду
            //dryer.Dry(60, 700);


            Console.WriteLine($"================== Facade  ==================");
        }
    }
}
