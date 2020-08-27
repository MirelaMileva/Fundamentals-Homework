using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonDistance = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sum = 0;
            var temp = 0;

            while (pokemonDistance.Count > 0)
            {
                if (index < 0)
                {
                    temp = pokemonDistance[0];
                    sum += temp;
                    pokemonDistance[0] = pokemonDistance[pokemonDistance.Count - 1];

                    for (int i = 0; i < pokemonDistance.Count; i++)
                    {
                        if (pokemonDistance[i] <= temp)
                        {
                            pokemonDistance[i] += temp;
                        }

                        else 
                        {
                            pokemonDistance[i] -= temp;
                        }
                    }
                }
                else if (index > pokemonDistance.Count - 1)
                {
                    temp = pokemonDistance[pokemonDistance.Count - 1];
                    sum += temp;
                    pokemonDistance[pokemonDistance.Count - 1] = pokemonDistance[0];
                    for (int i = 0; i < pokemonDistance.Count; i++)
                    {
                        if (pokemonDistance[i] <= temp)
                        {
                            pokemonDistance[i] += temp;
                        }
                        else 
                        {
                            pokemonDistance[i] -= temp;
                        }
                    }
                }
                else
                {
                    temp = pokemonDistance[index];
                    sum += temp;
                    pokemonDistance.RemoveAt(index);

                    for (int i = 0; i < pokemonDistance.Count; i++)
                    {
                        if (pokemonDistance[i] <= temp)
                        {
                            pokemonDistance[i] += temp;
                        }
                        else
                        {
                            pokemonDistance[i] -= temp;
                        }
                    }
                }

                if (pokemonDistance.Count == 0)
                {
                    break;
                }

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);

        }
    }
}
