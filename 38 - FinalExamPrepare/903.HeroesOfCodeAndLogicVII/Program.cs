namespace _903.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeros = int.Parse(Console.ReadLine());
            List<Hero> heros = new List<Hero>();

            for (int i = 0; i < numberOfHeros; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string heroName = arguments[0];
                int hitPoint = int.Parse(arguments[1]);
                if (hitPoint > 100)
                {
                    hitPoint = 100;
                }
                int manaPoint = int.Parse(arguments[2]);
                if (manaPoint > 200)
                {
                    manaPoint = 200;
                }

                Hero hero = new Hero(heroName, hitPoint, manaPoint);
                heros.Add(hero);
            }

            string argument = string.Empty;
            while ((argument = Console.ReadLine()) != "End")
            {
                string[] commands = argument
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                string heroName = commands[1];

                Hero currHero = heros.Where(h => h.HeroName == heroName).FirstOrDefault();

                if (command == "CastSpell")
                {
                    int manaPointNeeded = int.Parse(commands[2]);
                    string spellName = commands[3];
                    bool isHeroHaveMP = CheckMP(currHero, manaPointNeeded);
                    if (isHeroHaveMP)
                    {
                        ReduceMP(currHero, manaPointNeeded);
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {currHero.ManaPoint} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(commands[2]);
                    string attacker = commands[3];
                    ReduceHP(currHero, damage);
                    if (currHero.HitPoint > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currHero.HitPoint} HP left!");
                    }
                    else
                    {
                        heros.Remove(currHero);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }

                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(commands[2]);
                    RechargeMP(currHero,amount);
                    
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(commands[2]);
                    RechargeHP(currHero, amount);
                    
                }
            }

            PrintFinalResult(heros);
        }

        private static void PrintFinalResult(List<Hero> heros)
        {
            foreach (var currHero in heros)
            {
                Console.WriteLine(currHero.HeroName);
                Console.WriteLine($"  HP: {currHero.HitPoint}");
                Console.WriteLine($"  MP: {currHero.ManaPoint}");
            }
        }

        private static void RechargeHP(Hero currHero, int amount)
        {
            int firstHP = currHero.HitPoint; 
           currHero.HitPoint += amount;

            if (currHero.HitPoint > 100)
            {
                currHero.HitPoint = 100;
                Console.WriteLine($"{currHero.HeroName} healed for {100 - firstHP} HP!");
            }
            else 
            {
                Console.WriteLine($"{currHero.HeroName} healed for {amount} HP!");
            }
            
        }

        private static void RechargeMP(Hero currHero, int amount)
        {   
            int firtsMP = currHero.ManaPoint;
            currHero.ManaPoint += amount;
            if (currHero.ManaPoint > 200)
            {
                currHero.ManaPoint = 200;
                Console.WriteLine($"{currHero.HeroName} recharged for {200 - firtsMP} MP!");
            }
            else 
            {
                Console.WriteLine($"{currHero.HeroName} recharged for {amount} MP!");
            }
        }

        private static void ReduceHP(Hero currHero, int damage)
        {
            currHero.HitPoint -= damage;
        }

        private static void ReduceMP(Hero currHero, int manaPointNeeded)
        {
            currHero.ManaPoint -= manaPointNeeded;
        }

        private static bool CheckMP(Hero currHero, int manaPointNeeded)
        {
            bool isHeroHaveMP = false;
            if (currHero.ManaPoint >= manaPointNeeded)
            {
                return isHeroHaveMP = true;
            }
            return isHeroHaveMP;
        }
    }
    public class Hero
    {
        public Hero(string heroName, int hitPoint, int manaPoint)
        {
            HeroName = heroName;
            HitPoint = hitPoint;
            ManaPoint = manaPoint;
        }

        public string HeroName { get; set; }
        public int HitPoint { get; set; }
        public int ManaPoint { get; set; }
    }
}