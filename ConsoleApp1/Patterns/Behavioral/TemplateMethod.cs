using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1.Patterns.Behavioral
{
    // 1. наследование
    // 2. расширения
    // 3. Делегаты

    public abstract class StringTemplate
    {
        public virtual string GetTemplate(string text)
        {
            return $"{EncodeString(GetFirstLine() + text + GetLastLine())}";
        }
        public abstract string GetFirstLine();
        public abstract string GetLastLine();
        public abstract string EncodeString(string text);
    }

    public class SecretDocumentTemplate : StringTemplate
    {
        public override string GetFirstLine()
        {
            return "Top secret\r\n";
        }

        public override string GetLastLine()
        {
            return $"\r\nDate: {DateTime.Now}";
        }
        public override string EncodeString(string text)
        {
            var plainText = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainText);
        }

        public string DecodeString(string text)
        {
            var base64EndcodedBytest = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(base64EndcodedBytest);
        }
    }

    class HtmlTemplate: StringTemplate
    {
        private readonly string _htmlPage = "<!DOCTYPE html><html><body> {0} </body></html>";
        private readonly string _title;

        public HtmlTemplate(string title)
        {
            _title = title;
        }       

        public override string GetFirstLine()
        {
            return $"<h1>{_title}</h1>\n";
        }

        public override string GetLastLine()
        {
            return $"<p>{DateTime.UtcNow}</p>";
        }
        public override string EncodeString(string text)
        {
            // для кодирования потенциально опасных символов в их Html Эквиваленты
            return HttpUtility.HtmlEncode(string.Format(_htmlPage, $"<div>{text}</div>"));
       }
    }
    class TemplateMethod
    {

        public static void Run()
        {
            Console.WriteLine($"================== Template method  ==================");
            var secretTemplate = new SecretDocumentTemplate();
            var result = secretTemplate.GetTemplate("This is a template of secret document");
            Console.WriteLine(result);
            Console.WriteLine("-----");
            Console.WriteLine(secretTemplate.DecodeString(result));
            Console.WriteLine("-----");
            var htmlTemplate = new HtmlTemplate("New Arcticle");
            var result2 = htmlTemplate.GetTemplate("This is the page with new C# arcticle");
            Console.WriteLine(result2);
            Console.WriteLine($"================== End Template method  ==================");
        }
    }
}
