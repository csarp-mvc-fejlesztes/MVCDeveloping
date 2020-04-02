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
        /// <summary>
        /// Visszaadja, hogy a csapatban hány versenyző van
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A csapat versenyzőinek száma</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">Végzetes hiba, a csapat versenyzőinek száma meghatározhatatlan!</exception>
        /// <exception cref="F1Exception">A csapat nem létezik, nem lehet megállapítani, hány versenyzője van.</exception>
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
                        return 
                    }
                    catch (TeamException te)
                    {
                        Debug.WriteLine(te.Message);
                        throw new F1Exception("Végzetes hiba, a csapat versenyzőinek száma meghatározhatatlan!");
                    }
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet megállapítani, hány versenyzője van.");
        }

        /// <summary>
        /// Adott csapat versenyzőinek listája
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A csapat versenyzőinek listája</returns>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A csapatnak nincsennek versenyzői</exception>
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

        /// <summary>
        /// A versenyző hozzáadása a csapathoz
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="newRacer">A versenyző</param>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A versenyző felvétele nem lehetséges mert nincs racer lista vagy már létezik versenyző!</exception>
        /// <exception cref="F1Exception">A csapat nem létezik, nem lehet új versenyzőt hozzáadni</exception>
        public void addRacerToTeam(string teamName, Racer newRacer)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach ()
            {
                if ()
                {
                    try
                    {
                        t.
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

        /// <summary>
        /// Versenyző adatinak frissítése
        /// </summary>
        /// <param name="teamName">A csapat amelyikben a versenyző szerepel</param>
        /// <param name="oldRacerName">A módosítandó versenyző neve</param>
        /// <param name="newRacer">Erre az értékre módosítjuk a versenyzőt</param>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A versenyző módosítása nem végrehajtható</exception>
        /// <exception cref="F1Exception">A csapat nem létezik, nem lehet módosítani a versenyzőjének adatait.</exception>
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
        }

        /// <summary>
        /// A versenyző törlése a csapatból
        /// </summary>
        /// <param name="teamName">A csapat ahonnan töröljük a versenyzőt</param>
        /// <param name="racerName">A törlendő versenyző neve</param>
        /// <param name="racerAge">A törlendő versenyző életkora</param>
        /// <exception cref="F1Exception">Végzetes hiba, teams lista nincs példányosítva</exception>
        /// <exception cref="F1Exception">A csapatban versenyző törlése nem lehetséges."</exception>
        /// <exception cref="F1Exception">A nevű csapat nem létezik, nem lehet törölni a versenyzőjét.</exception>
        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet törölni a versenyzőjét.");
        }

        /// <summary>
        /// Csapat bérköltségének meghatározása
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A csapat bérköltsége</returns>
        public int getTeamSalary(string teamName)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba, teams lista nincs példányosítva");
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {                   
                        return t.getTeamSalary();                                     
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
            
            foreach (Team t in teams)
            {
                try
                {

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
        }

    }
}
