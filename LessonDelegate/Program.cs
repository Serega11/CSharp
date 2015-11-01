using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LessonDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            //CountDelegate error = helper.GetCountSymbol; //Нельзя использовать, т.к. дилегат имеет отличную сигнатуру int(string,char)

            string testString = "LAMP";

            Console.WriteLine("Общее количество симаолов: {0}",TestDelegate(d1,testString));
            Console.WriteLine("Количество символов А: {0}", TestDelegate(d2, testString));

            Console.ReadLine();
        }
        //Объявим метод (ссылка на тест-м метод, тестируемая строка)
        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
    }
}
