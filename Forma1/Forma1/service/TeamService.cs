using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.myexeption;
using Forma1.repository;

namespace Forma1.service
{
    /// <summary>
    /// Service réteg feladata az üzleti logika megvalósítása
    /// Kapcsolatot teremt a Controller és Repository réteg között
    /// </summary>

    partial class TeamService
    {
        TestData testData;
        F1 f1Repository;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public TeamService()
        {
            testData = new TestData();
            f1Repository = new F1();
        }

        /// <summary>
        /// Tesztadatok betöltése a repositoryba
        /// </summary>
        public void provideTestData()
        {
            f1Repository = testData.getTestData();
        }

        /// <summary>
        /// Adott nevű csapat létrehozása és hozzáadása a repository-hoz
        /// Üzleti logika: Ha nem létezik még adott nevű csapat akkor annak létrehozása
        /// </summary>
        /// <param name="teamName">A létrehozandó csapat neve</param>
        /// <exception cref="TeamServiceToGUIException">teamName+csapat már létezik</exception>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void addTeam(string teamName)
        {
            try
            {
                if (isExistTeam(teamName))
                    throw new TeamServiceToGUIException(teamName + " csapat már létezik.");
                Team t = new Team(teamName);
                f1Repository.add(t);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott nevű csapat átnevezése új csapat névre
        /// Üzleti logika: ha adott nevű csapat még nem létezik akkor a régi nevet új névre cseréli
        /// </summary>
        /// <param name="oldTeamName"></param>
        /// <param name="newTeamName"></param>
        /// <exception cref="TeamServiceToGUIException">teamName+csapat már létezik. Erre a névre nem lehet módosítani a nevét!</exception>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            try
            {
                if (isExistTeam(newTeamName))
                    throw new TeamServiceToGUIException(newTeamName + " csapat már létezik. Erre a névre nem lehet módosítani a nevét!");
                f1Repository.update(oldTeamName, newTeamName);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Csapat törlése
        /// Üzleti logika: ha létezik a csapat, és nincs versenyzője akkor a csapat törlése
        /// </summary>
        /// <param name="teamNameToDelete">A törlendő csapat neve</param>
        /// <exception cref="TeamServiceToGUIException> csapat nem létezik. Nem lehet törölni!"</exception>
        /// <exception cref="TeamServiceToGUIException> csapatnak van még versenyzője, nem lehet törölni!"</exception>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public void deleteTeam(string teamNameToDelete)
        {
            try
            {
                if (!isExistTeam(teamNameToDelete))
                    throw new TeamServiceToGUIException(teamNameToDelete + " csapat nem létezik. Nem lehet törölni!");
                int numberOfRacer = f1Repository.getNumberOfRacers(teamNameToDelete);
                if (numberOfRacer > 0)
                    throw new TeamServiceToGUIException(teamNameToDelete + " csapatnak van még versenyzője, nem lehet törölni!");
                else
                    f1Repository.delete(teamNameToDelete);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Összes csapat adatainak lekérése
        /// </summary>
        /// <returns>A csapatok listája</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public List<Team> getTeams()
        {
            try
            {
                return f1Repository.getTeams();
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Olyan csapatlista készítése, amely listába ki van hagyva egy adott nevű csapat
        /// </summary>
        /// <param name="teamName">A kihagyott csapat neve</param>
        /// <returns>Csapatlista kihagyva egy adott nevű csapatot</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public List<Team> getTeamsExclude(string teamName)
        {
            try
            {
                List<Team> teams = f1Repository.getTeams();
                List<Team> newTeamList = new List<Team>();
                foreach (Team t in teams)
                {
                    if (t.getName() != teamName)
                        newTeamList.Add(t);
                }
                return newTeamList;
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Adott nevű csapat létezik-e
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>true ha igen, és false ha nem</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public bool isExistTeam(string teamName)
        {
            try
            {
                if (f1Repository.isExist(teamName))
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
        /// Repository segítségével a Forma1 összköltségvetésének meghatározása
        /// </summary>
        /// <returns>F1 összköltségvetése</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public int getF1Salary()
        {
            try
            {
                return f1Repository.getF1Salary();
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        /// <summary>
        /// Repository segítségével a Forma1 egy csapatának összköltségvetésének meghatározása
        /// Űzleti logika: ha létezik a Team akkor a csapat összköltsége, ha nem akkor nulla
        /// </summary>
        /// <param name="teamName">Csapat neve</param>
        /// <returns>Az adott csapat összköltségge vagy nulla ha a csapat nem létezik</returns>
        /// <exception cref="TeamServiceException">f1Exception.Message</exception>
        public int getTeamSalary(string teamName)
        {
            try
            {
                if (!isExistTeam(teamName))
                    return 0;
                return f1Repository.getTeamSalary(teamName);
            }

            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);

            }
        }
    }
}
