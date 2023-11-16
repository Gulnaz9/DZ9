using System;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 10.1\nРеализовать интерфейс ICipher, который определяет методы поддержки шифрования строк");
            string text = "It is cipher:)";
            ICipher cipher = new ACipher();
            string encodedText = cipher.encode(text);
            string decodedText = cipher.decode(encodedText);

            Console.WriteLine("Зашифрованный текст: " + encodedText);
            Console.WriteLine("Расшифрованный: " + decodedText);

            cipher = new BCipher();
            encodedText = cipher.encode(text);
            decodedText = cipher.decode(encodedText);

            Console.WriteLine("Зашифрованный по другому: " + encodedText);
            Console.WriteLine("Расшифрованный: " + decodedText);



            Console.WriteLine("\nДз 10.1\nЗадание с фигурами");
            // Пример использования классов
            Figure figure = new Figure(Colors.Синий, Statuses.Видимый);
            figure.ChangeColor(Colors.Фиолетовый);
            figure.ChangeStatus(Statuses.Невидимый);
            Console.WriteLine("Просто фигура");
            figure.DisplayState();
            figure.MoveHorizontal(5);

            Circle circle = new Circle(Colors.Пурпурный, Statuses.Видимый);
            Console.WriteLine("Круг");
            circle.DisplayState();
            double circleArea = circle.CalculArea(5);
            Console.WriteLine("Площадь круга: " + circleArea);

            Rectangle rectangle = new Rectangle(Colors.Розовый, Statuses.Видимый);
            Console.WriteLine("Прямоугольник");
            rectangle.DisplayState();
            double rectangleArea = rectangle.CalculArea(4, 5.5);
            Console.WriteLine("Площадь прямоугольнка: " + rectangleArea);


        }
    }
}
