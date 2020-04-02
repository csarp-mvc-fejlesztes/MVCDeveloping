using Forma1.myexeption;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    class Racer
    {
        private int id;
        private string name;
        private int age;
        private int salary;


        /// <summary>
        /// Versenyző konstuktor
        /// NameValidator osztállyal ellenőrizzük, hogy a név megfelelő-e!
        /// </summary>
        /// <param name="id">Versenyző azonosító</param>
        /// <param name="name">Versenyző neve</param>
        /// <param name="age">Versenyző életkora</param>
        /// <param name="salary">Versenyző fizetése</param>
        /// <exception cref="RacerException">Versenyző nevét nem lehet üressen hagyni!</exception>
        /// <exception cref="RacerException">Versenyző neve nagy betűvel kell kezdődjön!</exception>
        public Racer(int id, string name, int age, int salary)
        {
            
            NameValidator nv = new NameValidator(name);
            try
            {
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException)
            {
                throw new RacerException("Versenyző nevét nem lehet üressen hagyni!");
            }            
            catch( NameNotValidFirstLetterProblemException)
            {
                throw new  RacerException("Versenyző neve nagy betűvel kell kezdődjön!");
            }
            this.id = id;       
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        /// <summary>
        /// Versenyző id megadása
        /// </summary>
        /// <param name="id">A versenyző új id-je</param>
        public void setId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Versenyző nevének megadása
        /// </summary>
        /// <param name="name">A versenyző új neve</param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// A versenyző életkorának megadása
        /// </summary>
        /// <param name="age">A versenyző új életkora</param>
        public void setAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// A versenyző fizetésének megadása
        /// </summary>
        /// <param name="salary">A versenyző új fizetése</param>
        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        /// <summary>
        /// A versenyző azonosítójának lekérése
        /// </summary>
        /// <returns>A versenyző azonosítója</returns>
        public int getId()
        {
            return id;
        }

        /// <summary>
        /// A versenyző nevének lekérése
        /// </summary>
        /// <returns>A versenyző neve</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// A versenyző életkorának megadása
        /// </summary>
        /// <returns>A versenyző életkora</returns>
        public int getAge()
        {
            return age;
        }

        /// <summary>
        /// A versenyző fizetésének lekérése
        /// </summary>
        /// <returns>A versenyző fizetése</returns>
        public int getSalary()
        {
            return salary;
        }

        /// <summary>
        /// A versenyző adatainak módosítása
        /// </summary>
        /// <param name="racer">A versenyző adatai ennek a versenyzőnek az adatait veszi fel</param>
        public void update(Racer racer)
        {
            this.id = racer.getId();
            this.name = racer.getName();
            this.age = racer.getAge();
            this.salary = racer.getSalary();
        }

        /// <summary>
        /// A versenyző adatainak megjelenítése
        /// Általában a Debug.WriteLine-ban használható
        /// </summary>
        /// <returns>A versenyző adatai string formátumban</returns>
        public override string ToString()
        {
            return id+". "+name+" "+age+" éves és fizetése "+salary;
        }
    }
}
