using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Protected
    {
    }

    class Animal
    {
        //елси не пишем то по умолчанию public
        protected string voice = "";
        public string color = "black";

        private void go()
        {

        }
    }

    class Cat : Animal
    {
        public void setVoice(string voice)
        {
            this.voice = voice;
        }
    }
}
