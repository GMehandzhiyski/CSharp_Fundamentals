namespace _10.Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());// N
            int pokeDistance = int.Parse(Console.ReadLine()); // M  
            int pokeExhaustionFactor = int.Parse(Console.ReadLine()); // Y   


            int pokePoweProces = 0;
            pokePoweProces =  pokePower; // take from N

            int countTargets = 0;
            while (pokeDistance <= pokePoweProces ) 
            {
                pokePoweProces = pokePoweProces - pokeDistance;
                countTargets++;// targets

                int middelPokePower = pokePower / 2; //50% of begin value

                if (pokePoweProces == middelPokePower){pokePoweProces = pokePoweProces / pokeExhaustionFactor;}
            }

            Console.WriteLine(pokePoweProces);
            Console.WriteLine(countTargets);

            
        }
    }
}