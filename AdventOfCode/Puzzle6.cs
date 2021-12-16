namespace AdventOfCode
{
    class Puzzle6
    {
        int[] inputs = new int[] { 5, 1, 1, 1, 3, 5, 1, 1, 1, 1, 5, 3, 1, 1, 3, 1, 1, 1, 4, 1, 1, 1, 1, 1, 2, 4, 3, 4, 1, 5, 3, 4, 1, 1, 5, 1, 2, 1, 1, 2, 1, 1, 2, 1, 1, 4, 2, 3, 2, 1, 4, 1, 1, 4, 2, 1, 4, 5, 5, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 1, 5, 5, 1, 1, 4, 4, 5, 1, 1, 1, 3, 1, 5, 1, 2, 1, 5, 1, 4, 1, 3, 2, 4, 2, 1, 1, 4, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 3, 5, 4, 1, 1, 3, 1, 1, 1, 2, 1, 1, 1, 1, 5, 1, 1, 1, 4, 1, 4, 1, 1, 1, 1, 1, 2, 1, 1, 5, 1, 2, 1, 1, 2, 1, 1, 2, 4, 1, 1, 5, 1, 3, 4, 1, 2, 4, 1, 1, 1, 1, 1, 4, 1, 1, 4, 2, 2, 1, 5, 1, 4, 1, 1, 5, 1, 1, 5, 5, 1, 1, 1, 1, 1, 5, 2, 1, 3, 3, 1, 1, 1, 3, 2, 4, 5, 1, 2, 1, 5, 1, 4, 1, 5, 1, 1, 1, 1, 1, 1, 4, 3, 1, 1, 3, 3, 1, 4, 5, 1, 1, 4, 1, 4, 3, 4, 1, 1, 1, 2, 2, 1, 2, 5, 1, 1, 3, 5, 2, 1, 1, 1, 1, 1, 1, 1, 4, 4, 1, 5, 4, 1, 1, 1, 1, 1, 2, 1, 2, 1, 5, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 3, 1, 5, 3, 3, 1, 1, 2, 4, 4, 1, 1, 2, 1, 1, 3, 1, 1, 1, 1, 2, 3, 4, 1, 1, 2 };

        public void Run1()
        {   //naive solution - does not scale
            List<int> fishes = new List<int>(inputs);

            for(int day = 0; day < 80; day++)
            {
                int currentFishes = fishes.Count;
                for (int i = 0; i<currentFishes; i++)
                {
                    if (fishes[i] == 0)
                    {
                        fishes[i] = 6;
                        fishes.Add(8);
                    }
                    else
                    {
                        fishes[i]--;
                    }
                }
            }

            Console.WriteLine($"Fishes {fishes.Count}");
        }

        public void Run2()
        {
            long[] counts = new long[9];
            for (int i = 0; i < inputs.Length; i++)
            {
                counts[inputs[i]]++;
            }

            List<long> countArrays = counts.ToList();

            for (int i = 0; i < 256; i++)
            {
                countArrays.Add(countArrays[0]);
                countArrays[7] += countArrays[0];
                countArrays.RemoveAt(0);
            }

            long total = countArrays.Sum();
            Console.WriteLine($"Total {total}");
        }
    }
}
