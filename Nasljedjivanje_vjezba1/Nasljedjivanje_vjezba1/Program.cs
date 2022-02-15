using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_vjezba1
{
    internal class Program
    {

        class NebeskoTijelo
        {
            double brzinaOkoOsi;
            double brzinaOkoSunca;

            public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
            public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }

            public virtual string Ispis()
            {
                return "Nebesko tijelo ima brzinu oko osi: " + brzinaOkoOsi + " i brzinu oko Sunca: " + brzinaOkoSunca + ".";
            }
        }

        class Planet : NebeskoTijelo
        {
            public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
            {
                BrzinaOkoOsi = brzinaOkoOsi;
                BrzinaOkoSunca = brzinaOkoSunca;
            }

            public override string Ispis()
            {
                return "Planet ima ima brzinu oko osi: " + BrzinaOkoOsi + " i brzinu oko Sunca: " + BrzinaOkoSunca + "."; 
            }
        }

        class Satelit : NebeskoTijelo
        {
            public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
            {
                BrzinaOkoOsi = brzinaOkoOsi;
                BrzinaOkoSunca = brzinaOkoSunca;
            }

            public override string Ispis()
            {
                return "Satelit ima ima brzinu oko osi: " + BrzinaOkoOsi + " i brzinu oko Sunca: " + BrzinaOkoSunca + ".";
            }
        }

        static void Main(string[] args)
        {
            NebeskoTijelo tijelo = new NebeskoTijelo();
            Planet planet = new Planet(1000, 2000);
            Satelit satelit = new Satelit(100, 200);

            Console.WriteLine(tijelo.Ispis());
            Console.WriteLine(planet.Ispis());
            Console.WriteLine(satelit.Ispis());

            Console.ReadKey();
        }
    }
}
