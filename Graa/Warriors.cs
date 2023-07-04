using Graa;

namespace Graa
{
    internal class Warriors
    {
        private int numWar;
        private List<Warrior> warriors;
        public void KWar()
        {
            Console.WriteLine("Podaj liczbe wojownikow: ");


numWar = int.Parse(Console.ReadLine());

        }
        public void genWar()
        {
            warriors = new List<Warrior>();

            Random random = new Random();
            for (int i = 0; i < numWar; i++)
            {
                int typ = random.Next(3);
                if (typ == 0)
                {
                    warriors.Add(new Warrior($"Łucznik {(i + 1)}", 90, 30));
        } 
        else if (typ==1) {
warriors.Add(new Warrior($"Mag; +{ (i+1)}", 100, 25));
} 
    else if (typ == 2)
{
    warriors.Add(new Warrior($"Nekromanta(i + 1)" , 150, 15));
}}
foreach (Warrior warrior in warriors)
{
    Console.WriteLine(warrior.getName() + "ma" + warrior.getHp() + "hp");
}}}}

    