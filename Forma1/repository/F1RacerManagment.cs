using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Forma1.myexeption;

namespace Forma1.repository
{
    partial class F1 : IF1
    {
        public int getNumberOfRacers(string teamName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        return t.getNumberOfRacers();
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("A csapatot nem lehet törölni.");
                    }
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet megállapítani, hány versenyzője van.");
        }

        public List<Racer> getRacersFromTheTeam(string teamName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        return t.getRacers();
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("A csapatnak nincsennek versenyzői");
                    }
                }
            }
            return null;
        }

        public void addRacerToTeam(string teamName, Racer newRacer)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        t.addRacer(newRacer);
                        return;
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("A versenyző felvétele nem lehetséges mert nincs racer lista vagy már létezik versenyző!");
                    }                
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet új versenyzőt hozzáadni");
        }

        public void updateReacerInTeam(string teamName, string oldRacerName, Racer newRacer)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        t.updateRacer(oldRacerName, newRacer);
                        return;
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception(teamName+" csapatban "+newRacer+" versenyző módosítása nem végrehajtható."); 
                    }
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet módosítani a versenyzőjének adatait.");
        }

        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        t.deleteRacer(racerName, racerAge);
                        return;
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception(teamName+" csapatban "+racerName+" törlése nem lehetséges.");
                    }                    
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet törölni a versenyzőjét.");
        }

        public int getTeamSalary(string teamName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        return t.getTeamSalary();
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("A csapatnak nincsennek versenyzői, nem lehet csapat bérköltséget számolni.");
                    }
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet bérköltséget számolni.");
        }

        /// <summary>
        /// Átnézi az összes csapat összes versenyzőjét és megállapítja a
        /// jelenlegi legnagyobb Racer ID-t. Eggyel nagyobbat ad vissza
        /// Ha egyáltalán nincs csapat vag egy versenyző sincs akkor egyet
        /// </summary>
        /// <returns>Az eddigi legnagyobbnál eggyel nagyobbat. Ha egyáltalán nincs csapat vag egy versenyző sincs akkor egyet</returns>
        public int getNextRacerId()
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            int maxId = -1;
            foreach (Team t in teams)
            {
                try
                {
                    int teamMaxRacerId = t.getMaxId();
                    if (teamMaxRacerId > maxId)
                        maxId = teamMaxRacerId;
                }
                catch (TeamException te)
                {
                    Debug.WriteLine(te.Message);                    
                }
            }
            if (maxId > 0)
                return maxId + 1;
            else
                return 1;
        }

        /// <summary>
        /// Az adott csapatban lévő versenyző ID-je
        /// Feladat a kivétel megírása, ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A versenyző ID-je</returns>
        public int getRacerId(string teamName, string racerName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    try
                    {
                        return t.getRacerId(racerName);
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("A csapatnak nincsennek versenyzői. Így " +racerName+" versenyző nem létezik.");
                    }
                }
            }
            return 0;
        }

    }
}
