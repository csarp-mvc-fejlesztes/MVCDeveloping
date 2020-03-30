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
        }        

        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>

        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public List<Racer> getRacers()
        {
        }

        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public int getTeamSalary()
        {
        }
    }
}