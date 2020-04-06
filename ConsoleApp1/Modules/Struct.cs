using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public interface IStruct
    {

    }
    public struct Struct : IStruct
    {
        // int hours = 1; //error
        public Struct(string name)
        {
            Name = "1";
        }

        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string n)
        {
            this.Name = n;
            Console.WriteLine(Name);
        }
    }
    class  StructRun
    {
       public static void Run()
        {
            Struct st = new Struct();
            st.SetName("Test");
            st.GetName();
        }
    }
}
