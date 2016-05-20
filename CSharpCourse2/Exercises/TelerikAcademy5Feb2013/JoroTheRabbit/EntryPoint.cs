namespace JoroTheRabbit
{
    //95/100 BgCoder. Author's solution gives the same result
    using System;
    using System.Linq;
    
    class EntryPoint
    {
        static void Main()
        {
            var terrain = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();
            int maxJumpLength = 0;

            for (int i = 0; i < terrain.Length; i++)
            {
                for (int currentStep = 1; currentStep < terrain.Length; currentStep++)
                {
                    int currentJumpLenght = 1;
                    int currentPositionOnTerrain = i;
                    int next = (currentPositionOnTerrain + currentStep) % terrain.Length;

                    while (terrain[currentPositionOnTerrain] < terrain[next])
                    {
                        currentJumpLenght++;
                        currentPositionOnTerrain = next;
                        next = (currentPositionOnTerrain + currentStep) % terrain.Length;

                    }

                    if (currentJumpLenght > maxJumpLength)
                    {
                        maxJumpLength = currentJumpLenght;
                    }
                }
                
            }

            Console.WriteLine(maxJumpLength);
        }
    }
}
