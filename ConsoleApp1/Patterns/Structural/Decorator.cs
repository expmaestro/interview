using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// матрешка - вложенность функционала одного объекта в другой
// 1. композиция
// 2. Наследование

// Решаем с помощью композиции
// недостатки - чуствительность к порядку, возникает сложность отлакдки
namespace ConsoleApp1.Patterns.Structural
{
    // добавление декоратора
    public abstract class EditOfTextBase
    {
        private readonly EditOfTextBase _editOfTextBase;

        protected EditOfTextBase(EditOfTextBase editOfTextBase = null)
        {
            this._editOfTextBase = editOfTextBase;
        }
        public virtual string GetFormattedText(string text)
        {
            if(_editOfTextBase != null)
            {
                text = _editOfTextBase.GetFormattedText(text);
            }

            return text;
        }
    }

    // конкретный декоратор

    class ToUpperText: EditOfTextBase
    {
        public ToUpperText(EditOfTextBase editOfTextBase = null): base(editOfTextBase)
        {

        }
        public override string GetFormattedText(string text)
        {
            return base.GetFormattedText(text)?.ToUpper();
        }
    }

    // конкретный декоратор

    class ReplaceSpaceWithLog : EditOfTextBase
    {
        public ReplaceSpaceWithLog(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {

        }
        public override string GetFormattedText(string text)
        {
            Console.WriteLine($"All ' will replace to '+'");
            return base.GetFormattedText(text)?.Replace(' ', '+');
        }
    }
    // конкретный декоратор
    class ToBase64 : EditOfTextBase
    {
        public ToBase64(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {

        }
        public override string GetFormattedText(string text)
        {
            var textBytes = Encoding.UTF8.GetBytes(text);

            return Convert.ToBase64String(textBytes);
                
        }
    }

    // конкретный декоратор
    class ToHtmlTemplate : EditOfTextBase
    {
        private readonly string _htmlPage = "\n<html>\n\t<body>\n\t\t<div>{0}</div>\n\t</body>\n</html>";
        public ToHtmlTemplate(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {

        }
        public override string GetFormattedText(string text)
        {
            var lines = base.GetFormattedText(text);

            return string.Format(_htmlPage, string.Join("<be/>\n", lines));

        }
    }

    class Decorator
    {
       
        public static void Run()
        {
            Console.WriteLine($"================== Decorator  ==================");
            var text = "hello\n This arcticle is about the patternt \"Decorator\"";
            var formattedText = new ToHtmlTemplate(new ToBase64(new ToUpperText(new ReplaceSpaceWithLog())));

            Console.WriteLine(formattedText.GetFormattedText(text));
            Console.WriteLine($"================== End Decorator  ==================");

        }
    }
}
