using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Forma1.repository
{
    class TestData
    {
        public F1 getTestData()
        {
            F1 f1 = new F1();
            try
            {
                Racer r1 = new Racer(1, "Hamilton", 34, 245);
                Racer r2 = new Racer(2, "Raikonen", 39, 45);
                Racer r3 = new Racer(3, "Bottas", 27, 50);
                Racer r4 = new Racer(4, "Vettel", 31, 182);
                Racer r5 = new Racer(5, "Verstappen", 21, 70);

                Team t1 = new Team("Mc Laren");
                Team t2 = new Team("Ferrari");

                t1.addRacer(r1);
                t1.addRacer(r3);
                t2.addRacer(r2);
                t2.addRacer(r4);
                t2.addRacer(r5);

                f1.add(t1);
                f1.add(t2);
                return f1;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return f1;
            }
            
        }
    }
}
