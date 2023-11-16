using System;
using System.Collections.Generic;

namespace DZ9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person organizer = new Person("Оливье Ганьян");

            Team Russian = new Team("Россия");
            //ForGames.AddTeam(Russian); почему-то не получается использовать метод 
            Team French = new Team("Франция");
            Team Chinese = new Team("Китай");
            Team Kazakstanis = new Team("Казахстан");

            Beach beach = new Beach();
            MouseTrap mousetrap = new MouseTrap();
            Sea sea = new Sea();
            Fishing fishing = new Fishing();
            Postmen postmen = new Postmen();
            Slide slide = new Slide();
            HideAndSeek hideAndSeek = new HideAndSeek();

            List<Game> games = new List<Game>();
            games.Add(new Beach());
            games.Add(new MouseTrap());
            games.Add(new Sea());
            games.Add(new Fishing());
            games.Add(new Postmen());
            games.Add(new Slide());
            //ForGames.AddGame(games); и тут


            // Добавляем свою игру через декоратор
            NewGame myGame = new NewGame(new HideAndSeek());
            myGame.Play();
        }
    }
}
