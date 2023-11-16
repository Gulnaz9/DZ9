using System;
using System.Collections.Generic;

namespace DZ9
{
    internal class Team
    {
        public string country { get; set; }
        public List<Person> members = new List<Person>();

        /// <summary>
        /// конструктор для создания команды
        /// </summary>
        /// <param name="cOuntry"></param>
        /// <param name="members"></param>
        public Team(string cOuntry, params Person[] members)
        {
            country = cOuntry;
            foreach (Person player in members)
            {
                this.members.Add(player);
            }
        }
    }
}
