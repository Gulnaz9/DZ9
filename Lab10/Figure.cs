using System;

namespace Lab10
{
    enum Colors
    {
        Синий,
        Фиолетовый,
        Пурпурный,
        Розовый
    }
    enum Statuses
    {
        Видимый,
        Невидимый
    }
    internal class Figure
    {
        Colors color;
        Statuses status;

        public Figure(Colors color, Statuses status)
        {
            this.color = color;
            this.status = status;
        }

        public void MoveHorizontal(int distance)
        {
            // Логика для перемещения по горизонтали 
            Console.WriteLine("Перемещается на " + distance + " по горизонтали");
        }

        public void MoveVertical(int distance)
        {
            // и по вертикали
            Console.WriteLine("Перемещается на " + distance + " по вертикали");
        }

        /// <summary>
        /// метод для изменения цвета
        /// </summary>
        /// <param name="newColor"></param>
        public void ChangeColor(Colors newColor)
        {
            this.color = newColor;
        }

        /// <summary>
        /// метод для изменения статуса
        /// </summary>
        /// <param name="newStatus"></param>
        public void ChangeStatus(Statuses newStatus)
        {
            this.status = newStatus;
        }

        /// <summary>
        /// метод для вывода на экран
        /// </summary>
        public void DisplayState()
        {
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine("Состояние: " + status);
        }

    }
}
