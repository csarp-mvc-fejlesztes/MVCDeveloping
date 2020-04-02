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
    /// Tehát az Team osztályban kell legyen getName, update, deleteAllRacersInTeam, getTeamSalary és getRacers metódusa
    /// </summary>
    interface ITeam
    {
        string getName();
        void update(string newName);
        void deleteAllRacersInTeam();
        int getTeamSalary();
        List<Racer> getRacers();

    }
}
