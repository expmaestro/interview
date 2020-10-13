using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Strategy
{
    interface IReader
    {
        string GetValue(string datas);
    }
    class DataReader //: IReader // будет выступать в качестве стратегии
    {
        public string GetValue(IReader reader, string datas)
        {
            return reader.GetValue(datas);
        }
    }

    class FileDataReader : IReader
    {
        public string GetValue(string datas)
        {
           // throw new NotImplementedException();
           if(string.IsNullOrEmpty(datas))
            {
                return string.Empty;
            }

            using (var fileReader = new StreamReader(datas))
            {
                var dataArray = fileReader.ReadToEnd().Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var resultValues = dataArray.Select((x, i) => $"{i + 1}: {x}");
                return string.Join("\n", resultValues);
            }
        }
    }

    class StringDataReader : IReader
    {
        public string GetValue(string datas)
        {
            if (string.IsNullOrEmpty(datas))
            {
                return string.Empty;
            }

            var dataArray = datas.Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var resultValues = dataArray.Select((x, i) => $"{i + 1}: {x}");
            return string.Join("\n", resultValues);
        }
    }

    class Strategy
    {
        public static void Run()
        {
            var dataReader = new DataReader();
            Console.WriteLine("----from string----");
            Console.WriteLine(dataReader.GetValue(new StringDataReader(), "Первая строка\nВторая Строка\nТретья"));
            Console.WriteLine("----from file----");
            Console.WriteLine(dataReader.GetValue(new FileDataReader(), @"C:\Work\Interview\ConsoleApp1\Patterns\Strategy\strategy.txt"));
        }
    }
}
