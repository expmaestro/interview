using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Structural.Adapters
{
    // написан код супергероя (мы его купили за деньи). Написанно куча кода, нам надо преобразовать под наших геров
    // а мы преобразовали код, теперь можем написать своих героев: один стреляет, другой летает, третий ходит через стены
    interface ISurephero
    {
        void Shoot();
        void Fly();
        void GoThroughWalls();
    }


    interface IFly
    {
        void Fly();
    }
    interface IShoot
    {
        void Shoot();
    }
    interface IWals
    {
        void GoThroughWalls();
    }

    class SuperheroAdapter : ISurephero
    {
        private readonly IFly _fly;
        private readonly IShoot _shoot;
        private readonly IWals _walls;
        public SuperheroAdapter(IFly fly, IShoot ishoot, IWals walls): base()
        {
            _fly = fly;
            _shoot = ishoot;
            _walls = walls;
            
        }

        public void Fly()
        {
            //_fly = null;
            _fly.Fly();
        }

        public void GoThroughWalls()
        {
            _walls.GoThroughWalls();       
        }

        public void Shoot()
        {
            _shoot.Shoot();
        }
    }

    class SuperheroesAdapter2
    {
    }
}
