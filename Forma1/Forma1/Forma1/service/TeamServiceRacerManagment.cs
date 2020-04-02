using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Forma1.myexeption;
using Forma1.repository;

namespace Forma1.service
{
    partial class TeamService
    {
        /// <summary>
        /// A következő versenyző ID-jének meghatározása a repository segítségével
        /// </summary>
        /// <returns>a következő versenyző ID-je</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public int getNextRacerId()
        {
            try
            {
                return f1Repository.getNextRacerId();
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott nevű csapatban adott nevű versenyzőnek az ID-je
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>Az ID</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public int getRacerId(string teamName, string racerName)
        {
            try
            {
                return f1Repository.getRacerId(teamName, racerName);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Versenyző hozzáadása adott nevű csapathoz
        /// Üzleti logika: ha nem létezik adott nevű és életkorú versenyző, akkor a versenyző hozzáadása a csapathoz
        /// Üzleti logika: mielőtt hozzáadjuk az új versenyzőt, új ID kérünk neki és az új ID-t beállítjuk a newRacernek
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="newRacer">Az új versenyző</param>
        /// <excaeption cref="TeamServiceToGUIException">Már létezik " + newRacer.getName() + " nevű versenyző, aki " + newRacer.getAge() + " éves.</excaeption>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void addReacerToTeam(string teamName, Racer newRacer)
        {
            try
            {
                if (existRacer(newRacer.getName(), newRacer.getAge()))
                    throw new TeamServiceToGUIException("Már létezik " + newRacer.getName() + " nevű versenyző, aki " + newRacer.getAge() + " éves.");
                int newId = f1Repository.getNextRacerId();
                newRacer.setId(newId);
                f1Repository.addRacerToTeam(teamName, newRacer);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott nevű csapatban adott nevű versenyző keresése a repository segítségével
        /// Üzleti logika: ha van adott nevű csapat, akkor a versenyző megkeresése
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A megtalált versenyző</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            try
            {
                if (isExistTeam(teamName))
                    return f1Repository.searchRacerByName(teamName, racerName);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
            return null;
        }


        /// <summary>
        /// Adott nevű csapatban adott nevű versenyző adatainak lecserélése új adatokkal
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// Üzleti logika: Ha nem létezik adott nevű versenyző és az ID-je nullánál nagyobb akkor adatok lecserélése
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="oldRacerName">A módosítandó versenyző neve</param>
        /// <param name="newRacer">Az új versenyző adatai</param>
        /// <exception cref="TeamServiceExceptionToGUIException">"Már létezik " + newRacer.getName() + " nevű versenyző, aki " + newRacer.getAge() + " éves.")</exception>
        /// <exception cref="TeamServiceException">A megadott versenyőjnek nem találom az azonosítáját.</exception>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void updateReacerInTeam(string teamName, string oldRacerName, Racer newRacer)
        {
            try
            {
                if (existRacer(newRacer.getName(), newRacer.getAge()))
                    throw new TeamServiceToGUIException("Már létezik " + newRacer.getName() + " nevű versenyző, aki " + newRacer.getAge() + " éves.");
                int racerId = getRacerId(teamName, oldRacerName);
                if (racerId > 0)
                {
                    f1Repository.updateReacerInTeam(teamName, oldRacerName, newRacer);
                }
                else
                    throw new TeamServiceException("A megadott versenyőjnek nem találom az azonosítáját.");

            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott csapatban adott nevű és életkorú versenyző törlése
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {
            try
            {
                f1Repository.deleteRacerInTeam(teamName, racerName, racerAge);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Versenyző átrakása egyik csapatból a másikba
        /// Üzleti logika: 
        ///  - a versenyző megkeresése a csapatnév és versenyző név alapján
        ///  - az új csapathoz a megtalált versenyző hozzáadása
        ///  - a régi csapatból a versenyző törlése
        /// </summary>
        /// <param name="fromTeamName">Ebből a csapatből rakjuk át</param>
        /// <param name="toTeamName">Ebbe a csapatba rakjuk át</param>
        /// <param name="movedRacerName">A versenyző neve</param>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void moveToTeam(string fromTeamName, string toTeamName, string movedRacerName)
        {
            try
            {
                Racer r = searchRacerByName(fromTeamName, movedRacerName);
                f1Repository.addRacerToTeam(toTeamName, r);
                f1Repository.deleteRacerInTeam(fromTeamName, r.getName(), r.getAge());
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott nevé és életkorú versenyző lézetik-e
        /// A feladatot a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        private bool existRacer(string racerName, int racerAge)
        {
            try
            {
                if (f1Repository.isExistRacer(racerName, racerAge))
                    return true;
                else
                    return false;
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott csapatban lévő versenyzők
        /// Üzleti logika: ha létezik a csapat, akkor a csapat versenyzőinek listáját lekérni
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A versenyzők</returns>
        /// /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public List<Racer> getRacerFromTheTeam(string teamName)
        {
            try
            {
                if (isExistTeam(teamName))
                    return f1Repository.getRacersFromTheTeam(teamName);
                else
                    return null;
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }
    }
}
