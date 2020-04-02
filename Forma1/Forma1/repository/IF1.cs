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
    /// Tehát az F1 osztályban kell legyen add, update, delete és getF1Salary metódusa
    /// </summary>
    interface IF1
    {
        void add(Team t);
        void update(string teamName, string newTeamName);
        void delete(string teamName);

        int getF1Salary();
    }
}
