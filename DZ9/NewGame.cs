using System;

namespace DZ9
{/// <summary>
/// класс, чтобы можно было добавить новую игру
/// </summary>
    internal class NewGame : Game
    {
        private Game gamE;

        public NewGame(Game game)
        {
            gamE = game;
        }

        public override void Play()
        {
            gamE.Play();
            Console.WriteLine("Добавлена новая игра");
        }
    }
}
