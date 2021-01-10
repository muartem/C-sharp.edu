using System;
using System.Collections.Generic;

namespace HW6_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var quas = new List<object>(){};
            float points = 0;
            quas.Add(new QA("Інноваційна технологія, яка дозволяє об'єднувати ІТ-ресурси різних апаратних платформ в єдине ціле і надавати користувачеві доступ до них через локальну мережу або через інтернет, називається:", 3, "хмарний додаток", "хмарні сховища", "хмарні технології"));
            quas.Add(new QA("Що зі списку не є хмарним сховищем?", 3, "Dropbox", "Google Docs", "Kahoot"));
            quas.Add(new QA("Що можна зробити за допомогою хмарних сховищ?", 2, "забезпечувати доступ до інтернету іншим користувачам", "забезпечити доступ до файлів з іншого пристрою", "створювати файли і спільно редагувати їх"));
            quas.Add(new QA("Які переваги можна виділити при використанні хмарних сховищ?", 3, "доступ до файлів без підключення до інтернету", "можливість організації спільної роботи з даними", "можливість доступу до даних з будь-якого комп'ютера, що має вихід в інтернет"));
            quas.Add(new QA("Який з перерахованих сервісів є віртуальною галереєю?", 3, "Flubaroo", "Google Keep", "Google Arts & Culture"));
            byte j = 1;
            foreach (var q in quas)
            {
                Console.WriteLine(j++ +") "+ ((QA) q).Question);
                byte i = 1;
                foreach (var a in ((QA) q).Answer) Console.WriteLine(" " + i++ +". "+ a);
                byte userAns = Convert.ToByte(Console.ReadLine());
                var bmdw = userAns == ((QA) q).IndexCorrectAnswer ? points++ : 0;
            } 
            Console.WriteLine($"Вы ответили на {Math.Floor(points/quas.Count * 100)}% вопросов!");
        }
    }
}