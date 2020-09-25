using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Structural.Adapters
{
    class HomeCatAdapter : IHomeCat
    {
        private readonly IWildCat _wildCat;

        public HomeCatAdapter(IWildCat wildCat)
        {
            this._wildCat = wildCat;
        }

        public string Name
        {
            get
            {
                return _wildCat.Breed;
            }
            set { }
        }
        public void Meow()
        {
            _wildCat.Growl();
           // IWildCat c 
            // Console.WriteLine("Мяу мяу");
        }

        public void Scratch()
        {
            _wildCat.Scratch();
           // Console.WriteLine("Я царапаюсь, но не сильно");
        }
    }
}
