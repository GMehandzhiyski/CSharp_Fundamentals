using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _403._HeroesОfCodeАndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersHeroes = int.Parse(Console.ReadLine());
            List<Hero> herosList = new List<Hero>();

            for (int i = 0; i < numbersHeroes; i++)
            {
                string[] addHero = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string heroName = addHero[0];
                int hp = int.Parse(addHero[1]);
                int mp = int.Parse(addHero[2]);

                Hero hero = new Hero(heroName, hp, mp);
                herosList.Add(hero);
            }

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "End")
            {
                string[] actions = argumets
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = actions[0];
                string heroName = actions[1];

                Hero currhero = herosList.Where(h => h.HeroName == heroName).FirstOrDefault();

                if (action == "CastSpell")
                {
                    int mpNeeded = int.Parse(actions[2]);
                    string spellName = actions[3];

                    bool isHeroHaveCast = CheckHeroCast(mpNeeded, currhero);
                    if (isHeroHaveCast)
                    {
                        int mpLeft = ReductionMp(herosList, mpNeeded, currhero);
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {mpLeft} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(actions[2]);
                    string attacker = actions[3];

                    int alivableHP = ReduceHp(currhero, damage);
                    if (alivableHP > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {alivableHP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        herosList.Remove(currhero);
                    }

                }
                else if (action == "Recharge")
                {
                    int amountMp = int.Parse(actions[2]);
                    int currMp = currhero.MP + amountMp;
                    int temporaryCurrMP = currhero.MP;
                    if (currMp > 200)
                    {
                        currhero.MP = 200;
                    }
                    else 
                    {
                        currhero.MP += amountMp;
                    }

                    Console.WriteLine($"{heroName} recharged for {200 - temporaryCurrMP} MP!");
                }
                else if (action == "Heal")
                {
                    int amountHp = int.Parse(actions[2]);
                    int currMp = currhero.HP + amountHp;
                    int temporaryCurrHP = currhero.HP;
                    if (currMp > 100)
                    {
                        currhero.HP = 100;
                        Console.WriteLine($"{heroName} healed for {100 - temporaryCurrHP} HP!");
                    }
                    else
                    {
                        currhero.HP += amountHp;
                        Console.WriteLine($"{heroName} healed for {amountHp} HP!");
                    }
                    
                }
                else
                {
                    continue;
                }
            }

            foreach (var hero in herosList)
            {
                Console.WriteLine($"{hero.HeroName}\n HP: {hero.HP}\n MP: {hero.MP}");


            }
        }

        private static int ReduceHp(Hero currhero, int damage)
        {  
            return currhero.HP -= damage;
        }

        private static int ReductionMp(List<Hero> herosList, int mpNeeded, Hero currhero)
        {
            return currhero.MP -= mpNeeded;
        }

        private static bool CheckHeroCast(int mpNeeded, Hero currhero)
        {
            return (currhero.MP >= mpNeeded);
        }
    }
    public class Hero
    {
        public Hero(string heroName, int hp, int mp)
        {
            HeroName = heroName;
            HP = hp;
            MP = mp;
        }
        public string HeroName { get; set; }
        public int HP { get; set; }

        public int MP { get; set; }

    }
}
