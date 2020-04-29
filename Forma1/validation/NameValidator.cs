using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    /// <summary>
    /// A konstruktorban kapott névről eldönti, hogy helyes formátumú-e
    /// Két dolgot ellenőriz:
    ///  - a név nem lehet üres string
    ///  - a név első betűje nagybetű
    /// </summary>
    public class NameValidator
    {
        /// <summary>
        /// Az eltárolt név amit vizsgálunk
        /// </summary>
        private string name;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">A név amit ellenőrizni kell</param>
        public NameValidator(string name)
        {
            this;
        }
        /// <summary>
        /// Az ellenőrzéseket végző metódus
        /// </summary>
        public void validation()
        {
            if ()
                throw new NameNotValidNameIsEmptyException("A név nem lehet üres!");
            if ()
                throw new NameNotValidFirstLetterProblemException("A név nagy kezdőbetűvel kell kezdőjön!");
        }

        /// <summary>
        /// Az első betű nagybetű-e
        /// </summary>
        /// <returns>Igaz, ha az első betű nagybetű</returns>
        private bool isFistLetterUppercase()
        {
            return true;
        }

        /// <summary>
        /// A név üres string-e
        /// </summary>
        /// <returns>Igaz, ha a név üres</returns>
        private bool isEmptyName()
        {
            return false;
        }
    }
}
