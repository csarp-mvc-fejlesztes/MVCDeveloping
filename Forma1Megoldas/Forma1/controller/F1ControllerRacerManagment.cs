using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Forma1.validation;
using Forma1.myexeption;
using Forma1.repository;

namespace Forma1.controller
{
    partial class F1Controller
    {
        /// <summary>
        /// Versenyző hozzáadása a csapathoz
        /// TeamName nem lehet üres, recerAgeNumber, racerSaleryNumber konvertálása, megfelelő ControlterException dobás hiba esetén
        /// racerName tesztelés NameValidatorral és üres név és név nem nagybetűvel kezdődik kivételek kezelése (lásd NameValidator osztályt)
        /// Egy versenyző létrehozása, akinek a megadott adatok lesznek az adatai, ID-je -1 (a service réteg ad neki ID-t)
        /// A service réteg segítségével a létrehozott új versenyző hozzáadása a csapathoz
        /// Service réteg TeamServiceToGUIException és TeamServiceException elkapása.
        /// A Racer modell RacerException kivétel elkapása
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// Service réteg TeamServiceToGUIException és TeamServiceException elkapása.
        /// A Racer modell RacerException kivétel elkapása
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <param name="racerSalary">A versenyző bérköltsége</param>
        /// <exception cref="ControllerException">A csapat név nem lehet üres string. Előbb hozza létre a csapatot, utánna adja hozzá a versenyzőt.</exception>
        /// <exception cref="ControllerException">A megadott életkor nem megfelelő alakú szám!</exception>
        /// <exception cref="ControllerException">A megadott fizetés nem megfelelő alakú szám!</exception>
        /// <exception cref="ControllerException">A versenyző életkora nem lehet nulla vagy negatív.</exception>
        /// <exception cref="ControllerException">A versenyző fizetése nem lehet nulla vagy negatív.</exception>
        /// <exception cref="ControllerException">racerName + " nem megfelelő versenyző név, mivel üres.</exception>
        /// <exception cref="ControllerException">racerName + " nem megfelelő versenyző név, mivel az első betű nem nagybetű.</exception>
        /// <exception cref="ControllerException">TeamServiceToGUIException.Message</exception>
        /// <exception cref="ControllerException">RacerException.Message</exception>
        public void addRacerToTeam(string teamName, string racerName, string racerAge, string racerSalary)
        {
            if (teamName == string.Empty)
                throw new ControllerException("A csapat név nem lehet üres string. Előbb hozza létre a csapatot, utánna adja hozzá a versenyzőt.");
            int racerAgeNumber = 0;
            if (!int.
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            int racerSalaryNumber = 0;
            if (!int.
                throw new ControllerException("A megadott fizetés nem megfelelő alakú szám!");
            if (racerAgeNumber <= 0)
                throw new ControllerException("A versenyző életkora nem lehet nulla vagy negatív.");
            if (racerSalaryNumber <= 0)
                throw new ControllerException("A versenyző fizetése nem lehet nulla vagy negatív.");

            try
            {
                NameValidator nv = new NameValidator(racerName);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException nnve)
            {
                Debug.WriteLine(nnve.Message);
                throw new ControllerException(racerName + " nem megfelelő versenyző név, mivel üres.");
            }
            catch (NameNotValidFirstLetterProblemException nnve)
            {
                Debug.WriteLine(nnve.Message);
                throw new ControllerException(racerName + " nem megfelelő versenyző név, mivel az első betű nem nagybetű.");
            }

            try
            {                
                Racer newRacer = new Racer(-1, racerName, racerAgeNumber, racerSalaryNumber);
                teamService.addReacerToTeam(teamName, newRacer);
            }
            catch (TeamServiceToGUIException tsge)
            {
                Debug.WriteLine(tsge.Message);
                throw new ControllerException(tsge.Message);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
            catch (RacerException re)
            {
                Debug.WriteLine(re.Message);
                throw new ControllerException(re.Message);
            }
        }

        /// <summary>
        /// Versenyző adatainak módosítása
        /// TeamName nem lehet üres, recerAgeNumber, racerSaleryNumber konvertálása, megfelelő ControlterException dobás hiba esetén
        /// racerName tesztelés NameValidatorral és üres név és név nem nagybetűvel kezdődik kivételek kezelése (lásd NameValidator osztályt)
        /// Egy versenyző létrehozása, akinek a megadott adatok lesznek az adatai, ID-je -1 (a service réteg ad neki ID-t)
        /// Service réteg segítségével adatmódosítás
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// Service réteg TeamServiceToGUIException és TeamServiceException elkapása.
        /// A Racer modell RacerException kivétel elkapása
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével.
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="oldRacerName">A versenyző régi neve</param>
        /// <param name="racerName">A versenyző új neve</param>
        /// <param name="racerAge">A versenyző új neve</param>
        /// <param name="racerSalary">A versenyző költsége</param>
        /// <exception cref="ControllerException">A csapat név nem lehet üres string. Előbb hozza létre a csapatot, utánna adja hozzá a versenyzőt.</exception>
        /// <exception cref="ControllerException">A megadott életkor nem megfelelő alakú szám!</exception>
        /// <exception cref="ControllerException">A megadott fizetés nem megfelelő alakú szám!</exception>
        /// <exception cref="ControllerException">A versenyző életkora nem lehet nulla vagy negatív.</exception>
        /// <exception cref="ControllerException">A versenyző fizetése nem lehet nulla vagy negatív.</exception>
        /// <exception cref="ControllerException">racerName + " nem megfelelő versenyző név, mivel üres.</exception>
        /// <exception cref="ControllerException">racerName + " nem megfelelő versenyző név, mivel az első betű nem nagybetű.</exception>
        /// <exception cref="ControllerException">TeamServiceToGUIException.Message</exception>
        /// <exception cref="ControllerException">RacerException.Message</exception>
        public void updateRacerInTeam(string teamName, string oldRacerName, string racerName, string racerAge, string racerSalary)
        {
            if (teamName == string.Empty)
                throw new ControllerException("A csapat név nem lehet üres string. Előbb hozza létre a csapatot, utánna adja hozzá a versenyzőt.");
            int racerAgeNumber = 0;
            if (!int.TryParse(racerAge, out racerAgeNumber))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            int racerSalaryNumber = 0;
            if (!int.TryParse(racerSalary, out racerSalaryNumber))
                throw new ControllerException("A megadott fizetés nem megfelelő alakú szám!");
            if ()
                throw new ControllerException("A versenyző életkora nem lehet nulla vagy negatív.");
            if ()
                throw new ControllerException("A versenyző fizetése nem lehet nulla vagy negatív.");

            try
            {
                NameValidator nv = new NameValidator(racerName);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException nnve)
            {
                Debug.WriteLine(nnve.Message);
                throw new ControllerException(racerName + " nem megfelelő versenyző név, mivel üres.");
            }
            catch (NameNotValidFirstLetterProblemException nnve)
            {
                Debug.WriteLine(nnve.Message);
                throw new ControllerException(racerName + " nem megfelelő versenyző név, mivel az első betű nem nagybetű.");
            }

            try
            {
                Racer newRacer = new Racer(-1, racerName, racerAgeNumber, racerSalaryNumber);
                teamService.updateReacerInTeam(teamName, oldRacerName, newRacer);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
            catch (RacerException re)
            {
                Debug.WriteLine(re.Message);
                throw new ControllerException(re.Message);
            }
        }

        /// <summary>
        /// Adott csapatban lévő versenyző törlése
        /// TeamName nem lehet üres, megfelelő ControlterException dobás hiba esetén
        /// racerAge konvertáláa, hiba esetén hibaüzenet a Dubug osztály segítségével
        /// Service réteg segítségével versenyző törlése
        /// TeamServiceException esetén hibamegjelenítés a Debug osztály segítségével
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <exception cref="TeamServiceException">TeamServiceException.Message</exception>
        public void deleteRacerFromTeam(string teamName, string racerName, string racerAge)
        {
            if (teamName == string.Empty)
                throw new ControllerException("A csapat név nem lehet üres string. Előbb hozza létre a csapatot, utánna törölje a versenyzőt.");
            int racerAgeNumber = 0;
            if (!int.TryParse(racerAge, out racerAgeNumber))
            {
                Debug.WriteLine(???);
                return;
            }
            try
            {
                teamService.deleteRacerInTeam(teamName, racerName, racerAgeNumber);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        /// <summary>
        /// Ha csapat versenyzőinek listája
        /// Service réteg segítségével versenyző törlése
        /// TeamServiceException esetén hibamegjelenítés a Debug osztály segítségével és visszatérési érték az üres lista
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A versenyző nevek listája</returns>
        public List<string> getTeamRacersName(string teamName)
        {
            List<string> racersName = new List<string>();
            try
            {                                   
                    List<Racer> racers = teamService.
                    return racersName;
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                return racersName;
            }
        }

        /// <summary>
        /// A csapat adott nevű versenyzőjének megkeresése
        /// TeamServiceException esetén hibamegjelenítés a Debug osztály segítségével és visszatérési érték null
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>Az adott csapat adott nevű versenyzője</returns>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            try
            {
                Racer foundedRacer = teamService.searchRacerByName(teamName, racerName);
                return foundedRacer;
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                return null;
            }
        }
    }
}
