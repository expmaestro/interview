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

    public class StructInher
    {

    }
    public struct Struct :  IStruct
    {
        // int hours = 1; //error
        public string Name { get; set; }
        public Struct(string name)
        {
            Name = "1";
            Console.WriteLine("Struct ctor");
        }

        public Struct(string text1, string text2)
        {
            Name = "1";
            Console.WriteLine("Struct ctor");
        }

        static Struct()
        {

        }

        

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

    public struct Test
    {

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
