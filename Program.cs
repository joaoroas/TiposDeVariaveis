using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
           // i = "s";

            var x = 2;

            char t = 'b';

            string t2 = "b";

            //x = "333";

           // string s = "João";
            var s2 = "João2";

            var f = 1.5f;
            float f2 = 1.5f;

            var d = 1.5;
            double d2 = 1.5;

            var bo = true;
            var bo2 = false;

            bool bol = true;
            bool bol2 = false;

            bool boolean = bool.Parse("false");
            bool boolean2 = Convert.ToBoolean("d");

            Animal a = new Animal();
            Leao l = new Leao();

            l = (Leao)a;

            a = l;








            Console.WriteLine(t);
            Console.WriteLine(t2);
           

        }
    }

    public class Animal
    {

    }

    public class Leao : Animal
    {

    }
}
