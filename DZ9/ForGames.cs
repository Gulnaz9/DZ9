using System;
using System.Collections.Generic;

namespace DZ9
{
    internal class ForGames
    {
        public List<Team> teams = new List<Team>();
        public List<Game> games = new List<Game>();
        

        /// <summary>
        /// добавляет команду в список команд
        /// </summary>
        /// <param name="team"></param>
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void AddGame(List<Game> games)
        {
            foreach (Game game in games)
            {
                games.Add(game);
            }
        }

        /// <summary>
        /// метод для начала игры
        /// </summary>
        /// <param name="game"></param>
        public void StartGame(Game game)
        {
            game.Play();
        }
    }
}
