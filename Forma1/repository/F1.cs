using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Forma1.myexeption;

namespace Forma1.repository
{
    /// <summary>
    /// F1 adatokat tartalmazó osztály
    /// </summary>
    partial class F1 : IF1
    {
        List<Team> teams;

        /// <summary>
        /// F1 konstruktor
        /// </summary>
        

        /// <summary>
        /// Új csapat hozzáadása a Forma1-hez
        /// </summary>
        /// <param name="t">A csapat</param>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        public void add(Team t)
        {            
            teams.Add(t);
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// Kivétel dobás ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <exception cref="F1Exception">Az adott nevű csapat nem létezik.</exception>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        public void delete(string teamName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            int index = 0;

            foreach ()
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        t.deleteAllRacersInTeam();
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception(teamName + " nevű csapat tagjainak törlése nem sikerült");
                    }
                    teams.RemoveAt(index);
                    return;
                }
                index = index + 1;
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet törölni");            
        }

        /// <summary>
        /// Adott nevű csapat nevének módosítása
        /// Kivétel dobás, ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat régi neve</param>
        /// <param name="newTeamName">A csapat új neve</param>
        /// <exception cref="F1Exception">Az adott nevű csapat nem létezik, nem lehet módosítani.</exception>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        public void update(string teamName, string newTeamName)
        {
        }

        /// <summary>
        /// F1 bérköltsége
        /// </summary>
        /// <returns>A bérköltség</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A csapat bérét nem sikerült kiszámolni</exception>
        public int getF1Salary()
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            int sum = 0;            
        }

        /// <summary>
        /// A csapatok listája
        /// </summary>
        /// <returns>A csapatok listája</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        public List<Team> getTeams()
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            return teams;
        }

        /// <summary>
        /// Van-e adott nevű csapat
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>true ha van és false ha nincs</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        public bool IsExist(string teamName)
        {
        }

        /// <summary>
        /// Van-e adott versenyző
        /// </summary>
        /// <param name="racerName">A keresett versenyző neve</param>
        /// <param name="racerAge">A keresett versenyző életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A csapatnak nincs egyetlen versenyzője sem</exception>
        public bool IsExistRacer(string racerName, int racerAge)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");           
        }

        /// <summary>
        /// Adott csapat adott nevű versenyzőjének megkeresése
        /// </summary>
        /// <param name="teamName">A csapat neve, amelynek tagja a versenyző</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A versenyző</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A csapatnak nincs egyetlen versenyzője sem</exception>
        /// <exception cref="F1Exception">Az adott nevű csapat nem létezik.</exception>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if ()
                {
                    try
                    {
                        return t.searchRacerByName(racerName);
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("A csapatnak nincs egyetlen versenyzője sem");
                    }
            }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet " + racerName + " nevű versenyzője.");
        }
    }
}
