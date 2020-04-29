using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeam
    {
        private string name;
        private List<Racer> racers;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {
            this.name = name ;
            this.racers = new List<Racer>();
        }

        /// <summary>
        /// Csapat nevének lekérése
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listából minden versenyzőt törlünk
        /// </summary>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public void deleteAllRacersInTeam()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            racers.Clear();
        }

        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public int getTeamSalary()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            int sum = 0;
            foreach (Racer r in racers)
            {
                sum += r.getSalary();
            }
            return sum;
        }

        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            this.name = newName;
        }

        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public List<Racer> getRacers()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            return racers;
        }
    }
}