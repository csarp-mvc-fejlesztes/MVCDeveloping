using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    /// <summary>
    /// Interface más néven felületek,
    /// Nem valósítanak meg semmit, nincs is bennük konkrét kód utasítás formájában
    /// A felületek egy vázat adnak az őket implementáló osztályokhoz amelyeket az osztályok majd megvalósítanak.
    /// Minden amit egy interface-ben deklarálunk az interface-t implementáló osztálynak kivétel nélkül meg kell valósítania.
    /// 
    /// Tehát az Team osztályban kell legyen még addRacer, deleteRacer, updateRacer, getNumberOfRacers, serachRacerByName és is RacerExsist metódusa
    /// </summary>
    interface ITeamManageRacers
    {
        void addRacer(Racer r);
        void deleteRacer(string name,int age);
        void updateRacer(string name, Racer newRacer);

        int getNumberOfRacers();
        Racer searchRacerByName(string racerName);
        bool isRacerExist(string racerName, int racerAge);
    }
}
